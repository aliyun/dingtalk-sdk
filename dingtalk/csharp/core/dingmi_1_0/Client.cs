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
        /// <para>添加智能客服机器人到钉钉群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotInstanceToGroupRequest
        /// </param>
        /// <param name="headers">
        /// AddRobotInstanceToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRobotInstanceToGroupResponse
        /// </returns>
        public AddRobotInstanceToGroupResponse AddRobotInstanceToGroupWithOptions(AddRobotInstanceToGroupRequest request, AddRobotInstanceToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRobotInstanceToGroup",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRobotInstanceToGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能客服机器人到钉钉群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotInstanceToGroupRequest
        /// </param>
        /// <param name="headers">
        /// AddRobotInstanceToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRobotInstanceToGroupResponse
        /// </returns>
        public async Task<AddRobotInstanceToGroupResponse> AddRobotInstanceToGroupWithOptionsAsync(AddRobotInstanceToGroupRequest request, AddRobotInstanceToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRobotInstanceToGroup",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRobotInstanceToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能客服机器人到钉钉群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotInstanceToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRobotInstanceToGroupResponse
        /// </returns>
        public AddRobotInstanceToGroupResponse AddRobotInstanceToGroup(AddRobotInstanceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotInstanceToGroupHeaders headers = new AddRobotInstanceToGroupHeaders();
            return AddRobotInstanceToGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能客服机器人到钉钉群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotInstanceToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRobotInstanceToGroupResponse
        /// </returns>
        public async Task<AddRobotInstanceToGroupResponse> AddRobotInstanceToGroupAsync(AddRobotInstanceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotInstanceToGroupHeaders headers = new AddRobotInstanceToGroupHeaders();
            return await AddRobotInstanceToGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用小蜜机器人的问答能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskRobotRequest
        /// </param>
        /// <param name="headers">
        /// AskRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskRobotResponse
        /// </returns>
        public AskRobotResponse AskRobotWithOptions(AskRobotRequest request, AskRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskRobot",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/ask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskRobotResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用小蜜机器人的问答能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskRobotRequest
        /// </param>
        /// <param name="headers">
        /// AskRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskRobotResponse
        /// </returns>
        public async Task<AskRobotResponse> AskRobotWithOptionsAsync(AskRobotRequest request, AskRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskRobot",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/ask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用小蜜机器人的问答能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// AskRobotResponse
        /// </returns>
        public AskRobotResponse AskRobot(AskRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AskRobotHeaders headers = new AskRobotHeaders();
            return AskRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用小蜜机器人的问答能力</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// AskRobotResponse
        /// </returns>
        public async Task<AskRobotResponse> AskRobotAsync(AskRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AskRobotHeaders headers = new AskRobotHeaders();
            return await AskRobotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜机器人数据统计指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingMeBaseDataRequest
        /// </param>
        /// <param name="headers">
        /// GetDingMeBaseDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingMeBaseDataResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingMeBaseData",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingMeBaseDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜机器人数据统计指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingMeBaseDataRequest
        /// </param>
        /// <param name="headers">
        /// GetDingMeBaseDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingMeBaseDataResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingMeBaseData",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingMeBaseDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜机器人数据统计指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingMeBaseDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingMeBaseDataResponse
        /// </returns>
        public GetDingMeBaseDataResponse GetDingMeBaseData(GetDingMeBaseDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
            return GetDingMeBaseDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜机器人数据统计指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDingMeBaseDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDingMeBaseDataResponse
        /// </returns>
        public async Task<GetDingMeBaseDataResponse> GetDingMeBaseDataAsync(GetDingMeBaseDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
            return await GetDingMeBaseDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能客服机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntelligentRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetIntelligentRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntelligentRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntelligentRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntelligentRobotInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能客服机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntelligentRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetIntelligentRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntelligentRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntelligentRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntelligentRobotInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能客服机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntelligentRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntelligentRobotInfoResponse
        /// </returns>
        public GetIntelligentRobotInfoResponse GetIntelligentRobotInfo(GetIntelligentRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntelligentRobotInfoHeaders headers = new GetIntelligentRobotInfoHeaders();
            return GetIntelligentRobotInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能客服机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntelligentRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntelligentRobotInfoResponse
        /// </returns>
        public async Task<GetIntelligentRobotInfoResponse> GetIntelligentRobotInfoAsync(GetIntelligentRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIntelligentRobotInfoHeaders headers = new GetIntelligentRobotInfoHeaders();
            return await GetIntelligentRobotInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficialAccountRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountRobotInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetOfficialAccountRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficialAccountRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficialAccountRobotInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountRobotInfoResponse
        /// </returns>
        public GetOfficialAccountRobotInfoResponse GetOfficialAccountRobotInfo(GetOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountRobotInfoHeaders headers = new GetOfficialAccountRobotInfoHeaders();
            return GetOfficialAccountRobotInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOfficialAccountRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOfficialAccountRobotInfoResponse
        /// </returns>
        public async Task<GetOfficialAccountRobotInfoResponse> GetOfficialAccountRobotInfoAsync(GetOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOfficialAccountRobotInfoHeaders headers = new GetOfficialAccountRobotInfoHeaders();
            return await GetOfficialAccountRobotInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜客服网页渠道获取三方用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebChannelUserTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetWebChannelUserTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebChannelUserTokenResponse
        /// </returns>
        public GetWebChannelUserTokenResponse GetWebChannelUserTokenWithOptions(GetWebChannelUserTokenRequest request, GetWebChannelUserTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebChannelUserToken",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/webChannels/userTokens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebChannelUserTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜客服网页渠道获取三方用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebChannelUserTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetWebChannelUserTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebChannelUserTokenResponse
        /// </returns>
        public async Task<GetWebChannelUserTokenResponse> GetWebChannelUserTokenWithOptionsAsync(GetWebChannelUserTokenRequest request, GetWebChannelUserTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebChannelUserToken",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/webChannels/userTokens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebChannelUserTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜客服网页渠道获取三方用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebChannelUserTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebChannelUserTokenResponse
        /// </returns>
        public GetWebChannelUserTokenResponse GetWebChannelUserToken(GetWebChannelUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebChannelUserTokenHeaders headers = new GetWebChannelUserTokenHeaders();
            return GetWebChannelUserTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>小蜜客服网页渠道获取三方用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebChannelUserTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebChannelUserTokenResponse
        /// </returns>
        public async Task<GetWebChannelUserTokenResponse> GetWebChannelUserTokenAsync(GetWebChannelUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWebChannelUserTokenHeaders headers = new GetWebChannelUserTokenHeaders();
            return await GetWebChannelUserTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜机器人在客户群内推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushCustomerGroupMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushCustomerGroupMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushCustomerGroupMessageResponse
        /// </returns>
        public PushCustomerGroupMessageResponse PushCustomerGroupMessageWithOptions(PushCustomerGroupMessageRequest request, PushCustomerGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushCustomerGroupMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushCustomerGroupMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜机器人在客户群内推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushCustomerGroupMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushCustomerGroupMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushCustomerGroupMessageResponse
        /// </returns>
        public async Task<PushCustomerGroupMessageResponse> PushCustomerGroupMessageWithOptionsAsync(PushCustomerGroupMessageRequest request, PushCustomerGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushCustomerGroupMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushCustomerGroupMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜机器人在客户群内推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushCustomerGroupMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushCustomerGroupMessageResponse
        /// </returns>
        public PushCustomerGroupMessageResponse PushCustomerGroupMessage(PushCustomerGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushCustomerGroupMessageHeaders headers = new PushCustomerGroupMessageHeaders();
            return PushCustomerGroupMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜机器人在客户群内推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushCustomerGroupMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushCustomerGroupMessageResponse
        /// </returns>
        public async Task<PushCustomerGroupMessageResponse> PushCustomerGroupMessageAsync(PushCustomerGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushCustomerGroupMessageHeaders headers = new PushCustomerGroupMessageHeaders();
            return await PushCustomerGroupMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送智能客服机器人钉钉群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotGroupMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushIntelligentRobotGroupMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotGroupMessageResponse
        /// </returns>
        public PushIntelligentRobotGroupMessageResponse PushIntelligentRobotGroupMessageWithOptions(PushIntelligentRobotGroupMessageRequest request, PushIntelligentRobotGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntelligentRobotGroupMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushIntelligentRobotGroupMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送智能客服机器人钉钉群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotGroupMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushIntelligentRobotGroupMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotGroupMessageResponse
        /// </returns>
        public async Task<PushIntelligentRobotGroupMessageResponse> PushIntelligentRobotGroupMessageWithOptionsAsync(PushIntelligentRobotGroupMessageRequest request, PushIntelligentRobotGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntelligentRobotGroupMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/groupMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushIntelligentRobotGroupMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送智能客服机器人钉钉群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotGroupMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotGroupMessageResponse
        /// </returns>
        public PushIntelligentRobotGroupMessageResponse PushIntelligentRobotGroupMessage(PushIntelligentRobotGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotGroupMessageHeaders headers = new PushIntelligentRobotGroupMessageHeaders();
            return PushIntelligentRobotGroupMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送智能客服机器人钉钉群聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotGroupMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotGroupMessageResponse
        /// </returns>
        public async Task<PushIntelligentRobotGroupMessageResponse> PushIntelligentRobotGroupMessageAsync(PushIntelligentRobotGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotGroupMessageHeaders headers = new PushIntelligentRobotGroupMessageHeaders();
            return await PushIntelligentRobotGroupMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能客服机器人推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushIntelligentRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotMessageResponse
        /// </returns>
        public PushIntelligentRobotMessageResponse PushIntelligentRobotMessageWithOptions(PushIntelligentRobotMessageRequest request, PushIntelligentRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntelligentRobotMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushIntelligentRobotMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能客服机器人推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushIntelligentRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotMessageResponse
        /// </returns>
        public async Task<PushIntelligentRobotMessageResponse> PushIntelligentRobotMessageWithOptionsAsync(PushIntelligentRobotMessageRequest request, PushIntelligentRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntelligentRobotMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/intelligentRobots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushIntelligentRobotMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能客服机器人推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotMessageResponse
        /// </returns>
        public PushIntelligentRobotMessageResponse PushIntelligentRobotMessage(PushIntelligentRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotMessageHeaders headers = new PushIntelligentRobotMessageHeaders();
            return PushIntelligentRobotMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>智能客服机器人推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushIntelligentRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushIntelligentRobotMessageResponse
        /// </returns>
        public async Task<PushIntelligentRobotMessageResponse> PushIntelligentRobotMessageAsync(PushIntelligentRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushIntelligentRobotMessageHeaders headers = new PushIntelligentRobotMessageHeaders();
            return await PushIntelligentRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过服务窗机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushOfficialAccountMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushOfficialAccountMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushOfficialAccountMessageResponse
        /// </returns>
        public PushOfficialAccountMessageResponse PushOfficialAccountMessageWithOptions(PushOfficialAccountMessageRequest request, PushOfficialAccountMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushOfficialAccountMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushOfficialAccountMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过服务窗机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushOfficialAccountMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushOfficialAccountMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushOfficialAccountMessageResponse
        /// </returns>
        public async Task<PushOfficialAccountMessageResponse> PushOfficialAccountMessageWithOptionsAsync(PushOfficialAccountMessageRequest request, PushOfficialAccountMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushOfficialAccountMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushOfficialAccountMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过服务窗机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushOfficialAccountMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushOfficialAccountMessageResponse
        /// </returns>
        public PushOfficialAccountMessageResponse PushOfficialAccountMessage(PushOfficialAccountMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushOfficialAccountMessageHeaders headers = new PushOfficialAccountMessageHeaders();
            return PushOfficialAccountMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过服务窗机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushOfficialAccountMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushOfficialAccountMessageResponse
        /// </returns>
        public async Task<PushOfficialAccountMessageResponse> PushOfficialAccountMessageAsync(PushOfficialAccountMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushOfficialAccountMessageHeaders headers = new PushOfficialAccountMessageHeaders();
            return await PushOfficialAccountMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜客服机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRobotMessageResponse
        /// </returns>
        public PushRobotMessageResponse PushRobotMessageWithOptions(PushRobotMessageRequest request, PushRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRobotMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRobotMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜客服机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// PushRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRobotMessageResponse
        /// </returns>
        public async Task<PushRobotMessageResponse> PushRobotMessageWithOptionsAsync(PushRobotMessageRequest request, PushRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatbotId))
            {
                body["chatbotId"] = request.ChatbotId;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRobotMessage",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/oToMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRobotMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜客服机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRobotMessageResponse
        /// </returns>
        public PushRobotMessageResponse PushRobotMessage(PushRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushRobotMessageHeaders headers = new PushRobotMessageHeaders();
            return PushRobotMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过小蜜客服机器人推送单聊消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRobotMessageResponse
        /// </returns>
        public async Task<PushRobotMessageResponse> PushRobotMessageAsync(PushRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushRobotMessageHeaders headers = new PushRobotMessageHeaders();
            return await PushRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步回复机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplyRobotRequest
        /// </param>
        /// <param name="headers">
        /// ReplyRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplyRobotResponse
        /// </returns>
        public ReplyRobotResponse ReplyRobotWithOptions(ReplyRobotRequest request, ReplyRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplyRobot",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/reply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyRobotResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步回复机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplyRobotRequest
        /// </param>
        /// <param name="headers">
        /// ReplyRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplyRobotResponse
        /// </returns>
        public async Task<ReplyRobotResponse> ReplyRobotWithOptionsAsync(ReplyRobotRequest request, ReplyRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplyRobot",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/robots/reply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplyRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步回复机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplyRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplyRobotResponse
        /// </returns>
        public ReplyRobotResponse ReplyRobot(ReplyRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReplyRobotHeaders headers = new ReplyRobotHeaders();
            return ReplyRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>异步回复机器人消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplyRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplyRobotResponse
        /// </returns>
        public async Task<ReplyRobotResponse> ReplyRobotAsync(ReplyRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReplyRobotHeaders headers = new ReplyRobotHeaders();
            return await ReplyRobotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOfficialAccountRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateOfficialAccountRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOfficialAccountRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOfficialAccountRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOfficialAccountRobotInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOfficialAccountRobotInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateOfficialAccountRobotInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOfficialAccountRobotInfoResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOfficialAccountRobotInfo",
                Version = "dingmi_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dingmi/officialAccounts/robots",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOfficialAccountRobotInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOfficialAccountRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOfficialAccountRobotInfoResponse
        /// </returns>
        public UpdateOfficialAccountRobotInfoResponse UpdateOfficialAccountRobotInfo(UpdateOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOfficialAccountRobotInfoHeaders headers = new UpdateOfficialAccountRobotInfoHeaders();
            return UpdateOfficialAccountRobotInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新服务窗机器人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOfficialAccountRobotInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOfficialAccountRobotInfoResponse
        /// </returns>
        public async Task<UpdateOfficialAccountRobotInfoResponse> UpdateOfficialAccountRobotInfoAsync(UpdateOfficialAccountRobotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOfficialAccountRobotInfoHeaders headers = new UpdateOfficialAccountRobotInfoHeaders();
            return await UpdateOfficialAccountRobotInfoWithOptionsAsync(request, headers, runtime);
        }

    }
}
