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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public AddAttendeeToEventGroupResponse AddAttendeeToEventGroup(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return AddAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
        }

        public async Task<AddAttendeeToEventGroupResponse> AddAttendeeToEventGroupAsync(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
            return await AddAttendeeToEventGroupWithOptionsAsync(userId, groupId, headers, runtime);
        }

        public AddAttendeeToEventGroupResponse AddAttendeeToEventGroupWithOptions(string userId, string groupId, AddAttendeeToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<AddAttendeeToEventGroupResponse>(DoROARequest("AddAttendeeToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members", "json", req, runtime));
        }

        public async Task<AddAttendeeToEventGroupResponse> AddAttendeeToEventGroupWithOptionsAsync(string userId, string groupId, AddAttendeeToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<AddAttendeeToEventGroupResponse>(await DoROARequestAsync("AddAttendeeToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members", "json", req, runtime));
        }

        public SendInteractiveCardResponse SendInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return SendInteractiveCardWithOptions(userId, headers, runtime);
        }

        public async Task<SendInteractiveCardResponse> SendInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return await SendInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        public SendInteractiveCardResponse SendInteractiveCardWithOptions(string userId, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(DoROARequest("SendInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages", "json", req, runtime));
        }

        public async Task<SendInteractiveCardResponse> SendInteractiveCardWithOptionsAsync(string userId, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(await DoROARequestAsync("SendInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages", "json", req, runtime));
        }

        public UpdateInteractiveCardResponse UpdateInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return UpdateInteractiveCardWithOptions(userId, headers, runtime);
        }

        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return await UpdateInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        public UpdateInteractiveCardResponse UpdateInteractiveCardWithOptions(string userId, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(DoROARequest("UpdateInteractiveCard", "projectIntegration_1.0", "HTTP", "PUT", "AK", "/v1.0/projectIntegration/users/" + userId + "/cardMessages", "json", req, runtime));
        }

        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardWithOptionsAsync(string userId, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(await DoROARequestAsync("UpdateInteractiveCard", "projectIntegration_1.0", "HTTP", "PUT", "AK", "/v1.0/projectIntegration/users/" + userId + "/cardMessages", "json", req, runtime));
        }

        public SendSingleInteractiveCardResponse SendSingleInteractiveCard(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return SendSingleInteractiveCardWithOptions(userId, headers, runtime);
        }

        public async Task<SendSingleInteractiveCardResponse> SendSingleInteractiveCardAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
            return await SendSingleInteractiveCardWithOptionsAsync(userId, headers, runtime);
        }

        public SendSingleInteractiveCardResponse SendSingleInteractiveCardWithOptions(string userId, SendSingleInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendSingleInteractiveCardResponse>(DoROARequest("SendSingleInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages", "json", req, runtime));
        }

        public async Task<SendSingleInteractiveCardResponse> SendSingleInteractiveCardWithOptionsAsync(string userId, SendSingleInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendSingleInteractiveCardResponse>(await DoROARequestAsync("SendSingleInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages", "json", req, runtime));
        }

        public SendMessageToEventGroupResponse SendMessageToEventGroup(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageToEventGroupHeaders headers = new SendMessageToEventGroupHeaders();
            return SendMessageToEventGroupWithOptions(userId, groupId, headers, runtime);
        }

        public async Task<SendMessageToEventGroupResponse> SendMessageToEventGroupAsync(string userId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageToEventGroupHeaders headers = new SendMessageToEventGroupHeaders();
            return await SendMessageToEventGroupWithOptionsAsync(userId, groupId, headers, runtime);
        }

        public SendMessageToEventGroupResponse SendMessageToEventGroupWithOptions(string userId, string groupId, SendMessageToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendMessageToEventGroupResponse>(DoROARequest("SendMessageToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/messages", "json", req, runtime));
        }

        public async Task<SendMessageToEventGroupResponse> SendMessageToEventGroupWithOptionsAsync(string userId, string groupId, SendMessageToEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<SendMessageToEventGroupResponse>(await DoROARequestAsync("SendMessageToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/messages", "json", req, runtime));
        }

        public CreateEventGroupResponse CreateEventGroup(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return CreateEventGroupWithOptions(userId, headers, runtime);
        }

        public async Task<CreateEventGroupResponse> CreateEventGroupAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
            return await CreateEventGroupWithOptionsAsync(userId, headers, runtime);
        }

        public CreateEventGroupResponse CreateEventGroupWithOptions(string userId, CreateEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<CreateEventGroupResponse>(DoROARequest("CreateEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups", "json", req, runtime));
        }

        public async Task<CreateEventGroupResponse> CreateEventGroupWithOptionsAsync(string userId, CreateEventGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<CreateEventGroupResponse>(await DoROARequestAsync("CreateEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups", "json", req, runtime));
        }

    }
}
