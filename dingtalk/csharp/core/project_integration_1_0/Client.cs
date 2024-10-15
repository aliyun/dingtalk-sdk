// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkproject_integration_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkproject_integration_1_0
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
        /// <para>在项目事件会话中加人</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AddAttendeeToEventGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeToEventGroupResponse
        /// </returns>
        public AddAttendeeToEventGroupResponse AddAttendeeToEventGroupWithOptions(string userId, string groupId, AddAttendeeToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAttendeeToEventGroup",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAttendeeToEventGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在项目事件会话中加人</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AddAttendeeToEventGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddAttendeeToEventGroupResponse
        /// </returns>
        public async Task<AddAttendeeToEventGroupResponse> AddAttendeeToEventGroupWithOptionsAsync(string userId, string groupId, AddAttendeeToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAttendeeToEventGroup",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAttendeeToEventGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在项目事件会话中加人</para>
        /// </summary>
        /// 
        /// <returns>
        /// AddAttendeeToEventGroupResponse
        /// </returns>
        public AddAttendeeToEventGroupResponse AddAttendeeToEventGroup(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return AddAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在项目事件会话中加人</para>
        /// </summary>
        /// 
        /// <returns>
        /// AddAttendeeToEventGroupResponse
        /// </returns>
        public async Task<AddAttendeeToEventGroupResponse> AddAttendeeToEventGroupAsync(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return await AddAttendeeToEventGroupWithOptionsAsync(userId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目事件会话</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateEventGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventGroupResponse
        /// </returns>
        public CreateEventGroupResponse CreateEventGroupWithOptions(string userId, CreateEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventGroup",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/eventGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目事件会话</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateEventGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEventGroupResponse
        /// </returns>
        public async Task<CreateEventGroupResponse> CreateEventGroupWithOptionsAsync(string userId, CreateEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventGroup",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/eventGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目事件会话</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEventGroupResponse
        /// </returns>
        public CreateEventGroupResponse CreateEventGroup(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return CreateEventGroupWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目事件会话</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateEventGroupResponse
        /// </returns>
        public async Task<CreateEventGroupResponse> CreateEventGroupAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return await CreateEventGroupWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在群会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SendInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public SendInteractiveCardResponse SendInteractiveCardWithOptions(string userId, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在群会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SendInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public async Task<SendInteractiveCardResponse> SendInteractiveCardWithOptionsAsync(string userId, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在群会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public SendInteractiveCardResponse SendInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return SendInteractiveCardWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在群会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public async Task<SendInteractiveCardResponse> SendInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return await SendInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单聊会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SendSingleInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSingleInteractiveCardResponse
        /// </returns>
        public SendSingleInteractiveCardResponse SendSingleInteractiveCardWithOptions(string userId, SendSingleInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSingleInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSingleInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单聊会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// SendSingleInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendSingleInteractiveCardResponse
        /// </returns>
        public async Task<SendSingleInteractiveCardResponse> SendSingleInteractiveCardWithOptionsAsync(string userId, SendSingleInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendSingleInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendSingleInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单聊会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// SendSingleInteractiveCardResponse
        /// </returns>
        public SendSingleInteractiveCardResponse SendSingleInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return SendSingleInteractiveCardWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单聊会话发送项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// SendSingleInteractiveCardResponse
        /// </returns>
        public async Task<SendSingleInteractiveCardResponse> SendSingleInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return await SendSingleInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public UpdateInteractiveCardResponse UpdateInteractiveCardWithOptions(string userId, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/cardMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新项目卡片消息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardWithOptionsAsync(string userId, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInteractiveCard",
                Version = "projectIntegration_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/projectIntegration/users/" + userId + "/cardMessages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public UpdateInteractiveCardResponse UpdateInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return UpdateInteractiveCardWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新项目卡片消息</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return await UpdateInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

    }
}
