// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0
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


        public AddContactMemberToGroupResponse AddContactMemberToGroupWithOptions(AddContactMemberToGroupRequest request, AddContactMemberToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FissionType))
            {
                body["fissionType"] = request.FissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUnionId))
            {
                body["memberUnionId"] = request.MemberUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserId))
            {
                body["memberUserId"] = request.MemberUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "AddContactMemberToGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContactMemberToGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddContactMemberToGroupResponse> AddContactMemberToGroupWithOptionsAsync(AddContactMemberToGroupRequest request, AddContactMemberToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FissionType))
            {
                body["fissionType"] = request.FissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUnionId))
            {
                body["memberUnionId"] = request.MemberUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUserId))
            {
                body["memberUserId"] = request.MemberUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "AddContactMemberToGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContactMemberToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddContactMemberToGroupResponse AddContactMemberToGroup(AddContactMemberToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactMemberToGroupHeaders headers = new AddContactMemberToGroupHeaders();
            return AddContactMemberToGroupWithOptions(request, headers, runtime);
        }

        public async Task<AddContactMemberToGroupResponse> AddContactMemberToGroupAsync(AddContactMemberToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddContactMemberToGroupHeaders headers = new AddContactMemberToGroupHeaders();
            return await AddContactMemberToGroupWithOptionsAsync(request, headers, runtime);
        }

        public AddKnowledgeResponse AddKnowledgeWithOptions(AddKnowledgeRequest request, AddKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentList))
            {
                body["attachmentList"] = request.AttachmentList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimeend))
            {
                body["effectTimeend"] = request.EffectTimeend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimestart))
            {
                body["effectTimestart"] = request.EffectTimestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtTitle))
            {
                body["extTitle"] = request.ExtTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryKey))
            {
                body["libraryKey"] = request.LibraryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkUrl))
            {
                body["linkUrl"] = request.LinkUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionIds))
            {
                body["questionIds"] = request.QuestionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
                Action = "AddKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/knowledges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKnowledgeResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddKnowledgeResponse> AddKnowledgeWithOptionsAsync(AddKnowledgeRequest request, AddKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentList))
            {
                body["attachmentList"] = request.AttachmentList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimeend))
            {
                body["effectTimeend"] = request.EffectTimeend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimestart))
            {
                body["effectTimestart"] = request.EffectTimestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtTitle))
            {
                body["extTitle"] = request.ExtTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryKey))
            {
                body["libraryKey"] = request.LibraryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkUrl))
            {
                body["linkUrl"] = request.LinkUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuestionIds))
            {
                body["questionIds"] = request.QuestionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
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
                Action = "AddKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/knowledges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddKnowledgeResponse AddKnowledge(AddKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
            return AddKnowledgeWithOptions(request, headers, runtime);
        }

        public async Task<AddKnowledgeResponse> AddKnowledgeAsync(AddKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
            return await AddKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        public AddLibraryResponse AddLibraryWithOptions(AddLibraryRequest request, AddLibraryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamIds))
            {
                body["openTeamIds"] = request.OpenTeamIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "AddLibrary",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/librarys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLibraryResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddLibraryResponse> AddLibraryWithOptionsAsync(AddLibraryRequest request, AddLibraryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamIds))
            {
                body["openTeamIds"] = request.OpenTeamIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "AddLibrary",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/librarys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLibraryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddLibraryResponse AddLibrary(AddLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLibraryHeaders headers = new AddLibraryHeaders();
            return AddLibraryWithOptions(request, headers, runtime);
        }

        public async Task<AddLibraryResponse> AddLibraryAsync(AddLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddLibraryHeaders headers = new AddLibraryHeaders();
            return await AddLibraryWithOptionsAsync(request, headers, runtime);
        }

        public AddMemberToServiceGroupResponse AddMemberToServiceGroupWithOptions(AddMemberToServiceGroupRequest request, AddMemberToServiceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "AddMemberToServiceGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberToServiceGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddMemberToServiceGroupResponse> AddMemberToServiceGroupWithOptionsAsync(AddMemberToServiceGroupRequest request, AddMemberToServiceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "AddMemberToServiceGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberToServiceGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddMemberToServiceGroupResponse AddMemberToServiceGroup(AddMemberToServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToServiceGroupHeaders headers = new AddMemberToServiceGroupHeaders();
            return AddMemberToServiceGroupWithOptions(request, headers, runtime);
        }

        public async Task<AddMemberToServiceGroupResponse> AddMemberToServiceGroupAsync(AddMemberToServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddMemberToServiceGroupHeaders headers = new AddMemberToServiceGroupHeaders();
            return await AddMemberToServiceGroupWithOptionsAsync(request, headers, runtime);
        }

        public AddOpenCategoryResponse AddOpenCategoryWithOptions(AddOpenCategoryRequest request, AddOpenCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenCategory",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openCategories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenCategoryResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddOpenCategoryResponse> AddOpenCategoryWithOptionsAsync(AddOpenCategoryRequest request, AddOpenCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenCategory",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openCategories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenCategoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddOpenCategoryResponse AddOpenCategory(AddOpenCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenCategoryHeaders headers = new AddOpenCategoryHeaders();
            return AddOpenCategoryWithOptions(request, headers, runtime);
        }

        public async Task<AddOpenCategoryResponse> AddOpenCategoryAsync(AddOpenCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenCategoryHeaders headers = new AddOpenCategoryHeaders();
            return await AddOpenCategoryWithOptionsAsync(request, headers, runtime);
        }

        public AddOpenKnowledgeResponse AddOpenKnowledgeWithOptions(AddOpenKnowledgeRequest request, AddOpenKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                body["attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["categoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimeend))
            {
                body["effectTimeend"] = request.EffectTimeend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimestart))
            {
                body["effectTimestart"] = request.EffectTimestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtTitle))
            {
                body["extTitle"] = request.ExtTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openKnowledges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenKnowledgeResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddOpenKnowledgeResponse> AddOpenKnowledgeWithOptionsAsync(AddOpenKnowledgeRequest request, AddOpenKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                body["attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                body["categoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimeend))
            {
                body["effectTimeend"] = request.EffectTimeend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTimestart))
            {
                body["effectTimestart"] = request.EffectTimestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtTitle))
            {
                body["extTitle"] = request.ExtTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryId))
            {
                body["libraryId"] = request.LibraryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openKnowledges",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddOpenKnowledgeResponse AddOpenKnowledge(AddOpenKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenKnowledgeHeaders headers = new AddOpenKnowledgeHeaders();
            return AddOpenKnowledgeWithOptions(request, headers, runtime);
        }

        public async Task<AddOpenKnowledgeResponse> AddOpenKnowledgeAsync(AddOpenKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenKnowledgeHeaders headers = new AddOpenKnowledgeHeaders();
            return await AddOpenKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        public AddOpenLibraryResponse AddOpenLibraryWithOptions(AddOpenLibraryRequest request, AddOpenLibraryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenLibrary",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openLibraries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenLibraryResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddOpenLibraryResponse> AddOpenLibraryWithOptionsAsync(AddOpenLibraryRequest request, AddOpenLibraryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "AddOpenLibrary",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/openLibraries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOpenLibraryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddOpenLibraryResponse AddOpenLibrary(AddOpenLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenLibraryHeaders headers = new AddOpenLibraryHeaders();
            return AddOpenLibraryWithOptions(request, headers, runtime);
        }

        public async Task<AddOpenLibraryResponse> AddOpenLibraryAsync(AddOpenLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOpenLibraryHeaders headers = new AddOpenLibraryHeaders();
            return await AddOpenLibraryWithOptionsAsync(request, headers, runtime);
        }

        public AddTicketMemoResponse AddTicketMemoWithOptions(AddTicketMemoRequest request, AddTicketMemoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "AddTicketMemo",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/memos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTicketMemoResponse>(Execute(params_, req, runtime));
        }

        public async Task<AddTicketMemoResponse> AddTicketMemoWithOptionsAsync(AddTicketMemoRequest request, AddTicketMemoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "AddTicketMemo",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/memos",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTicketMemoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AddTicketMemoResponse AddTicketMemo(AddTicketMemoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddTicketMemoHeaders headers = new AddTicketMemoHeaders();
            return AddTicketMemoWithOptions(request, headers, runtime);
        }

        public async Task<AddTicketMemoResponse> AddTicketMemoAsync(AddTicketMemoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddTicketMemoHeaders headers = new AddTicketMemoHeaders();
            return await AddTicketMemoWithOptionsAsync(request, headers, runtime);
        }

        public AssignTicketResponse AssignTicketWithOptions(AssignTicketRequest request, AssignTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "AssignTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<AssignTicketResponse> AssignTicketWithOptionsAsync(AssignTicketRequest request, AssignTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "AssignTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public AssignTicketResponse AssignTicket(AssignTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AssignTicketHeaders headers = new AssignTicketHeaders();
            return AssignTicketWithOptions(request, headers, runtime);
        }

        public async Task<AssignTicketResponse> AssignTicketAsync(AssignTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AssignTicketHeaders headers = new AssignTicketHeaders();
            return await AssignTicketWithOptionsAsync(request, headers, runtime);
        }

        public BatchBindingGroupBizIdsResponse BatchBindingGroupBizIdsWithOptions(BatchBindingGroupBizIdsRequest request, BatchBindingGroupBizIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingGroupBizIds))
            {
                body["bindingGroupBizIds"] = request.BindingGroupBizIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchBindingGroupBizIds",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBindingGroupBizIdsResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchBindingGroupBizIdsResponse> BatchBindingGroupBizIdsWithOptionsAsync(BatchBindingGroupBizIdsRequest request, BatchBindingGroupBizIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingGroupBizIds))
            {
                body["bindingGroupBizIds"] = request.BindingGroupBizIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchBindingGroupBizIds",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchBindingGroupBizIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchBindingGroupBizIdsResponse BatchBindingGroupBizIds(BatchBindingGroupBizIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchBindingGroupBizIdsHeaders headers = new BatchBindingGroupBizIdsHeaders();
            return BatchBindingGroupBizIdsWithOptions(request, headers, runtime);
        }

        public async Task<BatchBindingGroupBizIdsResponse> BatchBindingGroupBizIdsAsync(BatchBindingGroupBizIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchBindingGroupBizIdsHeaders headers = new BatchBindingGroupBizIdsHeaders();
            return await BatchBindingGroupBizIdsWithOptionsAsync(request, headers, runtime);
        }

        public BatchGetGroupSetConfigResponse BatchGetGroupSetConfigWithOptions(BatchGetGroupSetConfigRequest request, BatchGetGroupSetConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                body["configKeys"] = request.ConfigKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchGetGroupSetConfig",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSetConfigs/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetGroupSetConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchGetGroupSetConfigResponse> BatchGetGroupSetConfigWithOptionsAsync(BatchGetGroupSetConfigRequest request, BatchGetGroupSetConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                body["configKeys"] = request.ConfigKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchGetGroupSetConfig",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSetConfigs/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetGroupSetConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchGetGroupSetConfigResponse BatchGetGroupSetConfig(BatchGetGroupSetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetGroupSetConfigHeaders headers = new BatchGetGroupSetConfigHeaders();
            return BatchGetGroupSetConfigWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetGroupSetConfigResponse> BatchGetGroupSetConfigAsync(BatchGetGroupSetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchGetGroupSetConfigHeaders headers = new BatchGetGroupSetConfigHeaders();
            return await BatchGetGroupSetConfigWithOptionsAsync(request, headers, runtime);
        }

        public BatchQueryCustomerSendTaskResponse BatchQueryCustomerSendTaskWithOptions(BatchQueryCustomerSendTaskRequest request, BatchQueryCustomerSendTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRichStatistics))
            {
                body["needRichStatistics"] = request.NeedRichStatistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskIds))
            {
                body["openBatchTaskIds"] = request.OpenBatchTaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "BatchQueryCustomerSendTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryCustomerSendTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchQueryCustomerSendTaskResponse> BatchQueryCustomerSendTaskWithOptionsAsync(BatchQueryCustomerSendTaskRequest request, BatchQueryCustomerSendTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRichStatistics))
            {
                body["needRichStatistics"] = request.NeedRichStatistics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskIds))
            {
                body["openBatchTaskIds"] = request.OpenBatchTaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "BatchQueryCustomerSendTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryCustomerSendTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchQueryCustomerSendTaskResponse BatchQueryCustomerSendTask(BatchQueryCustomerSendTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryCustomerSendTaskHeaders headers = new BatchQueryCustomerSendTaskHeaders();
            return BatchQueryCustomerSendTaskWithOptions(request, headers, runtime);
        }

        public async Task<BatchQueryCustomerSendTaskResponse> BatchQueryCustomerSendTaskAsync(BatchQueryCustomerSendTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryCustomerSendTaskHeaders headers = new BatchQueryCustomerSendTaskHeaders();
            return await BatchQueryCustomerSendTaskWithOptionsAsync(request, headers, runtime);
        }

        public BatchQueryGroupMemberResponse BatchQueryGroupMemberWithOptions(BatchQueryGroupMemberRequest request, BatchQueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchQueryGroupMember",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryGroupMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchQueryGroupMemberResponse> BatchQueryGroupMemberWithOptionsAsync(BatchQueryGroupMemberRequest request, BatchQueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "BatchQueryGroupMember",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchQueryGroupMemberResponse BatchQueryGroupMember(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return BatchQueryGroupMemberWithOptions(request, headers, runtime);
        }

        public async Task<BatchQueryGroupMemberResponse> BatchQueryGroupMemberAsync(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return await BatchQueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        public BatchQuerySendMessageTaskResponse BatchQuerySendMessageTaskWithOptions(BatchQuerySendMessageTaskRequest request, BatchQuerySendMessageTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetReadCount))
            {
                body["getReadCount"] = request.GetReadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "BatchQuerySendMessageTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQuerySendMessageTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<BatchQuerySendMessageTaskResponse> BatchQuerySendMessageTaskWithOptionsAsync(BatchQuerySendMessageTaskRequest request, BatchQuerySendMessageTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetReadCount))
            {
                body["getReadCount"] = request.GetReadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateEnd))
            {
                body["gmtCreateEnd"] = request.GmtCreateEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateStart))
            {
                body["gmtCreateStart"] = request.GmtCreateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "BatchQuerySendMessageTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQuerySendMessageTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BatchQuerySendMessageTaskResponse BatchQuerySendMessageTask(BatchQuerySendMessageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQuerySendMessageTaskHeaders headers = new BatchQuerySendMessageTaskHeaders();
            return BatchQuerySendMessageTaskWithOptions(request, headers, runtime);
        }

        public async Task<BatchQuerySendMessageTaskResponse> BatchQuerySendMessageTaskAsync(BatchQuerySendMessageTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQuerySendMessageTaskHeaders headers = new BatchQuerySendMessageTaskHeaders();
            return await BatchQuerySendMessageTaskWithOptionsAsync(request, headers, runtime);
        }

        public BoundTemplateToTeamResponse BoundTemplateToTeamWithOptions(BoundTemplateToTeamRequest request, BoundTemplateToTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotConfig))
            {
                body["robotConfig"] = request.RobotConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["templateType"] = request.TemplateType;
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
                Action = "BoundTemplateToTeam",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/teams/templates/bound",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BoundTemplateToTeamResponse>(Execute(params_, req, runtime));
        }

        public async Task<BoundTemplateToTeamResponse> BoundTemplateToTeamWithOptionsAsync(BoundTemplateToTeamRequest request, BoundTemplateToTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotConfig))
            {
                body["robotConfig"] = request.RobotConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateDesc))
            {
                body["templateDesc"] = request.TemplateDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["templateType"] = request.TemplateType;
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
                Action = "BoundTemplateToTeam",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/teams/templates/bound",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BoundTemplateToTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BoundTemplateToTeamResponse BoundTemplateToTeam(BoundTemplateToTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BoundTemplateToTeamHeaders headers = new BoundTemplateToTeamHeaders();
            return BoundTemplateToTeamWithOptions(request, headers, runtime);
        }

        public async Task<BoundTemplateToTeamResponse> BoundTemplateToTeamAsync(BoundTemplateToTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BoundTemplateToTeamHeaders headers = new BoundTemplateToTeamHeaders();
            return await BoundTemplateToTeamWithOptionsAsync(request, headers, runtime);
        }

        public CancelTicketResponse CancelTicketWithOptions(CancelTicketRequest request, CancelTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "CancelTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<CancelTicketResponse> CancelTicketWithOptionsAsync(CancelTicketRequest request, CancelTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "CancelTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CancelTicketResponse CancelTicket(CancelTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelTicketHeaders headers = new CancelTicketHeaders();
            return CancelTicketWithOptions(request, headers, runtime);
        }

        public async Task<CancelTicketResponse> CancelTicketAsync(CancelTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelTicketHeaders headers = new CancelTicketHeaders();
            return await CancelTicketWithOptionsAsync(request, headers, runtime);
        }

        public CategoryStatisticsResponse CategoryStatisticsWithOptions(CategoryStatisticsRequest request, CategoryStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "CategoryStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/categories/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<CategoryStatisticsResponse> CategoryStatisticsWithOptionsAsync(CategoryStatisticsRequest request, CategoryStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "CategoryStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/categories/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CategoryStatisticsResponse CategoryStatistics(CategoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoryStatisticsHeaders headers = new CategoryStatisticsHeaders();
            return CategoryStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<CategoryStatisticsResponse> CategoryStatisticsAsync(CategoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CategoryStatisticsHeaders headers = new CategoryStatisticsHeaders();
            return await CategoryStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public CloseConversationResponse CloseConversationWithOptions(CloseConversationRequest request, CloseConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerTips))
            {
                body["serverTips"] = request.ServerTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetChannel))
            {
                body["targetChannel"] = request.TargetChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "CloseConversation",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/conversions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseConversationResponse>(Execute(params_, req, runtime));
        }

        public async Task<CloseConversationResponse> CloseConversationWithOptionsAsync(CloseConversationRequest request, CloseConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerTips))
            {
                body["serverTips"] = request.ServerTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetChannel))
            {
                body["targetChannel"] = request.TargetChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "CloseConversation",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/conversions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CloseConversationResponse CloseConversation(CloseConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseConversationHeaders headers = new CloseConversationHeaders();
            return CloseConversationWithOptions(request, headers, runtime);
        }

        public async Task<CloseConversationResponse> CloseConversationAsync(CloseConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseConversationHeaders headers = new CloseConversationHeaders();
            return await CloseConversationWithOptionsAsync(request, headers, runtime);
        }

        public CloseHumanSessionResponse CloseHumanSessionWithOptions(CloseHumanSessionRequest request, CloseHumanSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "CloseHumanSession",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/humanSessions/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseHumanSessionResponse>(Execute(params_, req, runtime));
        }

        public async Task<CloseHumanSessionResponse> CloseHumanSessionWithOptionsAsync(CloseHumanSessionRequest request, CloseHumanSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "CloseHumanSession",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/humanSessions/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseHumanSessionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CloseHumanSessionResponse CloseHumanSession(CloseHumanSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseHumanSessionHeaders headers = new CloseHumanSessionHeaders();
            return CloseHumanSessionWithOptions(request, headers, runtime);
        }

        public async Task<CloseHumanSessionResponse> CloseHumanSessionAsync(CloseHumanSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseHumanSessionHeaders headers = new CloseHumanSessionHeaders();
            return await CloseHumanSessionWithOptionsAsync(request, headers, runtime);
        }

        public ConversationCreatedNotifyResponse ConversationCreatedNotifyWithOptions(ConversationCreatedNotifyRequest request, ConversationCreatedNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayUserId))
            {
                body["alipayUserId"] = request.AlipayUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerName))
            {
                body["serverName"] = request.ServerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerTips))
            {
                body["serverTips"] = request.ServerTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutRemindTips))
            {
                body["timeoutRemindTips"] = request.TimeoutRemindTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "ConversationCreatedNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationCreatedNotifyResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConversationCreatedNotifyResponse> ConversationCreatedNotifyWithOptionsAsync(ConversationCreatedNotifyRequest request, ConversationCreatedNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayUserId))
            {
                body["alipayUserId"] = request.AlipayUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerName))
            {
                body["serverName"] = request.ServerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerTips))
            {
                body["serverTips"] = request.ServerTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutRemindTips))
            {
                body["timeoutRemindTips"] = request.TimeoutRemindTips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "ConversationCreatedNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationCreatedNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ConversationCreatedNotifyResponse ConversationCreatedNotify(ConversationCreatedNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationCreatedNotifyHeaders headers = new ConversationCreatedNotifyHeaders();
            return ConversationCreatedNotifyWithOptions(request, headers, runtime);
        }

        public async Task<ConversationCreatedNotifyResponse> ConversationCreatedNotifyAsync(ConversationCreatedNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationCreatedNotifyHeaders headers = new ConversationCreatedNotifyHeaders();
            return await ConversationCreatedNotifyWithOptionsAsync(request, headers, runtime);
        }

        public ConversationTransferBeginNotifyResponse ConversationTransferBeginNotifyWithOptions(ConversationTransferBeginNotifyRequest request, ConversationTransferBeginNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSkillGroupId))
            {
                body["sourceSkillGroupId"] = request.SourceSkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSkillGroupId))
            {
                body["targetSkillGroupId"] = request.TargetSkillGroupId;
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
                Action = "ConversationTransferBeginNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/transfers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationTransferBeginNotifyResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConversationTransferBeginNotifyResponse> ConversationTransferBeginNotifyWithOptionsAsync(ConversationTransferBeginNotifyRequest request, ConversationTransferBeginNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memo))
            {
                body["memo"] = request.Memo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSkillGroupId))
            {
                body["sourceSkillGroupId"] = request.SourceSkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSkillGroupId))
            {
                body["targetSkillGroupId"] = request.TargetSkillGroupId;
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
                Action = "ConversationTransferBeginNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/transfers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationTransferBeginNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ConversationTransferBeginNotifyResponse ConversationTransferBeginNotify(ConversationTransferBeginNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationTransferBeginNotifyHeaders headers = new ConversationTransferBeginNotifyHeaders();
            return ConversationTransferBeginNotifyWithOptions(request, headers, runtime);
        }

        public async Task<ConversationTransferBeginNotifyResponse> ConversationTransferBeginNotifyAsync(ConversationTransferBeginNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationTransferBeginNotifyHeaders headers = new ConversationTransferBeginNotifyHeaders();
            return await ConversationTransferBeginNotifyWithOptionsAsync(request, headers, runtime);
        }

        public ConversationTransferCompleteNotifyResponse ConversationTransferCompleteNotifyWithOptions(ConversationTransferCompleteNotifyRequest request, ConversationTransferCompleteNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayUserId))
            {
                body["alipayUserId"] = request.AlipayUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "ConversationTransferCompleteNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/completes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationTransferCompleteNotifyResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConversationTransferCompleteNotifyResponse> ConversationTransferCompleteNotifyWithOptionsAsync(ConversationTransferCompleteNotifyRequest request, ConversationTransferCompleteNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlipayUserId))
            {
                body["alipayUserId"] = request.AlipayUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                body["nickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "ConversationTransferCompleteNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/completes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversationTransferCompleteNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ConversationTransferCompleteNotifyResponse ConversationTransferCompleteNotify(ConversationTransferCompleteNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationTransferCompleteNotifyHeaders headers = new ConversationTransferCompleteNotifyHeaders();
            return ConversationTransferCompleteNotifyWithOptions(request, headers, runtime);
        }

        public async Task<ConversationTransferCompleteNotifyResponse> ConversationTransferCompleteNotifyAsync(ConversationTransferCompleteNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConversationTransferCompleteNotifyHeaders headers = new ConversationTransferCompleteNotifyHeaders();
            return await ConversationTransferCompleteNotifyWithOptionsAsync(request, headers, runtime);
        }

        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBizId))
            {
                body["groupBizId"] = request.GroupBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTagNames))
            {
                body["groupTagNames"] = request.GroupTagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberStaffIds))
            {
                body["memberStaffIds"] = request.MemberStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerStaffId))
            {
                body["ownerStaffId"] = request.OwnerStaffId;
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
                Action = "CreateGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBizId))
            {
                body["groupBizId"] = request.GroupBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTagNames))
            {
                body["groupTagNames"] = request.GroupTagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberStaffIds))
            {
                body["memberStaffIds"] = request.MemberStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerStaffId))
            {
                body["ownerStaffId"] = request.OwnerStaffId;
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
                Action = "CreateGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return CreateGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return await CreateGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateGroupConversationResponse CreateGroupConversationWithOptions(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                body["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserName))
            {
                body["dingUserName"] = request.DingUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtValues))
            {
                body["extValues"] = request.ExtValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["serverGroupId"] = request.ServerGroupId;
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
                Action = "CreateGroupConversation",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/create/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupConversationResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateGroupConversationResponse> CreateGroupConversationWithOptionsAsync(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingGroupId))
            {
                body["dingGroupId"] = request.DingGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserName))
            {
                body["dingUserName"] = request.DingUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtValues))
            {
                body["extValues"] = request.ExtValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerGroupId))
            {
                body["serverGroupId"] = request.ServerGroupId;
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
                Action = "CreateGroupConversation",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/create/conversations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateGroupConversationResponse CreateGroupConversation(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return CreateGroupConversationWithOptions(request, headers, runtime);
        }

        public async Task<CreateGroupConversationResponse> CreateGroupConversationAsync(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return await CreateGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        public CreateGroupSetResponse CreateGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSetName))
            {
                body["groupSetName"] = request.GroupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "CreateGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateGroupSetResponse> CreateGroupSetWithOptionsAsync(CreateGroupSetRequest request, CreateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSetName))
            {
                body["groupSetName"] = request.GroupSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "CreateGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateGroupSetResponse CreateGroupSet(CreateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
            return CreateGroupSetWithOptions(request, headers, runtime);
        }

        public async Task<CreateGroupSetResponse> CreateGroupSetAsync(CreateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
            return await CreateGroupSetWithOptionsAsync(request, headers, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, CreateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalBizId))
            {
                body["externalBizId"] = request.ExternalBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "CreateInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, CreateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalBizId))
            {
                body["externalBizId"] = request.ExternalBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "CreateInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInstanceHeaders headers = new CreateInstanceHeaders();
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInstanceHeaders headers = new CreateInstanceHeaders();
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateTeamResponse CreateTeamWithOptions(CreateTeamRequest request, CreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorDingUnionId))
            {
                body["creatorDingUnionId"] = request.CreatorDingUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamName))
            {
                body["teamName"] = request.TeamName;
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
                Action = "CreateTeam",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateTeamResponse> CreateTeamWithOptionsAsync(CreateTeamRequest request, CreateTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorDingUnionId))
            {
                body["creatorDingUnionId"] = request.CreatorDingUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamName))
            {
                body["teamName"] = request.TeamName;
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
                Action = "CreateTeam",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/teams",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateTeamResponse CreateTeam(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTeamHeaders headers = new CreateTeamHeaders();
            return CreateTeamWithOptions(request, headers, runtime);
        }

        public async Task<CreateTeamResponse> CreateTeamAsync(CreateTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTeamHeaders headers = new CreateTeamHeaders();
            return await CreateTeamWithOptionsAsync(request, headers, runtime);
        }

        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTemplateBizId))
            {
                body["openTemplateBizId"] = request.OpenTemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, CreateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTemplateBizId))
            {
                body["openTemplateBizId"] = request.OpenTemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return CreateTicketWithOptions(request, headers, runtime);
        }

        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTicketHeaders headers = new CreateTicketHeaders();
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        public CustomerSendMsgTaskResponse CustomerSendMsgTaskWithOptions(CustomerSendMsgTaskRequest request, CustomerSendMsgTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCustomer))
            {
                body["queryCustomer"] = request.QueryCustomer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig))
            {
                body["sendConfig"] = request.SendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "CustomerSendMsgTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSendMsgTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomerSendMsgTaskResponse> CustomerSendMsgTaskWithOptionsAsync(CustomerSendMsgTaskRequest request, CustomerSendMsgTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCustomer))
            {
                body["queryCustomer"] = request.QueryCustomer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig))
            {
                body["sendConfig"] = request.SendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "CustomerSendMsgTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomerSendMsgTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomerSendMsgTaskResponse CustomerSendMsgTask(CustomerSendMsgTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomerSendMsgTaskHeaders headers = new CustomerSendMsgTaskHeaders();
            return CustomerSendMsgTaskWithOptions(request, headers, runtime);
        }

        public async Task<CustomerSendMsgTaskResponse> CustomerSendMsgTaskAsync(CustomerSendMsgTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomerSendMsgTaskHeaders headers = new CustomerSendMsgTaskHeaders();
            return await CustomerSendMsgTaskWithOptionsAsync(request, headers, runtime);
        }

        public DeleteGroupMembersFromGroupResponse DeleteGroupMembersFromGroupWithOptions(DeleteGroupMembersFromGroupRequest request, DeleteGroupMembersFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteGroupType))
            {
                body["deleteGroupType"] = request.DeleteGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUnionId))
            {
                body["memberUnionId"] = request.MemberUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "DeleteGroupMembersFromGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMembersFromGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteGroupMembersFromGroupResponse> DeleteGroupMembersFromGroupWithOptionsAsync(DeleteGroupMembersFromGroupRequest request, DeleteGroupMembersFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteGroupType))
            {
                body["deleteGroupType"] = request.DeleteGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUnionId))
            {
                body["memberUnionId"] = request.MemberUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "DeleteGroupMembersFromGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMembersFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteGroupMembersFromGroupResponse DeleteGroupMembersFromGroup(DeleteGroupMembersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupMembersFromGroupHeaders headers = new DeleteGroupMembersFromGroupHeaders();
            return DeleteGroupMembersFromGroupWithOptions(request, headers, runtime);
        }

        public async Task<DeleteGroupMembersFromGroupResponse> DeleteGroupMembersFromGroupAsync(DeleteGroupMembersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupMembersFromGroupHeaders headers = new DeleteGroupMembersFromGroupHeaders();
            return await DeleteGroupMembersFromGroupWithOptionsAsync(request, headers, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, DeleteInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceId))
            {
                body["openDataInstanceId"] = request.OpenDataInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
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
                Action = "DeleteInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, DeleteInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceId))
            {
                body["openDataInstanceId"] = request.OpenDataInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
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
                Action = "DeleteInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
            return DeleteInstanceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
            return await DeleteInstanceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteKnowledgeResponse DeleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryKey))
            {
                body["libraryKey"] = request.LibraryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
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
                Action = "DeleteKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/knowledges/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeWithOptionsAsync(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibraryKey))
            {
                body["libraryKey"] = request.LibraryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrimaryKey))
            {
                body["sourcePrimaryKey"] = request.SourcePrimaryKey;
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
                Action = "DeleteKnowledge",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/knowledges/batchDelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteKnowledgeResponse DeleteKnowledge(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
            return DeleteKnowledgeWithOptions(request, headers, runtime);
        }

        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeAsync(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
            return await DeleteKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        public EmotionStatisticsResponse EmotionStatisticsWithOptions(EmotionStatisticsRequest request, EmotionStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEmotion))
            {
                query["maxEmotion"] = request.MaxEmotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinEmotion))
            {
                query["minEmotion"] = request.MinEmotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                query["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                query["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "EmotionStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/emotions/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmotionStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<EmotionStatisticsResponse> EmotionStatisticsWithOptionsAsync(EmotionStatisticsRequest request, EmotionStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEmotion))
            {
                query["maxEmotion"] = request.MaxEmotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinEmotion))
            {
                query["minEmotion"] = request.MinEmotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                query["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                query["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "EmotionStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/emotions/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmotionStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public EmotionStatisticsResponse EmotionStatistics(EmotionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EmotionStatisticsHeaders headers = new EmotionStatisticsHeaders();
            return EmotionStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<EmotionStatisticsResponse> EmotionStatisticsAsync(EmotionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EmotionStatisticsHeaders headers = new EmotionStatisticsHeaders();
            return await EmotionStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public FinishTicketResponse FinishTicketWithOptions(FinishTicketRequest request, FinishTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "FinishTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<FinishTicketResponse> FinishTicketWithOptionsAsync(FinishTicketRequest request, FinishTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "FinishTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public FinishTicketResponse FinishTicket(FinishTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishTicketHeaders headers = new FinishTicketHeaders();
            return FinishTicketWithOptions(request, headers, runtime);
        }

        public async Task<FinishTicketResponse> FinishTicketAsync(FinishTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishTicketHeaders headers = new FinishTicketHeaders();
            return await FinishTicketWithOptionsAsync(request, headers, runtime);
        }

        public GetAuthTokenResponse GetAuthTokenWithOptions(GetAuthTokenRequest request, GetAuthTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                body["serverId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerName))
            {
                body["serverName"] = request.ServerName;
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
                Action = "GetAuthToken",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/get/tokens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetAuthTokenResponse> GetAuthTokenWithOptionsAsync(GetAuthTokenRequest request, GetAuthTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                body["effectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                body["serverId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerName))
            {
                body["serverName"] = request.ServerName;
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
                Action = "GetAuthToken",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/get/tokens",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetAuthTokenResponse GetAuthToken(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthTokenHeaders headers = new GetAuthTokenHeaders();
            return GetAuthTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetAuthTokenResponse> GetAuthTokenAsync(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthTokenHeaders headers = new GetAuthTokenHeaders();
            return await GetAuthTokenWithOptionsAsync(request, headers, runtime);
        }

        public GetInstancesByIdsResponse GetInstancesByIdsWithOptions(GetInstancesByIdsRequest request, GetInstancesByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceIdList))
            {
                body["openDataInstanceIdList"] = request.OpenDataInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "GetInstancesByIds",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesByIdsResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetInstancesByIdsResponse> GetInstancesByIdsWithOptionsAsync(GetInstancesByIdsRequest request, GetInstancesByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceIdList))
            {
                body["openDataInstanceIdList"] = request.OpenDataInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "GetInstancesByIds",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstancesByIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetInstancesByIdsResponse GetInstancesByIds(GetInstancesByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesByIdsHeaders headers = new GetInstancesByIdsHeaders();
            return GetInstancesByIdsWithOptions(request, headers, runtime);
        }

        public async Task<GetInstancesByIdsResponse> GetInstancesByIdsAsync(GetInstancesByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInstancesByIdsHeaders headers = new GetInstancesByIdsHeaders();
            return await GetInstancesByIdsWithOptionsAsync(request, headers, runtime);
        }

        public GetNegativeWordCloudResponse GetNegativeWordCloudWithOptions(GetNegativeWordCloudRequest request, GetNegativeWordCloudHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetNegativeWordCloud",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/negatives/wordClouds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNegativeWordCloudResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetNegativeWordCloudResponse> GetNegativeWordCloudWithOptionsAsync(GetNegativeWordCloudRequest request, GetNegativeWordCloudHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetNegativeWordCloud",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/negatives/wordClouds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNegativeWordCloudResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetNegativeWordCloudResponse GetNegativeWordCloud(GetNegativeWordCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNegativeWordCloudHeaders headers = new GetNegativeWordCloudHeaders();
            return GetNegativeWordCloudWithOptions(request, headers, runtime);
        }

        public async Task<GetNegativeWordCloudResponse> GetNegativeWordCloudAsync(GetNegativeWordCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNegativeWordCloudHeaders headers = new GetNegativeWordCloudHeaders();
            return await GetNegativeWordCloudWithOptionsAsync(request, headers, runtime);
        }

        public GetOssTempUrlResponse GetOssTempUrlWithOptions(GetOssTempUrlRequest request, GetOssTempUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchMode))
            {
                query["fetchMode"] = request.FetchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetOssTempUrl",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/ossServices/tempUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssTempUrlResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetOssTempUrlResponse> GetOssTempUrlWithOptionsAsync(GetOssTempUrlRequest request, GetOssTempUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchMode))
            {
                query["fetchMode"] = request.FetchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetOssTempUrl",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/ossServices/tempUrls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssTempUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetOssTempUrlResponse GetOssTempUrl(GetOssTempUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOssTempUrlHeaders headers = new GetOssTempUrlHeaders();
            return GetOssTempUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetOssTempUrlResponse> GetOssTempUrlAsync(GetOssTempUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOssTempUrlHeaders headers = new GetOssTempUrlHeaders();
            return await GetOssTempUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetStoragePolicyResponse GetStoragePolicyWithOptions(GetStoragePolicyRequest request, GetStoragePolicyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "GetStoragePolicy",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/ossServices/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoragePolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetStoragePolicyResponse> GetStoragePolicyWithOptionsAsync(GetStoragePolicyRequest request, GetStoragePolicyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "GetStoragePolicy",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/ossServices/policies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoragePolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetStoragePolicyResponse GetStoragePolicy(GetStoragePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStoragePolicyHeaders headers = new GetStoragePolicyHeaders();
            return GetStoragePolicyWithOptions(request, headers, runtime);
        }

        public async Task<GetStoragePolicyResponse> GetStoragePolicyAsync(GetStoragePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetStoragePolicyHeaders headers = new GetStoragePolicyHeaders();
            return await GetStoragePolicyWithOptionsAsync(request, headers, runtime);
        }

        public GetTicketResponse GetTicketWithOptions(GetTicketRequest request, GetTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                query["openTicketId"] = request.OpenTicketId;
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
                Action = "GetTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetTicketResponse> GetTicketWithOptionsAsync(GetTicketRequest request, GetTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                query["openTicketId"] = request.OpenTicketId;
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
                Action = "GetTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetTicketResponse GetTicket(GetTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTicketHeaders headers = new GetTicketHeaders();
            return GetTicketWithOptions(request, headers, runtime);
        }

        public async Task<GetTicketResponse> GetTicketAsync(GetTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTicketHeaders headers = new GetTicketHeaders();
            return await GetTicketWithOptionsAsync(request, headers, runtime);
        }

        public GetWordCloudResponse GetWordCloudWithOptions(GetWordCloudRequest request, GetWordCloudHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetWordCloud",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/wordClouds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWordCloudResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetWordCloudResponse> GetWordCloudWithOptionsAsync(GetWordCloudRequest request, GetWordCloudHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GetWordCloud",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/wordClouds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWordCloudResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetWordCloudResponse GetWordCloud(GetWordCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWordCloudHeaders headers = new GetWordCloudHeaders();
            return GetWordCloudWithOptions(request, headers, runtime);
        }

        public async Task<GetWordCloudResponse> GetWordCloudAsync(GetWordCloudRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWordCloudHeaders headers = new GetWordCloudHeaders();
            return await GetWordCloudWithOptionsAsync(request, headers, runtime);
        }

        public GroupStatisticsResponse GroupStatisticsWithOptions(GroupStatisticsRequest request, GroupStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GroupStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/groups/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<GroupStatisticsResponse> GroupStatisticsWithOptionsAsync(GroupStatisticsRequest request, GroupStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "GroupStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/groups/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GroupStatisticsResponse GroupStatistics(GroupStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupStatisticsHeaders headers = new GroupStatisticsHeaders();
            return GroupStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GroupStatisticsResponse> GroupStatisticsAsync(GroupStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupStatisticsHeaders headers = new GroupStatisticsHeaders();
            return await GroupStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public IntentionCategoryStatisticsResponse IntentionCategoryStatisticsWithOptions(IntentionCategoryStatisticsRequest request, IntentionCategoryStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "IntentionCategoryStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntentionCategoryStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<IntentionCategoryStatisticsResponse> IntentionCategoryStatisticsWithOptionsAsync(IntentionCategoryStatisticsRequest request, IntentionCategoryStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "IntentionCategoryStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntentionCategoryStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IntentionCategoryStatisticsResponse IntentionCategoryStatistics(IntentionCategoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntentionCategoryStatisticsHeaders headers = new IntentionCategoryStatisticsHeaders();
            return IntentionCategoryStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<IntentionCategoryStatisticsResponse> IntentionCategoryStatisticsAsync(IntentionCategoryStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntentionCategoryStatisticsHeaders headers = new IntentionCategoryStatisticsHeaders();
            return await IntentionCategoryStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public IntentionStatisticsResponse IntentionStatisticsWithOptions(IntentionStatisticsRequest request, IntentionStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "IntentionStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/intentions/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntentionStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<IntentionStatisticsResponse> IntentionStatisticsWithOptionsAsync(IntentionStatisticsRequest request, IntentionStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "IntentionStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/dashboards/intentions/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IntentionStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IntentionStatisticsResponse IntentionStatistics(IntentionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntentionStatisticsHeaders headers = new IntentionStatisticsHeaders();
            return IntentionStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<IntentionStatisticsResponse> IntentionStatisticsAsync(IntentionStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IntentionStatisticsHeaders headers = new IntentionStatisticsHeaders();
            return await IntentionStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public ListTicketOperateRecordResponse ListTicketOperateRecordWithOptions(ListTicketOperateRecordRequest request, ListTicketOperateRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                query["openTicketId"] = request.OpenTicketId;
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
                Action = "ListTicketOperateRecord",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/operateRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketOperateRecordResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListTicketOperateRecordResponse> ListTicketOperateRecordWithOptionsAsync(ListTicketOperateRecordRequest request, ListTicketOperateRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                query["openTicketId"] = request.OpenTicketId;
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
                Action = "ListTicketOperateRecord",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/operateRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketOperateRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListTicketOperateRecordResponse ListTicketOperateRecord(ListTicketOperateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketOperateRecordHeaders headers = new ListTicketOperateRecordHeaders();
            return ListTicketOperateRecordWithOptions(request, headers, runtime);
        }

        public async Task<ListTicketOperateRecordResponse> ListTicketOperateRecordAsync(ListTicketOperateRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListTicketOperateRecordHeaders headers = new ListTicketOperateRecordHeaders();
            return await ListTicketOperateRecordWithOptionsAsync(request, headers, runtime);
        }

        public ListUserTeamsResponse ListUserTeamsWithOptions(string userId, ListUserTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserTeams",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/users/" + userId + "/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserTeamsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListUserTeamsResponse> ListUserTeamsWithOptionsAsync(string userId, ListUserTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListUserTeams",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/users/" + userId + "/teams",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserTeamsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListUserTeamsResponse ListUserTeams(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
            return ListUserTeamsWithOptions(userId, headers, runtime);
        }

        public async Task<ListUserTeamsResponse> ListUserTeamsAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
            return await ListUserTeamsWithOptionsAsync(userId, headers, runtime);
        }

        public QueryActiveUsersResponse QueryActiveUsersWithOptions(QueryActiveUsersRequest request, QueryActiveUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["topN"] = request.TopN;
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
                Action = "QueryActiveUsers",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/queryActiveUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActiveUsersResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryActiveUsersResponse> QueryActiveUsersWithOptionsAsync(QueryActiveUsersRequest request, QueryActiveUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["topN"] = request.TopN;
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
                Action = "QueryActiveUsers",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/queryActiveUsers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryActiveUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryActiveUsersResponse QueryActiveUsers(QueryActiveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUsersHeaders headers = new QueryActiveUsersHeaders();
            return QueryActiveUsersWithOptions(request, headers, runtime);
        }

        public async Task<QueryActiveUsersResponse> QueryActiveUsersAsync(QueryActiveUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUsersHeaders headers = new QueryActiveUsersHeaders();
            return await QueryActiveUsersWithOptionsAsync(request, headers, runtime);
        }

        public QueryCrmGroupContactResponse QueryCrmGroupContactWithOptions(QueryCrmGroupContactRequest request, QueryCrmGroupContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinResult))
            {
                body["minResult"] = request.MinResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFields))
            {
                body["searchFields"] = request.SearchFields;
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
                Action = "QueryCrmGroupContact",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/contacts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmGroupContactResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCrmGroupContactResponse> QueryCrmGroupContactWithOptionsAsync(QueryCrmGroupContactRequest request, QueryCrmGroupContactHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinResult))
            {
                body["minResult"] = request.MinResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFields))
            {
                body["searchFields"] = request.SearchFields;
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
                Action = "QueryCrmGroupContact",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/contacts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCrmGroupContactResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCrmGroupContactResponse QueryCrmGroupContact(QueryCrmGroupContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmGroupContactHeaders headers = new QueryCrmGroupContactHeaders();
            return QueryCrmGroupContactWithOptions(request, headers, runtime);
        }

        public async Task<QueryCrmGroupContactResponse> QueryCrmGroupContactAsync(QueryCrmGroupContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCrmGroupContactHeaders headers = new QueryCrmGroupContactHeaders();
            return await QueryCrmGroupContactWithOptionsAsync(request, headers, runtime);
        }

        public QueryCustomerCardResponse QueryCustomerCardWithOptions(QueryCustomerCardRequest request, QueryCustomerCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonParams))
            {
                body["jsonParams"] = request.JsonParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryCustomerCard",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/userDetials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerCardResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCustomerCardResponse> QueryCustomerCardWithOptionsAsync(QueryCustomerCardRequest request, QueryCustomerCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonParams))
            {
                body["jsonParams"] = request.JsonParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryCustomerCard",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/userDetials",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCustomerCardResponse QueryCustomerCard(QueryCustomerCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerCardHeaders headers = new QueryCustomerCardHeaders();
            return QueryCustomerCardWithOptions(request, headers, runtime);
        }

        public async Task<QueryCustomerCardResponse> QueryCustomerCardAsync(QueryCustomerCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerCardHeaders headers = new QueryCustomerCardHeaders();
            return await QueryCustomerCardWithOptionsAsync(request, headers, runtime);
        }

        public QueryCustomerTaskUserDetailResponse QueryCustomerTaskUserDetailWithOptions(QueryCustomerTaskUserDetailRequest request, QueryCustomerTaskUserDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
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
                Action = "QueryCustomerTaskUserDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerTaskUserDetailResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryCustomerTaskUserDetailResponse> QueryCustomerTaskUserDetailWithOptionsAsync(QueryCustomerTaskUserDetailRequest request, QueryCustomerTaskUserDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
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
                Action = "QueryCustomerTaskUserDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerTaskUserDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryCustomerTaskUserDetailResponse QueryCustomerTaskUserDetail(QueryCustomerTaskUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerTaskUserDetailHeaders headers = new QueryCustomerTaskUserDetailHeaders();
            return QueryCustomerTaskUserDetailWithOptions(request, headers, runtime);
        }

        public async Task<QueryCustomerTaskUserDetailResponse> QueryCustomerTaskUserDetailAsync(QueryCustomerTaskUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerTaskUserDetailHeaders headers = new QueryCustomerTaskUserDetailHeaders();
            return await QueryCustomerTaskUserDetailWithOptionsAsync(request, headers, runtime);
        }

        public QueryGroupResponse QueryGroupWithOptions(QueryGroupRequest request, QueryGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryGroupResponse> QueryGroupWithOptionsAsync(QueryGroupRequest request, QueryGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryGroupResponse QueryGroup(QueryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupHeaders headers = new QueryGroupHeaders();
            return QueryGroupWithOptions(request, headers, runtime);
        }

        public async Task<QueryGroupResponse> QueryGroupAsync(QueryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupHeaders headers = new QueryGroupHeaders();
            return await QueryGroupWithOptionsAsync(request, headers, runtime);
        }

        public QueryGroupMemberResponse QueryGroupMemberWithOptions(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
                Action = "QueryGroupMember",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryGroupMemberResponse> QueryGroupMemberWithOptionsAsync(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
                Action = "QueryGroupMember",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryGroupMemberResponse QueryGroupMember(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return QueryGroupMemberWithOptions(request, headers, runtime);
        }

        public async Task<QueryGroupMemberResponse> QueryGroupMemberAsync(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return await QueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        public QueryGroupSetResponse QueryGroupSetWithOptions(QueryGroupSetRequest request, QueryGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryGroupSetResponse> QueryGroupSetWithOptionsAsync(QueryGroupSetRequest request, QueryGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groupSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryGroupSetResponse QueryGroupSet(QueryGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupSetHeaders headers = new QueryGroupSetHeaders();
            return QueryGroupSetWithOptions(request, headers, runtime);
        }

        public async Task<QueryGroupSetResponse> QueryGroupSetAsync(QueryGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupSetHeaders headers = new QueryGroupSetHeaders();
            return await QueryGroupSetWithOptionsAsync(request, headers, runtime);
        }

        public QueryInstancesByMultiConditionsResponse QueryInstancesByMultiConditionsWithOptions(QueryInstancesByMultiConditionsRequest request, QueryInstancesByMultiConditionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFields))
            {
                body["searchFields"] = request.SearchFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFields))
            {
                body["sortFields"] = request.SortFields;
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
                Action = "QueryInstancesByMultiConditions",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstancesByMultiConditionsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryInstancesByMultiConditionsResponse> QueryInstancesByMultiConditionsWithOptionsAsync(QueryInstancesByMultiConditionsRequest request, QueryInstancesByMultiConditionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchFields))
            {
                body["searchFields"] = request.SearchFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFields))
            {
                body["sortFields"] = request.SortFields;
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
                Action = "QueryInstancesByMultiConditions",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstancesByMultiConditionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryInstancesByMultiConditionsResponse QueryInstancesByMultiConditions(QueryInstancesByMultiConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancesByMultiConditionsHeaders headers = new QueryInstancesByMultiConditionsHeaders();
            return QueryInstancesByMultiConditionsWithOptions(request, headers, runtime);
        }

        public async Task<QueryInstancesByMultiConditionsResponse> QueryInstancesByMultiConditionsAsync(QueryInstancesByMultiConditionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancesByMultiConditionsHeaders headers = new QueryInstancesByMultiConditionsHeaders();
            return await QueryInstancesByMultiConditionsWithOptionsAsync(request, headers, runtime);
        }

        public QuerySendMsgTaskStatisticsResponse QuerySendMsgTaskStatisticsWithOptions(QuerySendMsgTaskStatisticsRequest request, QuerySendMsgTaskStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QuerySendMsgTaskStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QuerySendMsgTaskStatisticsResponse> QuerySendMsgTaskStatisticsWithOptionsAsync(QuerySendMsgTaskStatisticsRequest request, QuerySendMsgTaskStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QuerySendMsgTaskStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QuerySendMsgTaskStatisticsResponse QuerySendMsgTaskStatistics(QuerySendMsgTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySendMsgTaskStatisticsHeaders headers = new QuerySendMsgTaskStatisticsHeaders();
            return QuerySendMsgTaskStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<QuerySendMsgTaskStatisticsResponse> QuerySendMsgTaskStatisticsAsync(QuerySendMsgTaskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySendMsgTaskStatisticsHeaders headers = new QuerySendMsgTaskStatisticsHeaders();
            return await QuerySendMsgTaskStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public QuerySendMsgTaskStatisticsDetailResponse QuerySendMsgTaskStatisticsDetailWithOptions(QuerySendMsgTaskStatisticsDetailRequest request, QuerySendMsgTaskStatisticsDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QuerySendMsgTaskStatisticsDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/statistics/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsDetailResponse>(Execute(params_, req, runtime));
        }

        public async Task<QuerySendMsgTaskStatisticsDetailResponse> QuerySendMsgTaskStatisticsDetailWithOptionsAsync(QuerySendMsgTaskStatisticsDetailRequest request, QuerySendMsgTaskStatisticsDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenBatchTaskId))
            {
                body["openBatchTaskId"] = request.OpenBatchTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QuerySendMsgTaskStatisticsDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tasks/statistics/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QuerySendMsgTaskStatisticsDetailResponse QuerySendMsgTaskStatisticsDetail(QuerySendMsgTaskStatisticsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySendMsgTaskStatisticsDetailHeaders headers = new QuerySendMsgTaskStatisticsDetailHeaders();
            return QuerySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
        }

        public async Task<QuerySendMsgTaskStatisticsDetailResponse> QuerySendMsgTaskStatisticsDetailAsync(QuerySendMsgTaskStatisticsDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySendMsgTaskStatisticsDetailHeaders headers = new QuerySendMsgTaskStatisticsDetailHeaders();
            return await QuerySendMsgTaskStatisticsDetailWithOptionsAsync(request, headers, runtime);
        }

        public QueryServiceGroupMessageReadStatusResponse QueryServiceGroupMessageReadStatusWithOptions(QueryServiceGroupMessageReadStatusRequest request, QueryServiceGroupMessageReadStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgTaskId))
            {
                body["openMsgTaskId"] = request.OpenMsgTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryServiceGroupMessageReadStatus",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/readStatus/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServiceGroupMessageReadStatusResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryServiceGroupMessageReadStatusResponse> QueryServiceGroupMessageReadStatusWithOptionsAsync(QueryServiceGroupMessageReadStatusRequest request, QueryServiceGroupMessageReadStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgTaskId))
            {
                body["openMsgTaskId"] = request.OpenMsgTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "QueryServiceGroupMessageReadStatus",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/readStatus/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServiceGroupMessageReadStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryServiceGroupMessageReadStatusResponse QueryServiceGroupMessageReadStatus(QueryServiceGroupMessageReadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
            return QueryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
        }

        public async Task<QueryServiceGroupMessageReadStatusResponse> QueryServiceGroupMessageReadStatusAsync(QueryServiceGroupMessageReadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
            return await QueryServiceGroupMessageReadStatusWithOptionsAsync(request, headers, runtime);
        }

        public QueueNotifyResponse QueueNotifyWithOptions(QueueNotifyRequest request, QueueNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimateWaitMin))
            {
                body["estimateWaitMin"] = request.EstimateWaitMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuePlace))
            {
                body["queuePlace"] = request.QueuePlace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetChannel))
            {
                body["targetChannel"] = request.TargetChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                body["tips"] = request.Tips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "QueueNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/dts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueueNotifyResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueueNotifyResponse> QueueNotifyWithOptionsAsync(QueueNotifyRequest request, QueueNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EstimateWaitMin))
            {
                body["estimateWaitMin"] = request.EstimateWaitMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuePlace))
            {
                body["queuePlace"] = request.QueuePlace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceToken))
            {
                body["serviceToken"] = request.ServiceToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetChannel))
            {
                body["targetChannel"] = request.TargetChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                body["tips"] = request.Tips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisitorToken))
            {
                body["visitorToken"] = request.VisitorToken;
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
                Action = "QueueNotify",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/dts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueueNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueueNotifyResponse QueueNotify(QueueNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueueNotifyHeaders headers = new QueueNotifyHeaders();
            return QueueNotifyWithOptions(request, headers, runtime);
        }

        public async Task<QueueNotifyResponse> QueueNotifyAsync(QueueNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueueNotifyHeaders headers = new QueueNotifyHeaders();
            return await QueueNotifyWithOptionsAsync(request, headers, runtime);
        }

        public RemoveContactFromOrgResponse RemoveContactFromOrgWithOptions(RemoveContactFromOrgRequest request, RemoveContactFromOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactUnionId))
            {
                body["contactUnionId"] = request.ContactUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "RemoveContactFromOrg",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/organizations/contacts/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveContactFromOrgResponse>(Execute(params_, req, runtime));
        }

        public async Task<RemoveContactFromOrgResponse> RemoveContactFromOrgWithOptionsAsync(RemoveContactFromOrgRequest request, RemoveContactFromOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactUnionId))
            {
                body["contactUnionId"] = request.ContactUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "RemoveContactFromOrg",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/organizations/contacts/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveContactFromOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RemoveContactFromOrgResponse RemoveContactFromOrg(RemoveContactFromOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveContactFromOrgHeaders headers = new RemoveContactFromOrgHeaders();
            return RemoveContactFromOrgWithOptions(request, headers, runtime);
        }

        public async Task<RemoveContactFromOrgResponse> RemoveContactFromOrgAsync(RemoveContactFromOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveContactFromOrgHeaders headers = new RemoveContactFromOrgHeaders();
            return await RemoveContactFromOrgWithOptionsAsync(request, headers, runtime);
        }

        public ReportCustomerDetailResponse ReportCustomerDetailWithOptions(ReportCustomerDetailRequest request, ReportCustomerDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasLogin))
            {
                body["hasLogin"] = request.HasLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasOpenConv))
            {
                body["hasOpenConv"] = request.HasOpenConv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                body["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                body["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ReportCustomerDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/activities/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerDetailResponse>(Execute(params_, req, runtime));
        }

        public async Task<ReportCustomerDetailResponse> ReportCustomerDetailWithOptionsAsync(ReportCustomerDetailRequest request, ReportCustomerDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasLogin))
            {
                body["hasLogin"] = request.HasLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasOpenConv))
            {
                body["hasOpenConv"] = request.HasOpenConv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                body["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                body["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ReportCustomerDetail",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/activities/details/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ReportCustomerDetailResponse ReportCustomerDetail(ReportCustomerDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportCustomerDetailHeaders headers = new ReportCustomerDetailHeaders();
            return ReportCustomerDetailWithOptions(request, headers, runtime);
        }

        public async Task<ReportCustomerDetailResponse> ReportCustomerDetailAsync(ReportCustomerDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportCustomerDetailHeaders headers = new ReportCustomerDetailHeaders();
            return await ReportCustomerDetailWithOptionsAsync(request, headers, runtime);
        }

        public ReportCustomerStatisticsResponse ReportCustomerStatisticsWithOptions(ReportCustomerStatisticsRequest request, ReportCustomerStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerUserIds))
            {
                body["groupOwnerUserIds"] = request.GroupOwnerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTags))
            {
                body["groupTags"] = request.GroupTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                body["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                body["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ReportCustomerStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/activities/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ReportCustomerStatisticsResponse> ReportCustomerStatisticsWithOptionsAsync(ReportCustomerStatisticsRequest request, ReportCustomerStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerUserIds))
            {
                body["groupOwnerUserIds"] = request.GroupOwnerUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTags))
            {
                body["groupTags"] = request.GroupTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                body["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                body["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ReportCustomerStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/activities/statistics/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportCustomerStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ReportCustomerStatisticsResponse ReportCustomerStatistics(ReportCustomerStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportCustomerStatisticsHeaders headers = new ReportCustomerStatisticsHeaders();
            return ReportCustomerStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<ReportCustomerStatisticsResponse> ReportCustomerStatisticsAsync(ReportCustomerStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReportCustomerStatisticsHeaders headers = new ReportCustomerStatisticsHeaders();
            return await ReportCustomerStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public ResubmitTicketResponse ResubmitTicketWithOptions(ResubmitTicketRequest request, ResubmitTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTemplateBizId))
            {
                body["openTemplateBizId"] = request.OpenTemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "ResubmitTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/resubmit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResubmitTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<ResubmitTicketResponse> ResubmitTicketWithOptionsAsync(ResubmitTicketRequest request, ResubmitTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTemplateBizId))
            {
                body["openTemplateBizId"] = request.OpenTemplateBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "ResubmitTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/resubmit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResubmitTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ResubmitTicketResponse ResubmitTicket(ResubmitTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResubmitTicketHeaders headers = new ResubmitTicketHeaders();
            return ResubmitTicketWithOptions(request, headers, runtime);
        }

        public async Task<ResubmitTicketResponse> ResubmitTicketAsync(ResubmitTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResubmitTicketHeaders headers = new ResubmitTicketHeaders();
            return await ResubmitTicketWithOptionsAsync(request, headers, runtime);
        }

        public RetractTicketResponse RetractTicketWithOptions(RetractTicketRequest request, RetractTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "RetractTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/retract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetractTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<RetractTicketResponse> RetractTicketWithOptionsAsync(RetractTicketRequest request, RetractTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "RetractTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/retract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetractTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RetractTicketResponse RetractTicket(RetractTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetractTicketHeaders headers = new RetractTicketHeaders();
            return RetractTicketWithOptions(request, headers, runtime);
        }

        public async Task<RetractTicketResponse> RetractTicketAsync(RetractTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetractTicketHeaders headers = new RetractTicketHeaders();
            return await RetractTicketWithOptionsAsync(request, headers, runtime);
        }

        public RobotMessageRecallResponse RobotMessageRecallWithOptions(RobotMessageRecallRequest request, RobotMessageRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgId))
            {
                body["openMsgId"] = request.OpenMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "RobotMessageRecall",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/robots/messages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotMessageRecallResponse>(Execute(params_, req, runtime));
        }

        public async Task<RobotMessageRecallResponse> RobotMessageRecallWithOptionsAsync(RobotMessageRecallRequest request, RobotMessageRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgId))
            {
                body["openMsgId"] = request.OpenMsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "RobotMessageRecall",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/robots/messages/recall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RobotMessageRecallResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RobotMessageRecallResponse RobotMessageRecall(RobotMessageRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageRecallHeaders headers = new RobotMessageRecallHeaders();
            return RobotMessageRecallWithOptions(request, headers, runtime);
        }

        public async Task<RobotMessageRecallResponse> RobotMessageRecallAsync(RobotMessageRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RobotMessageRecallHeaders headers = new RobotMessageRecallHeaders();
            return await RobotMessageRecallWithOptionsAsync(request, headers, runtime);
        }

        public SaveFormInstanceResponse SaveFormInstanceWithOptions(SaveFormInstanceRequest request, SaveFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "SaveFormInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormInstanceResponse>(Execute(params_, req, runtime));
        }

        public async Task<SaveFormInstanceResponse> SaveFormInstanceWithOptionsAsync(SaveFormInstanceRequest request, SaveFormInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "SaveFormInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/forms/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveFormInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SaveFormInstanceResponse SaveFormInstance(SaveFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormInstanceHeaders headers = new SaveFormInstanceHeaders();
            return SaveFormInstanceWithOptions(request, headers, runtime);
        }

        public async Task<SaveFormInstanceResponse> SaveFormInstanceAsync(SaveFormInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveFormInstanceHeaders headers = new SaveFormInstanceHeaders();
            return await SaveFormInstanceWithOptionsAsync(request, headers, runtime);
        }

        public SearchGroupResponse SearchGroupWithOptions(SearchGroupRequest request, SearchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
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
                Action = "SearchGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<SearchGroupResponse> SearchGroupWithOptionsAsync(SearchGroupRequest request, SearchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
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
                Action = "SearchGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SearchGroupResponse SearchGroup(SearchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchGroupHeaders headers = new SearchGroupHeaders();
            return SearchGroupWithOptions(request, headers, runtime);
        }

        public async Task<SearchGroupResponse> SearchGroupAsync(SearchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchGroupHeaders headers = new SearchGroupHeaders();
            return await SearchGroupWithOptionsAsync(request, headers, runtime);
        }

        public SendMsgByTaskResponse SendMsgByTaskWithOptions(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryGroup))
            {
                body["queryGroup"] = request.QueryGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig))
            {
                body["sendConfig"] = request.SendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "SendMsgByTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/tasks/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgByTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<SendMsgByTaskResponse> SendMsgByTaskWithOptionsAsync(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryGroup))
            {
                body["queryGroup"] = request.QueryGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig))
            {
                body["sendConfig"] = request.SendConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "SendMsgByTask",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/tasks/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgByTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SendMsgByTaskResponse SendMsgByTask(SendMsgByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgByTaskHeaders headers = new SendMsgByTaskHeaders();
            return SendMsgByTaskWithOptions(request, headers, runtime);
        }

        public async Task<SendMsgByTaskResponse> SendMsgByTaskAsync(SendMsgByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgByTaskHeaders headers = new SendMsgByTaskHeaders();
            return await SendMsgByTaskWithOptionsAsync(request, headers, runtime);
        }

        public SendMsgByTaskSupportInviteJoinOrgResponse SendMsgByTaskSupportInviteJoinOrgWithOptions(SendMsgByTaskSupportInviteJoinOrgRequest request, SendMsgByTaskSupportInviteJoinOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhones))
            {
                body["mobilePhones"] = request.MobilePhones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedUrlTrack))
            {
                body["needUrlTrack"] = request.NeedUrlTrack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["sendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "SendMsgByTaskSupportInviteJoinOrg",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/groupSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgByTaskSupportInviteJoinOrgResponse>(Execute(params_, req, runtime));
        }

        public async Task<SendMsgByTaskSupportInviteJoinOrgResponse> SendMsgByTaskSupportInviteJoinOrgWithOptionsAsync(SendMsgByTaskSupportInviteJoinOrgRequest request, SendMsgByTaskSupportInviteJoinOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhones))
            {
                body["mobilePhones"] = request.MobilePhones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedUrlTrack))
            {
                body["needUrlTrack"] = request.NeedUrlTrack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendChannel))
            {
                body["sendChannel"] = request.SendChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
                Action = "SendMsgByTaskSupportInviteJoinOrg",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customers/tasks/groupSend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgByTaskSupportInviteJoinOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SendMsgByTaskSupportInviteJoinOrgResponse SendMsgByTaskSupportInviteJoinOrg(SendMsgByTaskSupportInviteJoinOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgByTaskSupportInviteJoinOrgHeaders headers = new SendMsgByTaskSupportInviteJoinOrgHeaders();
            return SendMsgByTaskSupportInviteJoinOrgWithOptions(request, headers, runtime);
        }

        public async Task<SendMsgByTaskSupportInviteJoinOrgResponse> SendMsgByTaskSupportInviteJoinOrgAsync(SendMsgByTaskSupportInviteJoinOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgByTaskSupportInviteJoinOrgHeaders headers = new SendMsgByTaskSupportInviteJoinOrgHeaders();
            return await SendMsgByTaskSupportInviteJoinOrgWithOptionsAsync(request, headers, runtime);
        }

        public SendServiceGroupMessageResponse SendServiceGroupMessageWithOptions(SendServiceGroupMessageRequest request, SendServiceGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtDingtalkIds))
            {
                body["atDingtalkIds"] = request.AtDingtalkIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtMobiles))
            {
                body["atMobiles"] = request.AtMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUnionIds))
            {
                body["atUnionIds"] = request.AtUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtnOrientation))
            {
                body["btnOrientation"] = request.BtnOrientation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Btns))
            {
                body["btns"] = request.Btns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasContentLinks))
            {
                body["hasContentLinks"] = request.HasContentLinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAtAll))
            {
                body["isAtAll"] = request.IsAtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverDingtalkIds))
            {
                body["receiverDingtalkIds"] = request.ReceiverDingtalkIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverMobiles))
            {
                body["receiverMobiles"] = request.ReceiverMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOpenConversationId))
            {
                body["targetOpenConversationId"] = request.TargetOpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "SendServiceGroupMessage",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendServiceGroupMessageResponse>(Execute(params_, req, runtime));
        }

        public async Task<SendServiceGroupMessageResponse> SendServiceGroupMessageWithOptionsAsync(SendServiceGroupMessageRequest request, SendServiceGroupMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtDingtalkIds))
            {
                body["atDingtalkIds"] = request.AtDingtalkIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtMobiles))
            {
                body["atMobiles"] = request.AtMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUnionIds))
            {
                body["atUnionIds"] = request.AtUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BtnOrientation))
            {
                body["btnOrientation"] = request.BtnOrientation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Btns))
            {
                body["btns"] = request.Btns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasContentLinks))
            {
                body["hasContentLinks"] = request.HasContentLinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAtAll))
            {
                body["isAtAll"] = request.IsAtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverDingtalkIds))
            {
                body["receiverDingtalkIds"] = request.ReceiverDingtalkIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverMobiles))
            {
                body["receiverMobiles"] = request.ReceiverMobiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUnionIds))
            {
                body["receiverUnionIds"] = request.ReceiverUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetOpenConversationId))
            {
                body["targetOpenConversationId"] = request.TargetOpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "SendServiceGroupMessage",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendServiceGroupMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SendServiceGroupMessageResponse SendServiceGroupMessage(SendServiceGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
            return SendServiceGroupMessageWithOptions(request, headers, runtime);
        }

        public async Task<SendServiceGroupMessageResponse> SendServiceGroupMessageAsync(SendServiceGroupMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
            return await SendServiceGroupMessageWithOptionsAsync(request, headers, runtime);
        }

        public SetRobotConfigResponse SetRobotConfigWithOptions(SetRobotConfigRequest request, SetRobotConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "SetRobotConfig",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/configs/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRobotConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<SetRobotConfigResponse> SetRobotConfigWithOptionsAsync(SetRobotConfigRequest request, SetRobotConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "SetRobotConfig",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/configs/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRobotConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SetRobotConfigResponse SetRobotConfig(SetRobotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotConfigHeaders headers = new SetRobotConfigHeaders();
            return SetRobotConfigWithOptions(request, headers, runtime);
        }

        public async Task<SetRobotConfigResponse> SetRobotConfigAsync(SetRobotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRobotConfigHeaders headers = new SetRobotConfigHeaders();
            return await SetRobotConfigWithOptionsAsync(request, headers, runtime);
        }

        public TakeTicketResponse TakeTicketWithOptions(TakeTicketRequest request, TakeTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TakerUnionId))
            {
                body["takerUnionId"] = request.TakerUnionId;
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
                Action = "TakeTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<TakeTicketResponse> TakeTicketWithOptionsAsync(TakeTicketRequest request, TakeTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TakerUnionId))
            {
                body["takerUnionId"] = request.TakerUnionId;
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
                Action = "TakeTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TakeTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public TakeTicketResponse TakeTicket(TakeTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TakeTicketHeaders headers = new TakeTicketHeaders();
            return TakeTicketWithOptions(request, headers, runtime);
        }

        public async Task<TakeTicketResponse> TakeTicketAsync(TakeTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TakeTicketHeaders headers = new TakeTicketHeaders();
            return await TakeTicketWithOptionsAsync(request, headers, runtime);
        }

        public TopicStatisticsResponse TopicStatisticsWithOptions(TopicStatisticsRequest request, TopicStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                query["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchContent))
            {
                query["searchContent"] = request.SearchContent;
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
                Action = "TopicStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/topics/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TopicStatisticsResponse>(Execute(params_, req, runtime));
        }

        public async Task<TopicStatisticsResponse> TopicStatisticsWithOptionsAsync(TopicStatisticsRequest request, TopicStatisticsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxDt))
            {
                query["maxDt"] = request.MaxDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinDt))
            {
                query["minDt"] = request.MinDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                query["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                query["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchContent))
            {
                query["searchContent"] = request.SearchContent;
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
                Action = "TopicStatistics",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/voices/topics/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TopicStatisticsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public TopicStatisticsResponse TopicStatistics(TopicStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopicStatisticsHeaders headers = new TopicStatisticsHeaders();
            return TopicStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<TopicStatisticsResponse> TopicStatisticsAsync(TopicStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopicStatisticsHeaders headers = new TopicStatisticsHeaders();
            return await TopicStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public TransferTicketResponse TransferTicketWithOptions(TransferTicketRequest request, TransferTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "TransferTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<TransferTicketResponse> TransferTicketWithOptionsAsync(TransferTicketRequest request, TransferTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify))
            {
                body["notify"] = request.Notify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionIds))
            {
                body["processorUnionIds"] = request.ProcessorUnionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "TransferTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/transfer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public TransferTicketResponse TransferTicket(TransferTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferTicketHeaders headers = new TransferTicketHeaders();
            return TransferTicketWithOptions(request, headers, runtime);
        }

        public async Task<TransferTicketResponse> TransferTicketAsync(TransferTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TransferTicketHeaders headers = new TransferTicketHeaders();
            return await TransferTicketWithOptionsAsync(request, headers, runtime);
        }

        public UpdateGroupSetResponse UpdateGroupSetWithOptions(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "UpdateGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/configurations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateGroupSetResponse> UpdateGroupSetWithOptionsAsync(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
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
                Action = "UpdateGroupSet",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/groups/configurations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateGroupSetResponse UpdateGroupSet(UpdateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
            return UpdateGroupSetWithOptions(request, headers, runtime);
        }

        public async Task<UpdateGroupSetResponse> UpdateGroupSetAsync(UpdateGroupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
            return await UpdateGroupSetWithOptionsAsync(request, headers, runtime);
        }

        public UpdateGroupTagResponse UpdateGroupTagWithOptions(UpdateGroupTagRequest request, UpdateGroupTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                body["tagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                body["updateType"] = request.UpdateType;
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
                Action = "UpdateGroupTag",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupTagResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateGroupTagResponse> UpdateGroupTagWithOptionsAsync(UpdateGroupTagRequest request, UpdateGroupTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                body["tagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                body["updateType"] = request.UpdateType;
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
                Action = "UpdateGroupTag",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateGroupTagResponse UpdateGroupTag(UpdateGroupTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupTagHeaders headers = new UpdateGroupTagHeaders();
            return UpdateGroupTagWithOptions(request, headers, runtime);
        }

        public async Task<UpdateGroupTagResponse> UpdateGroupTagAsync(UpdateGroupTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupTagHeaders headers = new UpdateGroupTagHeaders();
            return await UpdateGroupTagWithOptionsAsync(request, headers, runtime);
        }

        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, UpdateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalBizId))
            {
                body["externalBizId"] = request.ExternalBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceId))
            {
                body["openDataInstanceId"] = request.OpenDataInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "UpdateInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, UpdateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalBizId))
            {
                body["externalBizId"] = request.ExternalBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCode))
            {
                body["formCode"] = request.FormCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormDataList))
            {
                body["formDataList"] = request.FormDataList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenDataInstanceId))
            {
                body["openDataInstanceId"] = request.OpenDataInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUnionId))
            {
                body["ownerUnionId"] = request.OwnerUnionId;
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
                Action = "UpdateInstance",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/customForms/instances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
            return UpdateInstanceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
            return await UpdateInstanceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTicketResponse UpdateTicketWithOptions(UpdateTicketRequest request, UpdateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "UpdateTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateTicketResponse> UpdateTicketWithOptionsAsync(UpdateTicketRequest request, UpdateTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessorUnionId))
            {
                body["processorUnionId"] = request.ProcessorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "UpdateTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateTicketResponse UpdateTicket(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return UpdateTicketWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTicketResponse> UpdateTicketAsync(UpdateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTicketHeaders headers = new UpdateTicketHeaders();
            return await UpdateTicketWithOptionsAsync(request, headers, runtime);
        }

        public UpgradeCloudGroupResponse UpgradeCloudGroupWithOptions(UpgradeCloudGroupRequest request, UpgradeCloudGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcsInstanceId))
            {
                body["ccsInstanceId"] = request.CcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
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
                Action = "UpgradeCloudGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/cloudGroups/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeCloudGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpgradeCloudGroupResponse> UpgradeCloudGroupWithOptionsAsync(UpgradeCloudGroupRequest request, UpgradeCloudGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CcsInstanceId))
            {
                body["ccsInstanceId"] = request.CcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
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
                Action = "UpgradeCloudGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/cloudGroups/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeCloudGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpgradeCloudGroupResponse UpgradeCloudGroup(UpgradeCloudGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeCloudGroupHeaders headers = new UpgradeCloudGroupHeaders();
            return UpgradeCloudGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpgradeCloudGroupResponse> UpgradeCloudGroupAsync(UpgradeCloudGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeCloudGroupHeaders headers = new UpgradeCloudGroupHeaders();
            return await UpgradeCloudGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpgradeNormalGroupResponse UpgradeNormalGroupWithOptions(UpgradeNormalGroupRequest request, UpgradeNormalGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
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
                Action = "UpgradeNormalGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/normalGroups/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeNormalGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpgradeNormalGroupResponse> UpgradeNormalGroupWithOptionsAsync(UpgradeNormalGroupRequest request, UpgradeNormalGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenGroupSetId))
            {
                body["openGroupSetId"] = request.OpenGroupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
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
                Action = "UpgradeNormalGroup",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/normalGroups/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeNormalGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpgradeNormalGroupResponse UpgradeNormalGroup(UpgradeNormalGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeNormalGroupHeaders headers = new UpgradeNormalGroupHeaders();
            return UpgradeNormalGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpgradeNormalGroupResponse> UpgradeNormalGroupAsync(UpgradeNormalGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpgradeNormalGroupHeaders headers = new UpgradeNormalGroupHeaders();
            return await UpgradeNormalGroupWithOptionsAsync(request, headers, runtime);
        }

        public UrgeTicketResponse UrgeTicketWithOptions(UrgeTicketRequest request, UrgeTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "UrgeTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/urge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UrgeTicketResponse>(Execute(params_, req, runtime));
        }

        public async Task<UrgeTicketResponse> UrgeTicketWithOptionsAsync(UrgeTicketRequest request, UrgeTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTicketId))
            {
                body["openTicketId"] = request.OpenTicketId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo))
            {
                body["ticketMemo"] = request.TicketMemo;
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
                Action = "UrgeTicket",
                Version = "serviceGroup_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/serviceGroup/tickets/urge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UrgeTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UrgeTicketResponse UrgeTicket(UrgeTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UrgeTicketHeaders headers = new UrgeTicketHeaders();
            return UrgeTicketWithOptions(request, headers, runtime);
        }

        public async Task<UrgeTicketResponse> UrgeTicketAsync(UrgeTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UrgeTicketHeaders headers = new UrgeTicketHeaders();
            return await UrgeTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
