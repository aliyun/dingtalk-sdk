// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0
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


        public AddRobotInstanceToGroupResponse AddRobotInstanceToGroup(AddRobotInstanceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddRobotInstanceToGroupWithOptions(request, headers, runtime);
        }

        public async Task<AddRobotInstanceToGroupResponse> AddRobotInstanceToGroupAsync(AddRobotInstanceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddRobotInstanceToGroupWithOptionsAsync(request, headers, runtime);
        }

        public AddRobotInstanceToGroupResponse AddRobotInstanceToGroupWithOptions(AddRobotInstanceToGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddRobotInstanceToGroupResponse>(DoROARequest("AddRobotInstanceToGroup", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groups", "json", req, runtime));
        }

        public async Task<AddRobotInstanceToGroupResponse> AddRobotInstanceToGroupWithOptionsAsync(AddRobotInstanceToGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddRobotInstanceToGroupResponse>(await DoROARequestAsync("AddRobotInstanceToGroup", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groups", "json", req, runtime));
        }

        public AskRobotResponse AskRobot(AskRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AskRobotHeaders headers = new AskRobotHeaders();
            return AskRobotWithOptions(request, headers, runtime);
        }

        public async Task<AskRobotResponse> AskRobotAsync(AskRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AskRobotHeaders headers = new AskRobotHeaders();
            return await AskRobotWithOptionsAsync(request, headers, runtime);
        }

        public AskRobotResponse AskRobotWithOptions(AskRobotRequest request, AskRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotAppKey))
            {
                body["robotAppKey"] = request.RobotAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionUuid))
            {
                body["sessionUuid"] = request.SessionUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AskRobotResponse>(DoROARequest("AskRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/ask", "json", req, runtime));
        }

        public async Task<AskRobotResponse> AskRobotWithOptionsAsync(AskRobotRequest request, AskRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotAppKey))
            {
                body["robotAppKey"] = request.RobotAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionUuid))
            {
                body["sessionUuid"] = request.SessionUuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AskRobotResponse>(await DoROARequestAsync("AskRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/ask", "json", req, runtime));
        }

        public GetDingMeBaseDataResponse GetDingMeBaseData(GetDingMeBaseDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
            return GetDingMeBaseDataWithOptions(request, headers, runtime);
        }

        public async Task<GetDingMeBaseDataResponse> GetDingMeBaseDataAsync(GetDingMeBaseDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
            return await GetDingMeBaseDataWithOptionsAsync(request, headers, runtime);
        }

        public GetDingMeBaseDataResponse GetDingMeBaseDataWithOptions(GetDingMeBaseDataRequest request, GetDingMeBaseDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByDay))
            {
                query["byDay"] = request.ByDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDay))
            {
                query["endDay"] = request.EndDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDay))
            {
                query["startDay"] = request.StartDay;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetDingMeBaseDataResponse>(DoROARequest("GetDingMeBaseData", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/robots/data", "json", req, runtime));
        }

        public async Task<GetDingMeBaseDataResponse> GetDingMeBaseDataWithOptionsAsync(GetDingMeBaseDataRequest request, GetDingMeBaseDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                query["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByDay))
            {
                query["byDay"] = request.ByDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDay))
            {
                query["endDay"] = request.EndDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDay))
            {
                query["startDay"] = request.StartDay;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetDingMeBaseDataResponse>(await DoROARequestAsync("GetDingMeBaseData", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/robots/data", "json", req, runtime));
        }

        public GetIntelligentRobotInfoResponse GetIntelligentRobotInfo(GetIntelligentRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntelligentRobotInfoHeaders headers = new GetIntelligentRobotInfoHeaders();
            return GetIntelligentRobotInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetIntelligentRobotInfoResponse> GetIntelligentRobotInfoAsync(GetIntelligentRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntelligentRobotInfoHeaders headers = new GetIntelligentRobotInfoHeaders();
            return await GetIntelligentRobotInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetIntelligentRobotInfoResponse GetIntelligentRobotInfoWithOptions(GetIntelligentRobotInfoRequest request, GetIntelligentRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotAppKey))
            {
                query["robotAppKey"] = request.RobotAppKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetIntelligentRobotInfoResponse>(DoROARequest("GetIntelligentRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/intelligentRobots/infos", "json", req, runtime));
        }

        public async Task<GetIntelligentRobotInfoResponse> GetIntelligentRobotInfoWithOptionsAsync(GetIntelligentRobotInfoRequest request, GetIntelligentRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotAppKey))
            {
                query["robotAppKey"] = request.RobotAppKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetIntelligentRobotInfoResponse>(await DoROARequestAsync("GetIntelligentRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/intelligentRobots/infos", "json", req, runtime));
        }

        public GetOfficialAccountRobotInfoResponse GetOfficialAccountRobotInfo(GetOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountRobotInfoHeaders headers = new GetOfficialAccountRobotInfoHeaders();
            return GetOfficialAccountRobotInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetOfficialAccountRobotInfoResponse> GetOfficialAccountRobotInfoAsync(GetOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountRobotInfoHeaders headers = new GetOfficialAccountRobotInfoHeaders();
            return await GetOfficialAccountRobotInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetOfficialAccountRobotInfoResponse GetOfficialAccountRobotInfoWithOptions(GetOfficialAccountRobotInfoRequest request, GetOfficialAccountRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountRobotInfoResponse>(DoROARequest("GetOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime));
        }

        public async Task<GetOfficialAccountRobotInfoResponse> GetOfficialAccountRobotInfoWithOptionsAsync(GetOfficialAccountRobotInfoRequest request, GetOfficialAccountRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetOfficialAccountRobotInfoResponse>(await DoROARequestAsync("GetOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime));
        }

        public GetWebChannelUserTokenResponse GetWebChannelUserToken(GetWebChannelUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebChannelUserTokenHeaders headers = new GetWebChannelUserTokenHeaders();
            return GetWebChannelUserTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetWebChannelUserTokenResponse> GetWebChannelUserTokenAsync(GetWebChannelUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebChannelUserTokenHeaders headers = new GetWebChannelUserTokenHeaders();
            return await GetWebChannelUserTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetWebChannelUserTokenResponse GetWebChannelUserTokenWithOptions(GetWebChannelUserTokenRequest request, GetWebChannelUserTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                body["nick"] = request.Nick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetWebChannelUserTokenResponse>(DoROARequest("GetWebChannelUserToken", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/webChannels/userTokens", "json", req, runtime));
        }

        public async Task<GetWebChannelUserTokenResponse> GetWebChannelUserTokenWithOptionsAsync(GetWebChannelUserTokenRequest request, GetWebChannelUserTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignId))
            {
                body["foreignId"] = request.ForeignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                body["nick"] = request.Nick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetWebChannelUserTokenResponse>(await DoROARequestAsync("GetWebChannelUserToken", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/webChannels/userTokens", "json", req, runtime));
        }

        public PushCustomerGroupMessageResponse PushCustomerGroupMessage(PushCustomerGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushCustomerGroupMessageHeaders headers = new PushCustomerGroupMessageHeaders();
            return PushCustomerGroupMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushCustomerGroupMessageResponse> PushCustomerGroupMessageAsync(PushCustomerGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushCustomerGroupMessageHeaders headers = new PushCustomerGroupMessageHeaders();
            return await PushCustomerGroupMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushCustomerGroupMessageResponse PushCustomerGroupMessageWithOptions(PushCustomerGroupMessageRequest request, PushCustomerGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushCustomerGroupMessageResponse>(DoROARequest("PushCustomerGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/groupMessages/send", "json", req, runtime));
        }

        public async Task<PushCustomerGroupMessageResponse> PushCustomerGroupMessageWithOptionsAsync(PushCustomerGroupMessageRequest request, PushCustomerGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushCustomerGroupMessageResponse>(await DoROARequestAsync("PushCustomerGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/groupMessages/send", "json", req, runtime));
        }

        public PushIntelligentRobotGroupMessageResponse PushIntelligentRobotGroupMessage(PushIntelligentRobotGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotGroupMessageHeaders headers = new PushIntelligentRobotGroupMessageHeaders();
            return PushIntelligentRobotGroupMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushIntelligentRobotGroupMessageResponse> PushIntelligentRobotGroupMessageAsync(PushIntelligentRobotGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotGroupMessageHeaders headers = new PushIntelligentRobotGroupMessageHeaders();
            return await PushIntelligentRobotGroupMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushIntelligentRobotGroupMessageResponse PushIntelligentRobotGroupMessageWithOptions(PushIntelligentRobotGroupMessageRequest request, PushIntelligentRobotGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushIntelligentRobotGroupMessageResponse>(DoROARequest("PushIntelligentRobotGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groupMessages/send", "json", req, runtime));
        }

        public async Task<PushIntelligentRobotGroupMessageResponse> PushIntelligentRobotGroupMessageWithOptionsAsync(PushIntelligentRobotGroupMessageRequest request, PushIntelligentRobotGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushIntelligentRobotGroupMessageResponse>(await DoROARequestAsync("PushIntelligentRobotGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groupMessages/send", "json", req, runtime));
        }

        public PushIntelligentRobotMessageResponse PushIntelligentRobotMessage(PushIntelligentRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotMessageHeaders headers = new PushIntelligentRobotMessageHeaders();
            return PushIntelligentRobotMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushIntelligentRobotMessageResponse> PushIntelligentRobotMessageAsync(PushIntelligentRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotMessageHeaders headers = new PushIntelligentRobotMessageHeaders();
            return await PushIntelligentRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushIntelligentRobotMessageResponse PushIntelligentRobotMessageWithOptions(PushIntelligentRobotMessageRequest request, PushIntelligentRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushIntelligentRobotMessageResponse>(DoROARequest("PushIntelligentRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/oToMessages/send", "json", req, runtime));
        }

        public async Task<PushIntelligentRobotMessageResponse> PushIntelligentRobotMessageWithOptionsAsync(PushIntelligentRobotMessageRequest request, PushIntelligentRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushIntelligentRobotMessageResponse>(await DoROARequestAsync("PushIntelligentRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/oToMessages/send", "json", req, runtime));
        }

        public PushOfficialAccountMessageResponse PushOfficialAccountMessage(PushOfficialAccountMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushOfficialAccountMessageHeaders headers = new PushOfficialAccountMessageHeaders();
            return PushOfficialAccountMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushOfficialAccountMessageResponse> PushOfficialAccountMessageAsync(PushOfficialAccountMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushOfficialAccountMessageHeaders headers = new PushOfficialAccountMessageHeaders();
            return await PushOfficialAccountMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushOfficialAccountMessageResponse PushOfficialAccountMessageWithOptions(PushOfficialAccountMessageRequest request, PushOfficialAccountMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushOfficialAccountMessageResponse>(DoROARequest("PushOfficialAccountMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/oToMessages/send", "json", req, runtime));
        }

        public async Task<PushOfficialAccountMessageResponse> PushOfficialAccountMessageWithOptionsAsync(PushOfficialAccountMessageRequest request, PushOfficialAccountMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushOfficialAccountMessageResponse>(await DoROARequestAsync("PushOfficialAccountMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/oToMessages/send", "json", req, runtime));
        }

        public PushRobotMessageResponse PushRobotMessage(PushRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushRobotMessageHeaders headers = new PushRobotMessageHeaders();
            return PushRobotMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushRobotMessageResponse> PushRobotMessageAsync(PushRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushRobotMessageHeaders headers = new PushRobotMessageHeaders();
            return await PushRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        public PushRobotMessageResponse PushRobotMessageWithOptions(PushRobotMessageRequest request, PushRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushRobotMessageResponse>(DoROARequest("PushRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/oToMessages/send", "json", req, runtime));
        }

        public async Task<PushRobotMessageResponse> PushRobotMessageWithOptionsAsync(PushRobotMessageRequest request, PushRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                body["msgKey"] = request.MsgKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParam))
            {
                body["msgParam"] = request.MsgParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PushRobotMessageResponse>(await DoROARequestAsync("PushRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/oToMessages/send", "json", req, runtime));
        }

        public ReplyRobotResponse ReplyRobot(ReplyRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReplyRobotHeaders headers = new ReplyRobotHeaders();
            return ReplyRobotWithOptions(request, headers, runtime);
        }

        public async Task<ReplyRobotResponse> ReplyRobotAsync(ReplyRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReplyRobotHeaders headers = new ReplyRobotHeaders();
            return await ReplyRobotWithOptionsAsync(request, headers, runtime);
        }

        public ReplyRobotResponse ReplyRobotWithOptions(ReplyRobotRequest request, ReplyRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMessageStr))
            {
                body["proxyMessageStr"] = request.ProxyMessageStr;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ReplyRobotResponse>(DoROARequest("ReplyRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/reply", "json", req, runtime));
        }

        public async Task<ReplyRobotResponse> ReplyRobotWithOptionsAsync(ReplyRobotRequest request, ReplyRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMessageStr))
            {
                body["proxyMessageStr"] = request.ProxyMessageStr;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ReplyRobotResponse>(await DoROARequestAsync("ReplyRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/reply", "json", req, runtime));
        }

        public UpdateOfficialAccountRobotInfoResponse UpdateOfficialAccountRobotInfo(UpdateOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOfficialAccountRobotInfoHeaders headers = new UpdateOfficialAccountRobotInfoHeaders();
            return UpdateOfficialAccountRobotInfoWithOptions(request, headers, runtime);
        }

        public async Task<UpdateOfficialAccountRobotInfoResponse> UpdateOfficialAccountRobotInfoAsync(UpdateOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOfficialAccountRobotInfoHeaders headers = new UpdateOfficialAccountRobotInfoHeaders();
            return await UpdateOfficialAccountRobotInfoWithOptionsAsync(request, headers, runtime);
        }

        public UpdateOfficialAccountRobotInfoResponse UpdateOfficialAccountRobotInfoWithOptions(UpdateOfficialAccountRobotInfoRequest request, UpdateOfficialAccountRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaUrl))
            {
                body["previewMediaUrl"] = request.PreviewMediaUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateOfficialAccountRobotInfoResponse>(DoROARequest("UpdateOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "PUT", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime));
        }

        public async Task<UpdateOfficialAccountRobotInfoResponse> UpdateOfficialAccountRobotInfoWithOptionsAsync(UpdateOfficialAccountRobotInfoRequest request, UpdateOfficialAccountRobotInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaUrl))
            {
                body["previewMediaUrl"] = request.PreviewMediaUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateOfficialAccountRobotInfoResponse>(await DoROARequestAsync("UpdateOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "PUT", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime));
        }

    }
}
