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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AppendSpaceResponse AppendSpace(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return AppendSpaceWithOptions(request, headers, runtime);
        }

        public async Task<AppendSpaceResponse> AppendSpaceAsync(AppendSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendSpaceHeaders headers = new AppendSpaceHeaders();
            return await AppendSpaceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<AppendSpaceResponse>(DoROARequest("AppendSpace", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances/spaces", "json", req, runtime));
        }

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
            return TeaModel.ToObject<AppendSpaceResponse>(await DoROARequestAsync("AppendSpace", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances/spaces", "json", req, runtime));
        }

        public CreateAndDeliverResponse CreateAndDeliver(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return CreateAndDeliverWithOptions(request, headers, runtime);
        }

        public async Task<CreateAndDeliverResponse> CreateAndDeliverAsync(CreateAndDeliverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAndDeliverHeaders headers = new CreateAndDeliverHeaders();
            return await CreateAndDeliverWithOptionsAsync(request, headers, runtime);
        }

        public CreateAndDeliverResponse CreateAndDeliverWithOptions(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
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
            return TeaModel.ToObject<CreateAndDeliverResponse>(DoROARequest("CreateAndDeliver", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/createAndDeliver", "json", req, runtime));
        }

        public async Task<CreateAndDeliverResponse> CreateAndDeliverWithOptionsAsync(CreateAndDeliverRequest request, CreateAndDeliverHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
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
            return TeaModel.ToObject<CreateAndDeliverResponse>(await DoROARequestAsync("CreateAndDeliver", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/createAndDeliver", "json", req, runtime));
        }

        public CreateCardResponse CreateCard(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return CreateCardWithOptions(request, headers, runtime);
        }

        public async Task<CreateCardResponse> CreateCardAsync(CreateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCardHeaders headers = new CreateCardHeaders();
            return await CreateCardWithOptionsAsync(request, headers, runtime);
        }

        public CreateCardResponse CreateCardWithOptions(CreateCardRequest request, CreateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
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
            return TeaModel.ToObject<CreateCardResponse>(DoROARequest("CreateCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances", "json", req, runtime));
        }

        public async Task<CreateCardResponse> CreateCardWithOptionsAsync(CreateCardRequest request, CreateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
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
            return TeaModel.ToObject<CreateCardResponse>(await DoROARequestAsync("CreateCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances", "json", req, runtime));
        }

        public DeliverCardResponse DeliverCard(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return DeliverCardWithOptions(request, headers, runtime);
        }

        public async Task<DeliverCardResponse> DeliverCardAsync(DeliverCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliverCardHeaders headers = new DeliverCardHeaders();
            return await DeliverCardWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DeliverCardResponse>(DoROARequest("DeliverCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/deliver", "json", req, runtime));
        }

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
            return TeaModel.ToObject<DeliverCardResponse>(await DoROARequestAsync("DeliverCard", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/instances/deliver", "json", req, runtime));
        }

        public RegisterCallbackResponse RegisterCallback(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return RegisterCallbackWithOptions(request, headers, runtime);
        }

        public async Task<RegisterCallbackResponse> RegisterCallbackAsync(RegisterCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCallbackHeaders headers = new RegisterCallbackHeaders();
            return await RegisterCallbackWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<RegisterCallbackResponse>(DoROARequest("RegisterCallback", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/callbacks/register", "json", req, runtime));
        }

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
            return TeaModel.ToObject<RegisterCallbackResponse>(await DoROARequestAsync("RegisterCallback", "card_1.0", "HTTP", "POST", "AK", "/v1.0/card/callbacks/register", "json", req, runtime));
        }

        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return UpdateCardWithOptions(request, headers, runtime);
        }

        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return await UpdateCardWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateCardResponse>(DoROARequest("UpdateCard", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateCardResponse>(await DoROARequestAsync("UpdateCard", "card_1.0", "HTTP", "PUT", "AK", "/v1.0/card/instances", "json", req, runtime));
        }

    }
}
