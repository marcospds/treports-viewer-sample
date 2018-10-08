﻿using CefSharp;
using System.Security.Cryptography.X509Certificates;

namespace SampleTReportsViewerCSharpForm
{
  class ChromeBrowserRequestHandler : IRequestHandler
  {
    public string AccessToken { get; set; }

    public ChromeBrowserRequestHandler(string accessToken)
    {
      AccessToken = accessToken;
    }

    public bool GetAuthCredentials(IWebBrowser browserControl, IBrowser browser, IFrame frame, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
    {
      return false;
    }

    public bool OnBeforeBrowse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, bool isRedirect)
    {
      return false;
    }

    public bool OnBeforePluginLoad(IWebBrowser browser, string url, string policyUrl, WebPluginInfo info)
    {
      return false;
    }

    public CefReturnValue OnBeforeResourceLoad(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
    {
      var headers = request.Headers;
      headers["Authorization"] = $" Bearer {AccessToken} ";
      request.Headers = headers;

      return CefReturnValue.Continue;
    }

    public bool OnCertificateError(IWebBrowser browser, CefErrorCode errorCode, string requestUrl)
    {
      return false;
    }

    public void OnPluginCrashed(IWebBrowser browser, string pluginPath)
    {
    }

    public void OnRenderProcessTerminated(IWebBrowser browserControl, IBrowser browser, CefTerminationStatus status)
    {
    }

    public IResponseFilter GetResourceResponseFilter(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response)
    {
      return null;
    }

    public bool OnCertificateError(IWebBrowser browserControl, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
    {
      return false;
    }

    public bool OnOpenUrlFromTab(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
    {
      return false;
    }

    public void OnPluginCrashed(IWebBrowser browserControl, IBrowser browser, string pluginPath)
    {
    }

    public bool OnProtocolExecution(IWebBrowser browserControl, IBrowser browser, string url)
    {
      return false;
    }

    public bool OnQuotaRequest(IWebBrowser browserControl, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
    {
      return false;
    }

    public void OnRenderViewReady(IWebBrowser browserControl, IBrowser browser)
    {
    }

    public void OnResourceLoadComplete(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
    {
    }

    public void OnResourceRedirect(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, ref string newUrl)
    {
    }

    public bool OnResourceResponse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response)
    {
      return false;
    }

    public bool OnSelectClientCertificate(IWebBrowser browserControl, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
    {
      return false;
    }

    public bool CanGetCookies(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request)
    {
      return false;
    }

    public bool CanSetCookie(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, Cookie cookie)
    {
      return false;
    }

    public void OnResourceRedirect(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, ref string newUrl)
    {
    }

    public bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
    {
      return false;
    }
  }
}
