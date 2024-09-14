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


        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceRequest
         * @param headers AppendSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendSpaceResponse
         */
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

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceRequest
         * @param headers AppendSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendSpaceResponse
         */
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

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceRequest
         * @return AppendSpaceResponse
         */
        public AppendSpaceResponse AppendSpace(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return AppendSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceRequest
         * @return AppendSpaceResponse
         */
        public async Task<AppendSpaceResponse> AppendSpaceAsync(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return await AppendSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceWithDelegateRequest
         * @param headers AppendSpaceWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendSpaceWithDelegateResponse
         */
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

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceWithDelegateRequest
         * @param headers AppendSpaceWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendSpaceWithDelegateResponse
         */
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

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceWithDelegateRequest
         * @return AppendSpaceWithDelegateResponse
         */
        public AppendSpaceWithDelegateResponse AppendSpaceWithDelegate(AppendSpaceWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceWithDelegateHeaders headers = new AppendSpaceWithDelegateHeaders();
            return AppendSpaceWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增或更新卡片的场域信息
         *
         * @param request AppendSpaceWithDelegateRequest
         * @return AppendSpaceWithDelegateResponse
         */
        public async Task<AppendSpaceWithDelegateResponse> AppendSpaceWithDelegateAsync(AppendSpaceWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceWithDelegateHeaders headers = new AppendSpaceWithDelegateHeaders();
            return await AppendSpaceWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 复制模板
         *
         * @param request CopyTemplateRequest
         * @param headers CopyTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyTemplateResponse
         */
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

        /**
         * @summary 复制模板
         *
         * @param request CopyTemplateRequest
         * @param headers CopyTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyTemplateResponse
         */
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

        /**
         * @summary 复制模板
         *
         * @param request CopyTemplateRequest
         * @return CopyTemplateResponse
         */
        public CopyTemplateResponse CopyTemplate(CopyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyTemplateHeaders headers = new CopyTemplateHeaders();
            return CopyTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 复制模板
         *
         * @param request CopyTemplateRequest
         * @return CopyTemplateResponse
         */
        public async Task<CopyTemplateResponse> CopyTemplateAsync(CopyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyTemplateHeaders headers = new CopyTemplateHeaders();
            return await CopyTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverRequest
         * @param headers CreateAndDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndDeliverResponse
         */
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

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverRequest
         * @param headers CreateAndDeliverHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndDeliverResponse
         */
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

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverRequest
         * @return CreateAndDeliverResponse
         */
        public CreateAndDeliverResponse CreateAndDeliver(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return CreateAndDeliverWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverRequest
         * @return CreateAndDeliverResponse
         */
        public async Task<CreateAndDeliverResponse> CreateAndDeliverAsync(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return await CreateAndDeliverWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverWithDelegateRequest
         * @param headers CreateAndDeliverWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndDeliverWithDelegateResponse
         */
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

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverWithDelegateRequest
         * @param headers CreateAndDeliverWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndDeliverWithDelegateResponse
         */
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

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverWithDelegateRequest
         * @return CreateAndDeliverWithDelegateResponse
         */
        public CreateAndDeliverWithDelegateResponse CreateAndDeliverWithDelegate(CreateAndDeliverWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverWithDelegateHeaders headers = new CreateAndDeliverWithDelegateHeaders();
            return CreateAndDeliverWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建并投放卡片
         *
         * @param request CreateAndDeliverWithDelegateRequest
         * @return CreateAndDeliverWithDelegateResponse
         */
        public async Task<CreateAndDeliverWithDelegateResponse> CreateAndDeliverWithDelegateAsync(CreateAndDeliverWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverWithDelegateHeaders headers = new CreateAndDeliverWithDelegateHeaders();
            return await CreateAndDeliverWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardRequest
         * @param headers CreateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCardResponse
         */
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

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardRequest
         * @param headers CreateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCardResponse
         */
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

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardRequest
         * @return CreateCardResponse
         */
        public CreateCardResponse CreateCard(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return CreateCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardRequest
         * @return CreateCardResponse
         */
        public async Task<CreateCardResponse> CreateCardAsync(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return await CreateCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardWithDelegateRequest
         * @param headers CreateCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCardWithDelegateResponse
         */
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

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardWithDelegateRequest
         * @param headers CreateCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCardWithDelegateResponse
         */
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

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardWithDelegateRequest
         * @return CreateCardWithDelegateResponse
         */
        public CreateCardWithDelegateResponse CreateCardWithDelegate(CreateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardWithDelegateHeaders headers = new CreateCardWithDelegateHeaders();
            return CreateCardWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建卡片
         *
         * @param request CreateCardWithDelegateRequest
         * @return CreateCardWithDelegateResponse
         */
        public async Task<CreateCardWithDelegateResponse> CreateCardWithDelegateAsync(CreateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardWithDelegateHeaders headers = new CreateCardWithDelegateHeaders();
            return await CreateCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建模板
         *
         * @param request CreateTemplateRequest
         * @param headers CreateTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
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

        /**
         * @summary 创建模板
         *
         * @param request CreateTemplateRequest
         * @param headers CreateTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
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

        /**
         * @summary 创建模板
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplateHeaders headers = new CreateTemplateHeaders();
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建模板
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTemplateHeaders headers = new CreateTemplateHeaders();
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除模板
         *
         * @param request DeleteTemplateRequest
         * @param headers DeleteTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary 删除模板
         *
         * @param request DeleteTemplateRequest
         * @param headers DeleteTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary 删除模板
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTemplateHeaders headers = new DeleteTemplateHeaders();
            return DeleteTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除模板
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTemplateHeaders headers = new DeleteTemplateHeaders();
            return await DeleteTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardRequest
         * @param headers DeliverCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverCardResponse
         */
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

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardRequest
         * @param headers DeliverCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverCardResponse
         */
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

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardRequest
         * @return DeliverCardResponse
         */
        public DeliverCardResponse DeliverCard(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return DeliverCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardRequest
         * @return DeliverCardResponse
         */
        public async Task<DeliverCardResponse> DeliverCardAsync(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return await DeliverCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardWithDelegateRequest
         * @param headers DeliverCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverCardWithDelegateResponse
         */
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

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardWithDelegateRequest
         * @param headers DeliverCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeliverCardWithDelegateResponse
         */
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

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardWithDelegateRequest
         * @return DeliverCardWithDelegateResponse
         */
        public DeliverCardWithDelegateResponse DeliverCardWithDelegate(DeliverCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardWithDelegateHeaders headers = new DeliverCardWithDelegateHeaders();
            return DeliverCardWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 投放卡片
         *
         * @param request DeliverCardWithDelegateRequest
         * @return DeliverCardWithDelegateResponse
         */
        public async Task<DeliverCardWithDelegateResponse> DeliverCardWithDelegateAsync(DeliverCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardWithDelegateHeaders headers = new DeliverCardWithDelegateHeaders();
            return await DeliverCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取模板信息
         *
         * @param request GetTemplateRequest
         * @param headers GetTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
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

        /**
         * @summary 获取模板信息
         *
         * @param request GetTemplateRequest
         * @param headers GetTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
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

        /**
         * @summary 获取模板信息
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateHeaders headers = new GetTemplateHeaders();
            return GetTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取模板信息
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTemplateHeaders headers = new GetTemplateHeaders();
            return await GetTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发布模板
         *
         * @param request PublishTemplateRequest
         * @param headers PublishTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishTemplateResponse
         */
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

        /**
         * @summary 发布模板
         *
         * @param request PublishTemplateRequest
         * @param headers PublishTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishTemplateResponse
         */
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

        /**
         * @summary 发布模板
         *
         * @param request PublishTemplateRequest
         * @return PublishTemplateResponse
         */
        public PublishTemplateResponse PublishTemplate(PublishTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishTemplateHeaders headers = new PublishTemplateHeaders();
            return PublishTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发布模板
         *
         * @param request PublishTemplateRequest
         * @return PublishTemplateResponse
         */
        public async Task<PublishTemplateResponse> PublishTemplateAsync(PublishTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PublishTemplateHeaders headers = new PublishTemplateHeaders();
            return await PublishTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackRequest
         * @param headers RegisterCallbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCallbackResponse
         */
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

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackRequest
         * @param headers RegisterCallbackHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCallbackResponse
         */
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

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackRequest
         * @return RegisterCallbackResponse
         */
        public RegisterCallbackResponse RegisterCallback(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return RegisterCallbackWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackRequest
         * @return RegisterCallbackResponse
         */
        public async Task<RegisterCallbackResponse> RegisterCallbackAsync(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return await RegisterCallbackWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackWithDelegateRequest
         * @param headers RegisterCallbackWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCallbackWithDelegateResponse
         */
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

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackWithDelegateRequest
         * @param headers RegisterCallbackWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterCallbackWithDelegateResponse
         */
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

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackWithDelegateRequest
         * @return RegisterCallbackWithDelegateResponse
         */
        public RegisterCallbackWithDelegateResponse RegisterCallbackWithDelegate(RegisterCallbackWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackWithDelegateHeaders headers = new RegisterCallbackWithDelegateHeaders();
            return RegisterCallbackWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册卡片回调地址
         *
         * @param request RegisterCallbackWithDelegateRequest
         * @return RegisterCallbackWithDelegateResponse
         */
        public async Task<RegisterCallbackWithDelegateResponse> RegisterCallbackWithDelegateAsync(RegisterCallbackWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackWithDelegateHeaders headers = new RegisterCallbackWithDelegateHeaders();
            return await RegisterCallbackWithDelegateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存模板
         *
         * @param request SaveTemplateRequest
         * @param headers SaveTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTemplateResponse
         */
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

        /**
         * @summary 保存模板
         *
         * @param request SaveTemplateRequest
         * @param headers SaveTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTemplateResponse
         */
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

        /**
         * @summary 保存模板
         *
         * @param request SaveTemplateRequest
         * @return SaveTemplateResponse
         */
        public SaveTemplateResponse SaveTemplate(SaveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTemplateHeaders headers = new SaveTemplateHeaders();
            return SaveTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存模板
         *
         * @param request SaveTemplateRequest
         * @return SaveTemplateResponse
         */
        public async Task<SaveTemplateResponse> SaveTemplateAsync(SaveTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveTemplateHeaders headers = new SaveTemplateHeaders();
            return await SaveTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary AI互动卡片流式更新
         *
         * @param request StreamingUpdateRequest
         * @param headers StreamingUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StreamingUpdateResponse
         */
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

        /**
         * @summary AI互动卡片流式更新
         *
         * @param request StreamingUpdateRequest
         * @param headers StreamingUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return StreamingUpdateResponse
         */
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

        /**
         * @summary AI互动卡片流式更新
         *
         * @param request StreamingUpdateRequest
         * @return StreamingUpdateResponse
         */
        public StreamingUpdateResponse StreamingUpdate(StreamingUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
            return StreamingUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary AI互动卡片流式更新
         *
         * @param request StreamingUpdateRequest
         * @return StreamingUpdateResponse
         */
        public async Task<StreamingUpdateResponse> StreamingUpdateAsync(StreamingUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StreamingUpdateHeaders headers = new StreamingUpdateHeaders();
            return await StreamingUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @param headers UpdateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
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

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @param headers UpdateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
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

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return UpdateCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return await UpdateCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardWithDelegateRequest
         * @param headers UpdateCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardWithDelegateResponse
         */
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

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardWithDelegateRequest
         * @param headers UpdateCardWithDelegateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardWithDelegateResponse
         */
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

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardWithDelegateRequest
         * @return UpdateCardWithDelegateResponse
         */
        public UpdateCardWithDelegateResponse UpdateCardWithDelegate(UpdateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardWithDelegateHeaders headers = new UpdateCardWithDelegateHeaders();
            return UpdateCardWithDelegateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardWithDelegateRequest
         * @return UpdateCardWithDelegateResponse
         */
        public async Task<UpdateCardWithDelegateResponse> UpdateCardWithDelegateAsync(UpdateCardWithDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardWithDelegateHeaders headers = new UpdateCardWithDelegateHeaders();
            return await UpdateCardWithDelegateWithOptionsAsync(request, headers, runtime);
        }

    }
}
