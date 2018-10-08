# TReportsViewerSample
Esse projeto demonstra um exemplo de visualização de relatórios do TReports.
Para a visualização do relatório é necessário ter um **AccessToken** válido para o **RAC** e também algumas informações do relatório que será gerado.

Parâmetros
===
Segue uma breve descrição dos parâmetros que serão utilizados para a geração do relatório.
![alt text][logo]

[logo]: https://github.com/totvs/treports-viewer-sample/blob/master/images/Parametros.png "Main parameters"

Url do Rac
---
É o endereço do Rac do tenant correspondente à sua empresa.

Escopo
---
Escopo que será utilizado para autenticação

Client Id
---
Client Id que será utilizado para autenticação

Client Secret
---
Client Secret que será utilizado para autenticação

UId do Relatório
---
Identificador universal do relatório. Esse identificador é único e deve representar um relatório existente na base de dados. É o relatório que será visualizado pelo usuário.

Tenant
---
É o tenant correspondente à sua empresa.

Usuário
---
Usuário válido para o tenant informado.

Senha
---
Senha do usuário informado.

Url TReports
---
Endereço base de onde o TReports está hospedado. Se for necessário informar portas específicas para o frontend e o backend deve-se preencher a porta de cada um desses nos parâmetros seguintes e preencher a URL com um "{0}" informando o local onde a porta deve ser automaticamente inserida. Por exemplo, ao utilizar http://localhost:{0}/Treports o {0} informando as portas 7017 e 4999 para o frontend e backend respectivamente o sistema irá utilizar a url http://localhost:7017/Treports para o frontend e http://localhost:4999/Treports para o backend.

Porta Front
---
Informa a porta que está sendo utilizada pelo Frontend do TReports. **Atualmente o ambiente é unificado e serão utilizadas as mesmas portas para o Frontend e o Backend**. Porém é possível que sejam utilizados portas distintas.

Porta Back
---
Informa a porta que está sendo utilizada pelo Backend do TReports. **Atualmente o ambiente é unificado e serão utilizadas as mesmas portas para o Frontend e o Backend**. Porém é possível que sejam utilizados portas distintas.

Gerar
---
Será gerado o relatório e exibido nessa aplicação de exemplo.

<a href="http://www.youtube.com/watch?feature=player_embedded&v=K1Ik28wSp0c
" target="_blank"><img src="http://img.youtube.com/vi/K1Ik28wSp0c/3.jpg" 
alt="IMAGE ALT TEXT HERE" width="240" height="180" border="10" /></a>
