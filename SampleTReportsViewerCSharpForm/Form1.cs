using CefSharp.WinForms;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleTReportsViewerCSharpForm
{
  public partial class Form1 : Form
  {
    private string AccessToken;
    private string UidRequest;
    private ChromiumWebBrowser browser;

    public Form1()
    {
      InitializeComponent();
      browser = new ChromiumWebBrowser()
      {
        Dock = DockStyle.Fill
      };
      panel1.Controls.Add(browser);
      timer1.Start();
    }

    private void buttonGerar_Click(object sender, EventArgs e)
    {
      RequestViewer().Wait();
      OpenBrowser();
    }

    /// <summary>
    /// Executa os processos para abrir a visualização do relatório
    /// </summary>
    private async Task RequestViewer()
    {
      await GetAccessTokenUsingUserCredentials();

      string executeResponse = await ExecuteReport();

      GetUidRequest(executeResponse);
    }

    /// <summary>
    /// Busca o token de acesso de acordo com as credenciais informadas
    /// </summary>
    private async Task GetAccessTokenUsingUserCredentials()
    {
      string clientId = textClientId.Text;
      string clientSecret = textClientSecret.Text;
      string userName = textUser.Text;
      string password = textPassword.Text;
      string scope = textScope.Text; //"authorization_api, openid, profile, email";
      string racUrl = textRacUrl.Text;
      string tenant = $"tenant:{textTenant.Text}";

      var discoveryClient = new DiscoveryClient(racUrl);
      discoveryClient.Policy.RequireHttps = false;

      var discoveryResponse =
        discoveryClient
          .GetAsync()
          .Result;
      if (discoveryResponse.IsError)
      {
        throw new Exception(discoveryResponse.Error);
      }

      var client = new TokenClient(discoveryResponse.TokenEndpoint, clientId, clientSecret);

      // Para um tenant especifíco
      var optional = new
      {
        acr_values = tenant
      };

      var response =
        client
          .RequestResourceOwnerPasswordAsync(userName, password, scope, optional)
          .Result;

      if (response.IsError)
      {
        throw new Exception(response.Error);
      }

      AccessToken = response.AccessToken;
    }

    /// <summary>
    /// Envia uma requisição para o servidor, podendo enviar os parâmetros e também os filtros definidos pelo usuário
    /// </summary>
    /// <returns>Conteúdo da resposta da requisição</returns>
    private async Task<string> ExecuteReport()
    {
      if (string.IsNullOrEmpty(AccessToken) ||
        //Identificador único do relatório. Esse valor é armazenado juntamente com o relatório. Portanto, ao realizar 
        //essa chamada o desenvolvedor deve resgatá-la do relatório que o usuário está trabalhando no momento.
        string.IsNullOrEmpty(textUid.Text))
        throw new InvalidOperationException();

      HttpResponseMessage responseMessage;
      using (HttpClient httpClient = new HttpClient())
      {
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"{GetBaseUrl(textBackendPort.Text)}/api/trep/v1/reports/{textUid.Text}/execute");
        request.Content = new StringContent(
          @"{
              ""generateParams"": 
              {
                ""isView"": true,
                ""stopExecutionOnError"": true
              },
              ""scheduleParams"": 
              {
                ""type"": 0
              }
            }",
          Encoding.UTF8,
          "application/json");
        responseMessage = httpClient.SendAsync(request).Result;
      }

      return await responseMessage.Content.ReadAsStringAsync();
    }

    /// <summary>
    /// Busca o identificador único da requisição criada pelo usuário
    /// </summary>
    /// <param name="executeResponse">Conteúdo da resposta da requisição</param>
    private void GetUidRequest(string executeResponse)
    {
      if (string.IsNullOrEmpty(executeResponse))
        throw new ArgumentException(nameof(executeResponse));
      dynamic data = JsonConvert.DeserializeObject(executeResponse);
      UidRequest = data.uIdRequest;
    }

    /// <summary>
    /// Abre a visualização de relatório contendo os parâmetros e filtros informados anteriormente pelo usuário
    /// </summary>
    private void OpenBrowser()
    {
      if (UidRequest == null)
        throw new InvalidOperationException();

      string url = $"{GetBaseUrl(textFrontendPort.Text)}/reportsviewer/external/{UidRequest}";

      browser.RequestHandler = new ChromeBrowserRequestHandler(AccessToken);
      browser.Load(url);
    }

    private object GetBaseUrl(string port)
    {
      return textUrlTReports.Text.Contains("{0}") ? string.Format(textUrlTReports.Text, port) : textUrlTReports.Text;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      // Efetua o refresh token de 5 em 5 minutos.
      // Esse intervalo pode ser alterado de acordo com a configuração do tempo de expiração do Rac.
      // Isso evitará expiração do token configurado no browser e consequentemente
      // impedindo a comunitação da tela de visualização de relátórios com a API do TReports que
      // está protegida.
      GetAccessTokenUsingUserCredentials();
      browser.RequestHandler = new ChromeBrowserRequestHandler(AccessToken);
    }
  }
}
