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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 在项目事件会话中加人
         *
         * @param headers AddAttendeeToEventGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAttendeeToEventGroupResponse
         */
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

        /**
         * @summary 在项目事件会话中加人
         *
         * @param headers AddAttendeeToEventGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddAttendeeToEventGroupResponse
         */
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

        /**
         * @summary 在项目事件会话中加人
         *
         * @return AddAttendeeToEventGroupResponse
         */
        public AddAttendeeToEventGroupResponse AddAttendeeToEventGroup(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return AddAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
        }

        /**
         * @summary 在项目事件会话中加人
         *
         * @return AddAttendeeToEventGroupResponse
         */
        public async Task<AddAttendeeToEventGroupResponse> AddAttendeeToEventGroupAsync(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return await AddAttendeeToEventGroupWithOptionsAsync(userId, groupId, headers, runtime);
        }

        /**
         * @summary 创建项目事件会话
         *
         * @param headers CreateEventGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEventGroupResponse
         */
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

        /**
         * @summary 创建项目事件会话
         *
         * @param headers CreateEventGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEventGroupResponse
         */
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

        /**
         * @summary 创建项目事件会话
         *
         * @return CreateEventGroupResponse
         */
        public CreateEventGroupResponse CreateEventGroup(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return CreateEventGroupWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 创建项目事件会话
         *
         * @return CreateEventGroupResponse
         */
        public async Task<CreateEventGroupResponse> CreateEventGroupAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return await CreateEventGroupWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 在群会话发送项目卡片消息
         *
         * @param headers SendInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveCardResponse
         */
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

        /**
         * @summary 在群会话发送项目卡片消息
         *
         * @param headers SendInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveCardResponse
         */
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

        /**
         * @summary 在群会话发送项目卡片消息
         *
         * @return SendInteractiveCardResponse
         */
        public SendInteractiveCardResponse SendInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return SendInteractiveCardWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 在群会话发送项目卡片消息
         *
         * @return SendInteractiveCardResponse
         */
        public async Task<SendInteractiveCardResponse> SendInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return await SendInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 单聊会话发送项目卡片消息
         *
         * @param headers SendSingleInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendSingleInteractiveCardResponse
         */
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

        /**
         * @summary 单聊会话发送项目卡片消息
         *
         * @param headers SendSingleInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendSingleInteractiveCardResponse
         */
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

        /**
         * @summary 单聊会话发送项目卡片消息
         *
         * @return SendSingleInteractiveCardResponse
         */
        public SendSingleInteractiveCardResponse SendSingleInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return SendSingleInteractiveCardWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 单聊会话发送项目卡片消息
         *
         * @return SendSingleInteractiveCardResponse
         */
        public async Task<SendSingleInteractiveCardResponse> SendSingleInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return await SendSingleInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 更新项目卡片消息
         *
         * @param headers UpdateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveCardResponse
         */
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

        /**
         * @summary 更新项目卡片消息
         *
         * @param headers UpdateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveCardResponse
         */
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

        /**
         * @summary 更新项目卡片消息
         *
         * @return UpdateInteractiveCardResponse
         */
        public UpdateInteractiveCardResponse UpdateInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return UpdateInteractiveCardWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 更新项目卡片消息
         *
         * @return UpdateInteractiveCardResponse
         */
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return await UpdateInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

    }
}
