// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0
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
         * @summary 添加群成员
         *
         * @param request AddGroupMembersRequest
         * @param headers AddGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMembersResponse
         */
        public AddGroupMembersResponse AddGroupMembersWithOptions(AddGroupMembersRequest request, AddGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "AddGroupMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/members/batchAdd",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMembersRequest
         * @param headers AddGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMembersResponse
         */
        public async Task<AddGroupMembersResponse> AddGroupMembersWithOptionsAsync(AddGroupMembersRequest request, AddGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "AddGroupMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/members/batchAdd",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMembersRequest
         * @return AddGroupMembersResponse
         */
        public AddGroupMembersResponse AddGroupMembers(AddGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMembersHeaders headers = new AddGroupMembersHeaders();
            return AddGroupMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMembersRequest
         * @return AddGroupMembersResponse
         */
        public async Task<AddGroupMembersResponse> AddGroupMembersAsync(AddGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMembersHeaders headers = new AddGroupMembersHeaders();
            return await AddGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 外部用户导入profile
         *
         * @param request AddProfileRequest
         * @param headers AddProfileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProfileResponse
         */
        public AddProfileResponse AddProfileWithOptions(AddProfileRequest request, AddProfileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUid))
            {
                body["appUid"] = request.AppUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarMediaId))
            {
                body["avatarMediaId"] = request.AvatarMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                body["mobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                body["nick"] = request.Nick;
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
                Action = "AddProfile",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/users/profiles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddProfileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 外部用户导入profile
         *
         * @param request AddProfileRequest
         * @param headers AddProfileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProfileResponse
         */
        public async Task<AddProfileResponse> AddProfileWithOptionsAsync(AddProfileRequest request, AddProfileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUid))
            {
                body["appUid"] = request.AppUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarMediaId))
            {
                body["avatarMediaId"] = request.AvatarMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                body["mobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nick))
            {
                body["nick"] = request.Nick;
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
                Action = "AddProfile",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/users/profiles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<AddProfileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 外部用户导入profile
         *
         * @param request AddProfileRequest
         * @return AddProfileResponse
         */
        public AddProfileResponse AddProfile(AddProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProfileHeaders headers = new AddProfileHeaders();
            return AddProfileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 外部用户导入profile
         *
         * @param request AddProfileRequest
         * @return AddProfileResponse
         */
        public async Task<AddProfileResponse> AddProfileAsync(AddProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProfileHeaders headers = new AddProfileHeaders();
            return await AddProfileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消息批量接口
         *
         * @param request BatchSendRequest
         * @param headers BatchSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSendResponse
         */
        public BatchSendResponse BatchSendWithOptions(BatchSendRequest request, BatchSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUids))
            {
                body["appUids"] = request.AppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationIds))
            {
                body["conversationIds"] = request.ConversationIds;
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
                Action = "BatchSend",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 消息批量接口
         *
         * @param request BatchSendRequest
         * @param headers BatchSendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSendResponse
         */
        public async Task<BatchSendResponse> BatchSendWithOptionsAsync(BatchSendRequest request, BatchSendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUids))
            {
                body["appUids"] = request.AppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationIds))
            {
                body["conversationIds"] = request.ConversationIds;
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
                Action = "BatchSend",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/batchSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 消息批量接口
         *
         * @param request BatchSendRequest
         * @return BatchSendResponse
         */
        public BatchSendResponse BatchSend(BatchSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendHeaders headers = new BatchSendHeaders();
            return BatchSendWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消息批量接口
         *
         * @param request BatchSendRequest
         * @return BatchSendResponse
         */
        public async Task<BatchSendResponse> BatchSendAsync(BatchSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSendHeaders headers = new BatchSendHeaders();
            return await BatchSendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建群
         *
         * @param request CreateGroupRequest
         * @param headers CreateGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUid))
            {
                body["creatorUid"] = request.CreatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconMediaId))
            {
                body["iconMediaId"] = request.IconMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "CreateGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建群
         *
         * @param request CreateGroupRequest
         * @param headers CreateGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUid))
            {
                body["creatorUid"] = request.CreatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconMediaId))
            {
                body["iconMediaId"] = request.IconMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "CreateGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建群
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return CreateGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建群
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return await CreateGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建托管账号为群主的群
         *
         * @param request CreateTrustGroupRequest
         * @param headers CreateTrustGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustGroupResponse
         */
        public CreateTrustGroupResponse CreateTrustGroupWithOptions(CreateTrustGroupRequest request, CreateTrustGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconMediaId))
            {
                body["iconMediaId"] = request.IconMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemMsg))
            {
                body["systemMsg"] = request.SystemMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "CreateTrustGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/trusts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建托管账号为群主的群
         *
         * @param request CreateTrustGroupRequest
         * @param headers CreateTrustGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrustGroupResponse
         */
        public async Task<CreateTrustGroupResponse> CreateTrustGroupWithOptionsAsync(CreateTrustGroupRequest request, CreateTrustGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconMediaId))
            {
                body["iconMediaId"] = request.IconMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemMsg))
            {
                body["systemMsg"] = request.SystemMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "CreateTrustGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/trusts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrustGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建托管账号为群主的群
         *
         * @param request CreateTrustGroupRequest
         * @return CreateTrustGroupResponse
         */
        public CreateTrustGroupResponse CreateTrustGroup(CreateTrustGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustGroupHeaders headers = new CreateTrustGroupHeaders();
            return CreateTrustGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建托管账号为群主的群
         *
         * @param request CreateTrustGroupRequest
         * @return CreateTrustGroupResponse
         */
        public async Task<CreateTrustGroupResponse> CreateTrustGroupAsync(CreateTrustGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTrustGroupHeaders headers = new CreateTrustGroupHeaders();
            return await CreateTrustGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解散群
         *
         * @param request DismissGroupRequest
         * @param headers DismissGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DismissGroupResponse
         */
        public DismissGroupResponse DismissGroupWithOptions(DismissGroupRequest request, DismissGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "DismissGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/dismiss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DismissGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 解散群
         *
         * @param request DismissGroupRequest
         * @param headers DismissGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DismissGroupResponse
         */
        public async Task<DismissGroupResponse> DismissGroupWithOptionsAsync(DismissGroupRequest request, DismissGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "DismissGroup",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/dismiss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DismissGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 解散群
         *
         * @param request DismissGroupRequest
         * @return DismissGroupResponse
         */
        public DismissGroupResponse DismissGroup(DismissGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupHeaders headers = new DismissGroupHeaders();
            return DismissGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解散群
         *
         * @param request DismissGroupRequest
         * @return DismissGroupResponse
         */
        public async Task<DismissGroupResponse> DismissGroupAsync(DismissGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupHeaders headers = new DismissGroupHeaders();
            return await DismissGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生成单聊会话Id
         *
         * @param request GetConversationIdRequest
         * @param headers GetConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationIdResponse
         */
        public GetConversationIdResponse GetConversationIdWithOptions(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUid))
            {
                body["appUid"] = request.AppUid;
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
                Action = "GetConversationId",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 生成单聊会话Id
         *
         * @param request GetConversationIdRequest
         * @param headers GetConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationIdResponse
         */
        public async Task<GetConversationIdResponse> GetConversationIdWithOptionsAsync(GetConversationIdRequest request, GetConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUid))
            {
                body["appUid"] = request.AppUid;
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
                Action = "GetConversationId",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 生成单聊会话Id
         *
         * @param request GetConversationIdRequest
         * @return GetConversationIdResponse
         */
        public GetConversationIdResponse GetConversationId(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return GetConversationIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生成单聊会话Id
         *
         * @param request GetConversationIdRequest
         * @return GetConversationIdResponse
         */
        public async Task<GetConversationIdResponse> GetConversationIdAsync(GetConversationIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationIdHeaders headers = new GetConversationIdHeaders();
            return await GetConversationIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 多媒体文件下载
         *
         * @param request GetMediaUrlRequest
         * @param headers GetMediaUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaUrlResponse
         */
        public GetMediaUrlResponse GetMediaUrlWithOptions(GetMediaUrlRequest request, GetMediaUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireTime))
            {
                body["urlExpireTime"] = request.UrlExpireTime;
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
                Action = "GetMediaUrl",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/medium/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 多媒体文件下载
         *
         * @param request GetMediaUrlRequest
         * @param headers GetMediaUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaUrlResponse
         */
        public async Task<GetMediaUrlResponse> GetMediaUrlWithOptionsAsync(GetMediaUrlRequest request, GetMediaUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireTime))
            {
                body["urlExpireTime"] = request.UrlExpireTime;
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
                Action = "GetMediaUrl",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/medium/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 多媒体文件下载
         *
         * @param request GetMediaUrlRequest
         * @return GetMediaUrlResponse
         */
        public GetMediaUrlResponse GetMediaUrl(GetMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaUrlHeaders headers = new GetMediaUrlHeaders();
            return GetMediaUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 多媒体文件下载
         *
         * @param request GetMediaUrlRequest
         * @return GetMediaUrlResponse
         */
        public async Task<GetMediaUrlResponse> GetMediaUrlAsync(GetMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaUrlHeaders headers = new GetMediaUrlHeaders();
            return await GetMediaUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 多媒体文件批量下载
         *
         * @param request GetMediaUrlsRequest
         * @param headers GetMediaUrlsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaUrlsResponse
         */
        public GetMediaUrlsResponse GetMediaUrlsWithOptions(GetMediaUrlsRequest request, GetMediaUrlsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                body["mediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireTime))
            {
                body["urlExpireTime"] = request.UrlExpireTime;
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
                Action = "GetMediaUrls",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/mediaUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaUrlsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 多媒体文件批量下载
         *
         * @param request GetMediaUrlsRequest
         * @param headers GetMediaUrlsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaUrlsResponse
         */
        public async Task<GetMediaUrlsResponse> GetMediaUrlsWithOptionsAsync(GetMediaUrlsRequest request, GetMediaUrlsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                body["mediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlExpireTime))
            {
                body["urlExpireTime"] = request.UrlExpireTime;
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
                Action = "GetMediaUrls",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/mediaUrls/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaUrlsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 多媒体文件批量下载
         *
         * @param request GetMediaUrlsRequest
         * @return GetMediaUrlsResponse
         */
        public GetMediaUrlsResponse GetMediaUrls(GetMediaUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaUrlsHeaders headers = new GetMediaUrlsHeaders();
            return GetMediaUrlsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 多媒体文件批量下载
         *
         * @param request GetMediaUrlsRequest
         * @return GetMediaUrlsResponse
         */
        public async Task<GetMediaUrlsResponse> GetMediaUrlsAsync(GetMediaUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMediaUrlsHeaders headers = new GetMediaUrlsHeaders();
            return await GetMediaUrlsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取钉盘文件下载信息
         *
         * @param request GetSpaceFileUrlRequest
         * @param headers GetSpaceFileUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceFileUrlResponse
         */
        public GetSpaceFileUrlResponse GetSpaceFileUrlWithOptions(GetSpaceFileUrlRequest request, GetSpaceFileUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                query["senderUid"] = request.SenderUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                query["spaceId"] = request.SpaceId;
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
                Action = "GetSpaceFileUrl",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/spaces/files/urls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceFileUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取钉盘文件下载信息
         *
         * @param request GetSpaceFileUrlRequest
         * @param headers GetSpaceFileUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceFileUrlResponse
         */
        public async Task<GetSpaceFileUrlResponse> GetSpaceFileUrlWithOptionsAsync(GetSpaceFileUrlRequest request, GetSpaceFileUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                query["senderUid"] = request.SenderUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                query["spaceId"] = request.SpaceId;
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
                Action = "GetSpaceFileUrl",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/spaces/files/urls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceFileUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取钉盘文件下载信息
         *
         * @param request GetSpaceFileUrlRequest
         * @return GetSpaceFileUrlResponse
         */
        public GetSpaceFileUrlResponse GetSpaceFileUrl(GetSpaceFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceFileUrlHeaders headers = new GetSpaceFileUrlHeaders();
            return GetSpaceFileUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取钉盘文件下载信息
         *
         * @param request GetSpaceFileUrlRequest
         * @return GetSpaceFileUrlResponse
         */
        public async Task<GetSpaceFileUrlResponse> GetSpaceFileUrlAsync(GetSpaceFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceFileUrlHeaders headers = new GetSpaceFileUrlHeaders();
            return await GetSpaceFileUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业员工类型的群成员
         *
         * @param request ListGroupStaffMembersRequest
         * @param headers ListGroupStaffMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupStaffMembersResponse
         */
        public ListGroupStaffMembersResponse ListGroupStaffMembersWithOptions(ListGroupStaffMembersRequest request, ListGroupStaffMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
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
                Action = "ListGroupStaffMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/staffMemers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupStaffMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业员工类型的群成员
         *
         * @param request ListGroupStaffMembersRequest
         * @param headers ListGroupStaffMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupStaffMembersResponse
         */
        public async Task<ListGroupStaffMembersResponse> ListGroupStaffMembersWithOptionsAsync(ListGroupStaffMembersRequest request, ListGroupStaffMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
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
                Action = "ListGroupStaffMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/staffMemers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupStaffMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业员工类型的群成员
         *
         * @param request ListGroupStaffMembersRequest
         * @return ListGroupStaffMembersResponse
         */
        public ListGroupStaffMembersResponse ListGroupStaffMembers(ListGroupStaffMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupStaffMembersHeaders headers = new ListGroupStaffMembersHeaders();
            return ListGroupStaffMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业员工类型的群成员
         *
         * @param request ListGroupStaffMembersRequest
         * @return ListGroupStaffMembersResponse
         */
        public async Task<ListGroupStaffMembersResponse> ListGroupStaffMembersAsync(ListGroupStaffMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupStaffMembersHeaders headers = new ListGroupStaffMembersHeaders();
            return await ListGroupStaffMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询batchSend结果
         *
         * @param request QueryBatchSendResultRequest
         * @param headers QueryBatchSendResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchSendResultResponse
         */
        public QueryBatchSendResultResponse QueryBatchSendResultWithOptions(QueryBatchSendResultRequest request, QueryBatchSendResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                query["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryBatchSendResult",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/batchSendResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchSendResultResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询batchSend结果
         *
         * @param request QueryBatchSendResultRequest
         * @param headers QueryBatchSendResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchSendResultResponse
         */
        public async Task<QueryBatchSendResultResponse> QueryBatchSendResultWithOptionsAsync(QueryBatchSendResultRequest request, QueryBatchSendResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                query["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryBatchSendResult",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/batchSendResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchSendResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询batchSend结果
         *
         * @param request QueryBatchSendResultRequest
         * @return QueryBatchSendResultResponse
         */
        public QueryBatchSendResultResponse QueryBatchSendResult(QueryBatchSendResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchSendResultHeaders headers = new QueryBatchSendResultHeaders();
            return QueryBatchSendResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询batchSend结果
         *
         * @param request QueryBatchSendResultRequest
         * @return QueryBatchSendResultResponse
         */
        public async Task<QueryBatchSendResultResponse> QueryBatchSendResultAsync(QueryBatchSendResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchSendResultHeaders headers = new QueryBatchSendResultHeaders();
            return await QueryBatchSendResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消息已读
         *
         * @param request ReadMessageRequest
         * @param headers ReadMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReadMessageResponse
         */
        public ReadMessageResponse ReadMessageWithOptions(ReadMessageRequest request, ReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "ReadMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/read",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ReadMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 消息已读
         *
         * @param request ReadMessageRequest
         * @param headers ReadMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReadMessageResponse
         */
        public async Task<ReadMessageResponse> ReadMessageWithOptionsAsync(ReadMessageRequest request, ReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "ReadMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/read",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<ReadMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 消息已读
         *
         * @param request ReadMessageRequest
         * @return ReadMessageResponse
         */
        public ReadMessageResponse ReadMessage(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReadMessageHeaders headers = new ReadMessageHeaders();
            return ReadMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消息已读
         *
         * @param request ReadMessageRequest
         * @return ReadMessageResponse
         */
        public async Task<ReadMessageResponse> ReadMessageAsync(ReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReadMessageHeaders headers = new ReadMessageHeaders();
            return await ReadMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消息撤回
         *
         * @param request RecallMessageRequest
         * @param headers RecallMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecallMessageResponse
         */
        public RecallMessageResponse RecallMessageWithOptions(RecallMessageRequest request, RecallMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "RecallMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RecallMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 消息撤回
         *
         * @param request RecallMessageRequest
         * @param headers RecallMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecallMessageResponse
         */
        public async Task<RecallMessageResponse> RecallMessageWithOptionsAsync(RecallMessageRequest request, RecallMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "RecallMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<RecallMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 消息撤回
         *
         * @param request RecallMessageRequest
         * @return RecallMessageResponse
         */
        public RecallMessageResponse RecallMessage(RecallMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallMessageHeaders headers = new RecallMessageHeaders();
            return RecallMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消息撤回
         *
         * @param request RecallMessageRequest
         * @return RecallMessageResponse
         */
        public async Task<RecallMessageResponse> RecallMessageAsync(RecallMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallMessageHeaders headers = new RecallMessageHeaders();
            return await RecallMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMembersRequest
         * @param headers RemoveGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMembersResponse
         */
        public RemoveGroupMembersResponse RemoveGroupMembersWithOptions(RemoveGroupMembersRequest request, RemoveGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                body["memberUids"] = request.MemberUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "RemoveGroupMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/members/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMembersRequest
         * @param headers RemoveGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMembersResponse
         */
        public async Task<RemoveGroupMembersResponse> RemoveGroupMembersWithOptionsAsync(RemoveGroupMembersRequest request, RemoveGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                body["memberUids"] = request.MemberUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "RemoveGroupMembers",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/members/batchRemove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMembersRequest
         * @return RemoveGroupMembersResponse
         */
        public RemoveGroupMembersResponse RemoveGroupMembers(RemoveGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMembersHeaders headers = new RemoveGroupMembersHeaders();
            return RemoveGroupMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMembersRequest
         * @return RemoveGroupMembersResponse
         */
        public async Task<RemoveGroupMembersResponse> RemoveGroupMembersAsync(RemoveGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMembersHeaders headers = new RemoveGroupMembersHeaders();
            return await RemoveGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 消息发送
         *
         * @param request SendMessageRequest
         * @param headers SendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessageWithOptions(SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUid))
            {
                body["receiverUid"] = request.ReceiverUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                body["senderUid"] = request.SenderUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "SendMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 消息发送
         *
         * @param request SendMessageRequest
         * @param headers SendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUid))
            {
                body["receiverUid"] = request.ReceiverUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                body["senderUid"] = request.SenderUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "SendMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 消息发送
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return SendMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 消息发送
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return await SendMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过群模板机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @param headers SendRobotMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotMessageResponse
         */
        public SendRobotMessageResponse SendRobotMessageWithOptions(SendRobotMessageRequest request, SendRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAll))
            {
                body["atAll"] = request.AtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAppUids))
            {
                body["atAppUids"] = request.AtAppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtMobiles))
            {
                body["atMobiles"] = request.AtMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUnionIds))
            {
                body["atUnionIds"] = request.AtUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUsers))
            {
                body["atUsers"] = request.AtUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgMediaIdParamMap))
            {
                body["msgMediaIdParamMap"] = request.MsgMediaIdParamMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParamMap))
            {
                body["msgParamMap"] = request.MsgParamMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgTemplateId))
            {
                body["msgTemplateId"] = request.MsgTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAppUids))
            {
                body["receiverAppUids"] = request.ReceiverAppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverMobiles))
            {
                body["receiverMobiles"] = request.ReceiverMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOpenConversationId))
            {
                body["targetOpenConversationId"] = request.TargetOpenConversationId;
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
                Action = "SendRobotMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/robots/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过群模板机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @param headers SendRobotMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotMessageResponse
         */
        public async Task<SendRobotMessageResponse> SendRobotMessageWithOptionsAsync(SendRobotMessageRequest request, SendRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAll))
            {
                body["atAll"] = request.AtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAppUids))
            {
                body["atAppUids"] = request.AtAppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtMobiles))
            {
                body["atMobiles"] = request.AtMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUnionIds))
            {
                body["atUnionIds"] = request.AtUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUsers))
            {
                body["atUsers"] = request.AtUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgMediaIdParamMap))
            {
                body["msgMediaIdParamMap"] = request.MsgMediaIdParamMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgParamMap))
            {
                body["msgParamMap"] = request.MsgParamMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgTemplateId))
            {
                body["msgTemplateId"] = request.MsgTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAppUids))
            {
                body["receiverAppUids"] = request.ReceiverAppUids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverMobiles))
            {
                body["receiverMobiles"] = request.ReceiverMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIds))
            {
                body["receiverUserIds"] = request.ReceiverUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOpenConversationId))
            {
                body["targetOpenConversationId"] = request.TargetOpenConversationId;
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
                Action = "SendRobotMessage",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/robots/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过群模板机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @return SendRobotMessageResponse
         */
        public SendRobotMessageResponse SendRobotMessage(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return SendRobotMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过群模板机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @return SendRobotMessageResponse
         */
        public async Task<SendRobotMessageResponse> SendRobotMessageAsync(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return await SendRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @param headers UpdateGroupNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupNameResponse
         */
        public UpdateGroupNameResponse UpdateGroupNameWithOptions(UpdateGroupNameRequest request, UpdateGroupNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "UpdateGroupName",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupNameResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @param headers UpdateGroupNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupNameResponse
         */
        public async Task<UpdateGroupNameResponse> UpdateGroupNameWithOptionsAsync(UpdateGroupNameRequest request, UpdateGroupNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.OperationSource))
            {
                realHeaders["operationSource"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.OperationSource);
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
                Action = "UpdateGroupName",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @return UpdateGroupNameResponse
         */
        public UpdateGroupNameResponse UpdateGroupName(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return UpdateGroupNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @return UpdateGroupNameResponse
         */
        public async Task<UpdateGroupNameResponse> UpdateGroupNameAsync(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return await UpdateGroupNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 转让群主
         *
         * @param request UpdateGroupOwnerRequest
         * @param headers UpdateGroupOwnerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupOwnerResponse
         */
        public UpdateGroupOwnerResponse UpdateGroupOwnerWithOptions(UpdateGroupOwnerRequest request, UpdateGroupOwnerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                body["ownerUid"] = request.OwnerUid;
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
                Action = "UpdateGroupOwner",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/owners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupOwnerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 转让群主
         *
         * @param request UpdateGroupOwnerRequest
         * @param headers UpdateGroupOwnerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupOwnerResponse
         */
        public async Task<UpdateGroupOwnerResponse> UpdateGroupOwnerWithOptionsAsync(UpdateGroupOwnerRequest request, UpdateGroupOwnerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                body["operatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                body["ownerUid"] = request.OwnerUid;
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
                Action = "UpdateGroupOwner",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/groups/owners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupOwnerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 转让群主
         *
         * @param request UpdateGroupOwnerRequest
         * @return UpdateGroupOwnerResponse
         */
        public UpdateGroupOwnerResponse UpdateGroupOwner(UpdateGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupOwnerHeaders headers = new UpdateGroupOwnerHeaders();
            return UpdateGroupOwnerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 转让群主
         *
         * @param request UpdateGroupOwnerRequest
         * @return UpdateGroupOwnerResponse
         */
        public async Task<UpdateGroupOwnerResponse> UpdateGroupOwnerAsync(UpdateGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupOwnerHeaders headers = new UpdateGroupOwnerHeaders();
            return await UpdateGroupOwnerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 互联互通上传文件
         *
         * @param request UploadFileRequest
         * @param headers UploadFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadFileResponse
         */
        public UploadFileResponse UploadFileWithOptions(UploadFileRequest request, UploadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                body["senderUid"] = request.SenderUid;
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
                Action = "UploadFile",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/files/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 互联互通上传文件
         *
         * @param request UploadFileRequest
         * @param headers UploadFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadFileResponse
         */
        public async Task<UploadFileResponse> UploadFileWithOptionsAsync(UploadFileRequest request, UploadFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["fileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUid))
            {
                body["senderUid"] = request.SenderUid;
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
                Action = "UploadFile",
                Version = "impaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/impaas/interconnections/files/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 互联互通上传文件
         *
         * @param request UploadFileRequest
         * @return UploadFileResponse
         */
        public UploadFileResponse UploadFile(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadFileHeaders headers = new UploadFileHeaders();
            return UploadFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 互联互通上传文件
         *
         * @param request UploadFileRequest
         * @return UploadFileResponse
         */
        public async Task<UploadFileResponse> UploadFileAsync(UploadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadFileHeaders headers = new UploadFileHeaders();
            return await UploadFileWithOptionsAsync(request, headers, runtime);
        }

    }
}
