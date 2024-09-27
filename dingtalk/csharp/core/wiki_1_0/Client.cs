// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkwiki_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条名称获取该词条释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsDetailRequest
        /// </param>
        /// <param name="headers">
        /// WikiWordsDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsDetailResponse
        /// </returns>
        public WikiWordsDetailResponse WikiWordsDetailWithOptions(WikiWordsDetailRequest request, WikiWordsDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                query["wordName"] = request.WordName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WikiWordsDetail",
                Version = "wiki_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/wiki/words/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WikiWordsDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条名称获取该词条释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsDetailRequest
        /// </param>
        /// <param name="headers">
        /// WikiWordsDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsDetailResponse
        /// </returns>
        public async Task<WikiWordsDetailResponse> WikiWordsDetailWithOptionsAsync(WikiWordsDetailRequest request, WikiWordsDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                query["wordName"] = request.WordName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WikiWordsDetail",
                Version = "wiki_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/wiki/words/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WikiWordsDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条名称获取该词条释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsDetailResponse
        /// </returns>
        public WikiWordsDetailResponse WikiWordsDetail(WikiWordsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WikiWordsDetailHeaders headers = new WikiWordsDetailHeaders();
            return WikiWordsDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据词条名称获取该词条释义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsDetailResponse
        /// </returns>
        public async Task<WikiWordsDetailResponse> WikiWordsDetailAsync(WikiWordsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WikiWordsDetailHeaders headers = new WikiWordsDetailHeaders();
            return await WikiWordsDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外部传递过来的消息根据百科词库分词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsParseRequest
        /// </param>
        /// <param name="headers">
        /// WikiWordsParseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsParseResponse
        /// </returns>
        public WikiWordsParseResponse WikiWordsParseWithOptions(WikiWordsParseRequest request, WikiWordsParseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WikiWordsParse",
                Version = "wiki_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/wiki/words/parse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WikiWordsParseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外部传递过来的消息根据百科词库分词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsParseRequest
        /// </param>
        /// <param name="headers">
        /// WikiWordsParseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsParseResponse
        /// </returns>
        public async Task<WikiWordsParseResponse> WikiWordsParseWithOptionsAsync(WikiWordsParseRequest request, WikiWordsParseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WikiWordsParse",
                Version = "wiki_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/wiki/words/parse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<WikiWordsParseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外部传递过来的消息根据百科词库分词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsParseRequest
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsParseResponse
        /// </returns>
        public WikiWordsParseResponse WikiWordsParse(WikiWordsParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WikiWordsParseHeaders headers = new WikiWordsParseHeaders();
            return WikiWordsParseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>外部传递过来的消息根据百科词库分词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WikiWordsParseRequest
        /// </param>
        /// 
        /// <returns>
        /// WikiWordsParseResponse
        /// </returns>
        public async Task<WikiWordsParseResponse> WikiWordsParseAsync(WikiWordsParseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WikiWordsParseHeaders headers = new WikiWordsParseHeaders();
            return await WikiWordsParseWithOptionsAsync(request, headers, runtime);
        }

    }
}
