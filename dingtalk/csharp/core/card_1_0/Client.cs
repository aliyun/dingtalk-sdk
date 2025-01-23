// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcard_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
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
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceRequest
        /// </param>
        /// <param name="headers">
        /// AppendSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceResponse
        /// </returns>
        public AppendSpaceResponse AppendSpaceWithOptions(AppendSpaceRequest request, AppendSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
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
                Action = "AppendSpace",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendSpaceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceRequest
        /// </param>
        /// <param name="headers">
        /// AppendSpaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceResponse
        /// </returns>
        public async Task<AppendSpaceResponse> AppendSpaceWithOptionsAsync(AppendSpaceRequest request, AppendSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
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
                Action = "AppendSpace",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceResponse
        /// </returns>
        public AppendSpaceResponse AppendSpace(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return AppendSpaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceResponse
        /// </returns>
        public async Task<AppendSpaceResponse> AppendSpaceAsync(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return await AppendSpaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// AppendSpaceWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceWithDelegateResponse
        /// </returns>
        public AppendSpaceWithDelegateResponse AppendSpaceWithDelegateWithOptions(AppendSpaceWithDelegateRequest request, AppendSpaceWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
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
                Action = "AppendSpaceWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendSpaceWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// AppendSpaceWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceWithDelegateResponse
        /// </returns>
        public async Task<AppendSpaceWithDelegateResponse> AppendSpaceWithDelegateWithOptionsAsync(AppendSpaceWithDelegateRequest request, AppendSpaceWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
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
                Action = "AppendSpaceWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/spaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendSpaceWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceWithDelegateResponse
        /// </returns>
        public AppendSpaceWithDelegateResponse AppendSpaceWithDelegate(AppendSpaceWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceWithDelegateHeaders headers = new AppendSpaceWithDelegateHeaders();
            return AppendSpaceWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增或更新卡片的场域信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendSpaceWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendSpaceWithDelegateResponse
        /// </returns>
        public async Task<AppendSpaceWithDelegateResponse> AppendSpaceWithDelegateAsync(AppendSpaceWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceWithDelegateHeaders headers = new AppendSpaceWithDelegateHeaders();
            return await AppendSpaceWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭吊顶卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopCardRequest
        /// </param>
        /// <param name="headers">
        /// CloseTopCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseTopCardResponse
        /// </returns>
        public CloseTopCardResponse CloseTopCardWithOptions(CloseTopCardRequest request, CloseTopCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                query["outTrackId"] = request.OutTrackId;
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
                Action = "CloseTopCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/tops/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭吊顶卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopCardRequest
        /// </param>
        /// <param name="headers">
        /// CloseTopCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseTopCardResponse
        /// </returns>
        public async Task<CloseTopCardResponse> CloseTopCardWithOptionsAsync(CloseTopCardRequest request, CloseTopCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                query["outTrackId"] = request.OutTrackId;
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
                Action = "CloseTopCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/tops/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseTopCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭吊顶卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopCardRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseTopCardResponse
        /// </returns>
        public CloseTopCardResponse CloseTopCard(CloseTopCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopCardHeaders headers = new CloseTopCardHeaders();
            return CloseTopCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关闭吊顶卡片接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloseTopCardRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseTopCardResponse
        /// </returns>
        public async Task<CloseTopCardResponse> CloseTopCardAsync(CloseTopCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseTopCardHeaders headers = new CloseTopCardHeaders();
            return await CloseTopCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CopyTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyTemplateResponse
        /// </returns>
        public CopyTemplateResponse CopyTemplateWithOptions(CopyTemplateRequest request, CopyTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "CopyTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CopyTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyTemplateResponse
        /// </returns>
        public async Task<CopyTemplateResponse> CopyTemplateWithOptionsAsync(CopyTemplateRequest request, CopyTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "CopyTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyTemplateResponse
        /// </returns>
        public CopyTemplateResponse CopyTemplate(CopyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyTemplateHeaders headers = new CopyTemplateHeaders();
            return CopyTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyTemplateResponse
        /// </returns>
        public async Task<CopyTemplateResponse> CopyTemplateAsync(CopyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyTemplateHeaders headers = new CopyTemplateHeaders();
            return await CopyTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CreateAndDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverResponse
        /// </returns>
        public CreateAndDeliverResponse CreateAndDeliverWithOptions(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateAndDeliver",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/createAndDeliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndDeliverResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverRequest
        /// </param>
        /// <param name="headers">
        /// CreateAndDeliverHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverResponse
        /// </returns>
        public async Task<CreateAndDeliverResponse> CreateAndDeliverWithOptionsAsync(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateAndDeliver",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/createAndDeliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndDeliverResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverResponse
        /// </returns>
        public CreateAndDeliverResponse CreateAndDeliver(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return CreateAndDeliverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverResponse
        /// </returns>
        public async Task<CreateAndDeliverResponse> CreateAndDeliverAsync(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return await CreateAndDeliverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// CreateAndDeliverWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverWithDelegateResponse
        /// </returns>
        public CreateAndDeliverWithDelegateResponse CreateAndDeliverWithDelegateWithOptions(CreateAndDeliverWithDelegateRequest request, CreateAndDeliverWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateAndDeliverWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/createAndDeliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndDeliverWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// CreateAndDeliverWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverWithDelegateResponse
        /// </returns>
        public async Task<CreateAndDeliverWithDelegateResponse> CreateAndDeliverWithDelegateWithOptionsAsync(CreateAndDeliverWithDelegateRequest request, CreateAndDeliverWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateAndDeliverWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/createAndDeliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndDeliverWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverWithDelegateResponse
        /// </returns>
        public CreateAndDeliverWithDelegateResponse CreateAndDeliverWithDelegate(CreateAndDeliverWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverWithDelegateHeaders headers = new CreateAndDeliverWithDelegateHeaders();
            return CreateAndDeliverWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建并投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAndDeliverWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndDeliverWithDelegateResponse
        /// </returns>
        public async Task<CreateAndDeliverWithDelegateResponse> CreateAndDeliverWithDelegateAsync(CreateAndDeliverWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverWithDelegateHeaders headers = new CreateAndDeliverWithDelegateHeaders();
            return await CreateAndDeliverWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardRequest
        /// </param>
        /// <param name="headers">
        /// CreateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardResponse
        /// </returns>
        public CreateCardResponse CreateCardWithOptions(CreateCardRequest request, CreateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardRequest
        /// </param>
        /// <param name="headers">
        /// CreateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardResponse
        /// </returns>
        public async Task<CreateCardResponse> CreateCardWithOptionsAsync(CreateCardRequest request, CreateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardResponse
        /// </returns>
        public CreateCardResponse CreateCard(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return CreateCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardResponse
        /// </returns>
        public async Task<CreateCardResponse> CreateCardAsync(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return await CreateCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// CreateCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardWithDelegateResponse
        /// </returns>
        public CreateCardWithDelegateResponse CreateCardWithDelegateWithOptions(CreateCardWithDelegateRequest request, CreateCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// CreateCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCardWithDelegateResponse
        /// </returns>
        public async Task<CreateCardWithDelegateResponse> CreateCardWithDelegateWithOptionsAsync(CreateCardWithDelegateRequest request, CreateCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                body["callbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenSpaceModel))
            {
                body["coFeedOpenSpaceModel"] = request.CoFeedOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenSpaceModel))
            {
                body["imGroupOpenSpaceModel"] = request.ImGroupOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenSpaceModel))
            {
                body["imRobotOpenSpaceModel"] = request.ImRobotOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenSpaceModel))
            {
                body["imSingleOpenSpaceModel"] = request.ImSingleOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDynamicDataConfig))
            {
                body["openDynamicDataConfig"] = request.OpenDynamicDataConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenSpaceModel))
            {
                body["topOpenSpaceModel"] = request.TopOpenSpaceModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "CreateCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCardWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardWithDelegateResponse
        /// </returns>
        public CreateCardWithDelegateResponse CreateCardWithDelegate(CreateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardWithDelegateHeaders headers = new CreateCardWithDelegateHeaders();
            return CreateCardWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCardWithDelegateResponse
        /// </returns>
        public async Task<CreateCardWithDelegateResponse> CreateCardWithDelegateAsync(CreateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardWithDelegateHeaders headers = new CreateCardWithDelegateHeaders();
            return await CreateCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CreateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, CreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendType))
            {
                body["extendType"] = request.ExtendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CreateTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="headers">
        /// CreateTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, CreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendType))
            {
                body["extendType"] = request.ExtendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "CreateTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplateHeaders headers = new CreateTemplateHeaders();
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplateHeaders headers = new CreateTemplateHeaders();
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, DeleteTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "DeleteTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, DeleteTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "DeleteTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTemplateHeaders headers = new DeleteTemplateHeaders();
            return DeleteTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTemplateHeaders headers = new DeleteTemplateHeaders();
            return await DeleteTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardRequest
        /// </param>
        /// <param name="headers">
        /// DeliverCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardResponse
        /// </returns>
        public DeliverCardResponse DeliverCardWithOptions(DeliverCardRequest request, DeliverCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "DeliverCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardRequest
        /// </param>
        /// <param name="headers">
        /// DeliverCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardResponse
        /// </returns>
        public async Task<DeliverCardResponse> DeliverCardWithOptionsAsync(DeliverCardRequest request, DeliverCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "DeliverCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardResponse
        /// </returns>
        public DeliverCardResponse DeliverCard(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return DeliverCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardResponse
        /// </returns>
        public async Task<DeliverCardResponse> DeliverCardAsync(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return await DeliverCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// DeliverCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardWithDelegateResponse
        /// </returns>
        public DeliverCardWithDelegateResponse DeliverCardWithDelegateWithOptions(DeliverCardWithDelegateRequest request, DeliverCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "DeliverCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverCardWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// DeliverCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardWithDelegateResponse
        /// </returns>
        public async Task<DeliverCardWithDelegateResponse> DeliverCardWithDelegateWithOptionsAsync(DeliverCardWithDelegateRequest request, DeliverCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoFeedOpenDeliverModel))
            {
                body["coFeedOpenDeliverModel"] = request.CoFeedOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocOpenDeliverModel))
            {
                body["docOpenDeliverModel"] = request.DocOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImGroupOpenDeliverModel))
            {
                body["imGroupOpenDeliverModel"] = request.ImGroupOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImRobotOpenDeliverModel))
            {
                body["imRobotOpenDeliverModel"] = request.ImRobotOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImSingleOpenDeliverModel))
            {
                body["imSingleOpenDeliverModel"] = request.ImSingleOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenSpaceId))
            {
                body["openSpaceId"] = request.OpenSpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopOpenDeliverModel))
            {
                body["topOpenDeliverModel"] = request.TopOpenDeliverModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "DeliverCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances/deliver",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliverCardWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardWithDelegateResponse
        /// </returns>
        public DeliverCardWithDelegateResponse DeliverCardWithDelegate(DeliverCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardWithDelegateHeaders headers = new DeliverCardWithDelegateHeaders();
            return DeliverCardWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>投放卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliverCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliverCardWithDelegateResponse
        /// </returns>
        public async Task<DeliverCardWithDelegateResponse> DeliverCardWithDelegateAsync(DeliverCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardWithDelegateHeaders headers = new DeliverCardWithDelegateHeaders();
            return await DeliverCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// GetTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, GetTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "GetTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// GetTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, GetTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
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
                Action = "GetTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateHeaders headers = new GetTemplateHeaders();
            return GetTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateHeaders headers = new GetTemplateHeaders();
            return await GetTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplateWithOptions(ListTemplateRequest request, ListTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
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
                Action = "ListTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// <param name="headers">
        /// ListTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateWithOptionsAsync(ListTemplateRequest request, ListTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                body["templateIds"] = request.TemplateIds;
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
                Action = "ListTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/lists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public ListTemplateResponse ListTemplate(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return ListTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateResponse
        /// </returns>
        public async Task<ListTemplateResponse> ListTemplateAsync(ListTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTemplateHeaders headers = new ListTemplateHeaders();
            return await ListTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishTemplateRequest
        /// </param>
        /// <param name="headers">
        /// PublishTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishTemplateResponse
        /// </returns>
        public PublishTemplateResponse PublishTemplateWithOptions(PublishTemplateRequest request, PublishTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSource))
            {
                body["templateSource"] = request.TemplateSource;
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
                Action = "PublishTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishTemplateRequest
        /// </param>
        /// <param name="headers">
        /// PublishTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishTemplateResponse
        /// </returns>
        public async Task<PublishTemplateResponse> PublishTemplateWithOptionsAsync(PublishTemplateRequest request, PublishTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSource))
            {
                body["templateSource"] = request.TemplateSource;
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
                Action = "PublishTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishTemplateResponse
        /// </returns>
        public PublishTemplateResponse PublishTemplate(PublishTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishTemplateHeaders headers = new PublishTemplateHeaders();
            return PublishTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishTemplateResponse
        /// </returns>
        public async Task<PublishTemplateResponse> PublishTemplateAsync(PublishTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishTemplateHeaders headers = new PublishTemplateHeaders();
            return await PublishTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackResponse
        /// </returns>
        public RegisterCallbackResponse RegisterCallbackWithOptions(RegisterCallbackRequest request, RegisterCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                body["forceUpdate"] = request.ForceUpdate;
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
                Action = "RegisterCallback",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/callbacks/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCallbackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackResponse
        /// </returns>
        public async Task<RegisterCallbackResponse> RegisterCallbackWithOptionsAsync(RegisterCallbackRequest request, RegisterCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                body["forceUpdate"] = request.ForceUpdate;
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
                Action = "RegisterCallback",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/callbacks/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCallbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackResponse
        /// </returns>
        public RegisterCallbackResponse RegisterCallback(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return RegisterCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackResponse
        /// </returns>
        public async Task<RegisterCallbackResponse> RegisterCallbackAsync(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return await RegisterCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCallbackWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackWithDelegateResponse
        /// </returns>
        public RegisterCallbackWithDelegateResponse RegisterCallbackWithDelegateWithOptions(RegisterCallbackWithDelegateRequest request, RegisterCallbackWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                body["forceUpdate"] = request.ForceUpdate;
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
                Action = "RegisterCallbackWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/callbacks/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCallbackWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCallbackWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackWithDelegateResponse
        /// </returns>
        public async Task<RegisterCallbackWithDelegateResponse> RegisterCallbackWithDelegateWithOptionsAsync(RegisterCallbackWithDelegateRequest request, RegisterCallbackWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                body["forceUpdate"] = request.ForceUpdate;
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
                Action = "RegisterCallbackWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/callbacks/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCallbackWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackWithDelegateResponse
        /// </returns>
        public RegisterCallbackWithDelegateResponse RegisterCallbackWithDelegate(RegisterCallbackWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackWithDelegateHeaders headers = new RegisterCallbackWithDelegateHeaders();
            return RegisterCallbackWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册卡片回调地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCallbackWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCallbackWithDelegateResponse
        /// </returns>
        public async Task<RegisterCallbackWithDelegateResponse> RegisterCallbackWithDelegateAsync(RegisterCallbackWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackWithDelegateHeaders headers = new RegisterCallbackWithDelegateHeaders();
            return await RegisterCallbackWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTemplateRequest
        /// </param>
        /// <param name="headers">
        /// SaveTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTemplateResponse
        /// </returns>
        public SaveTemplateResponse SaveTemplateWithOptions(SaveTemplateRequest request, SaveTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSource))
            {
                body["templateSource"] = request.TemplateSource;
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
                Action = "SaveTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTemplateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTemplateRequest
        /// </param>
        /// <param name="headers">
        /// SaveTemplateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTemplateResponse
        /// </returns>
        public async Task<SaveTemplateResponse> SaveTemplateWithOptionsAsync(SaveTemplateRequest request, SaveTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateSource))
            {
                body["templateSource"] = request.TemplateSource;
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
                Action = "SaveTemplate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/templates/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTemplateResponse
        /// </returns>
        public SaveTemplateResponse SaveTemplate(SaveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTemplateHeaders headers = new SaveTemplateHeaders();
            return SaveTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTemplateResponse
        /// </returns>
        public async Task<SaveTemplateResponse> SaveTemplateAsync(SaveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTemplateHeaders headers = new SaveTemplateHeaders();
            return await SaveTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI互动卡片流式更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamingUpdateRequest
        /// </param>
        /// <param name="headers">
        /// StreamingUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamingUpdateResponse
        /// </returns>
        public StreamingUpdateResponse StreamingUpdateWithOptions(StreamingUpdateRequest request, StreamingUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Guid))
            {
                body["guid"] = request.Guid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsError))
            {
                body["isError"] = request.IsError;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFinalize))
            {
                body["isFinalize"] = request.IsFinalize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFull))
            {
                body["isFull"] = request.IsFull;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
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
                Action = "StreamingUpdate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/streaming",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamingUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI互动卡片流式更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamingUpdateRequest
        /// </param>
        /// <param name="headers">
        /// StreamingUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StreamingUpdateResponse
        /// </returns>
        public async Task<StreamingUpdateResponse> StreamingUpdateWithOptionsAsync(StreamingUpdateRequest request, StreamingUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Guid))
            {
                body["guid"] = request.Guid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsError))
            {
                body["isError"] = request.IsError;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFinalize))
            {
                body["isFinalize"] = request.IsFinalize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFull))
            {
                body["isFull"] = request.IsFull;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
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
                Action = "StreamingUpdate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/streaming",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StreamingUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI互动卡片流式更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamingUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamingUpdateResponse
        /// </returns>
        public StreamingUpdateResponse StreamingUpdate(StreamingUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
            return StreamingUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AI互动卡片流式更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StreamingUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// StreamingUpdateResponse
        /// </returns>
        public async Task<StreamingUpdateResponse> StreamingUpdateAsync(StreamingUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
            return await StreamingUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public UpdateCardResponse UpdateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardUpdateOptions))
            {
                body["cardUpdateOptions"] = request.CardUpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "UpdateCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public async Task<UpdateCardResponse> UpdateCardWithOptionsAsync(UpdateCardRequest request, UpdateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardUpdateOptions))
            {
                body["cardUpdateOptions"] = request.CardUpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "UpdateCard",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return UpdateCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return await UpdateCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardWithDelegateResponse
        /// </returns>
        public UpdateCardWithDelegateResponse UpdateCardWithDelegateWithOptions(UpdateCardWithDelegateRequest request, UpdateCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardUpdateOptions))
            {
                body["cardUpdateOptions"] = request.CardUpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "UpdateCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardWithDelegateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardWithDelegateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardWithDelegateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardWithDelegateResponse
        /// </returns>
        public async Task<UpdateCardWithDelegateResponse> UpdateCardWithDelegateWithOptionsAsync(UpdateCardWithDelegateRequest request, UpdateCardWithDelegateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardUpdateOptions))
            {
                body["cardUpdateOptions"] = request.CardUpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
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
                Action = "UpdateCardWithDelegate",
                Version = "card_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/card/me/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardWithDelegateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardWithDelegateResponse
        /// </returns>
        public UpdateCardWithDelegateResponse UpdateCardWithDelegate(UpdateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardWithDelegateHeaders headers = new UpdateCardWithDelegateHeaders();
            return UpdateCardWithDelegateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardWithDelegateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardWithDelegateResponse
        /// </returns>
        public async Task<UpdateCardWithDelegateResponse> UpdateCardWithDelegateAsync(UpdateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardWithDelegateHeaders headers = new UpdateCardWithDelegateHeaders();
            return await UpdateCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

    }
}
