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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
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

        public AddContactMemberToGroupResponse AddContactMemberToGroupWithOptions(AddContactMemberToGroupRequest request, AddContactMemberToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<AddContactMemberToGroupResponse>(DoROARequest("AddContactMemberToGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/contacts", "json", req, runtime));
        }

        public async Task<AddContactMemberToGroupResponse> AddContactMemberToGroupWithOptionsAsync(AddContactMemberToGroupRequest request, AddContactMemberToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<AddContactMemberToGroupResponse>(await DoROARequestAsync("AddContactMemberToGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<AddKnowledgeResponse>(DoROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges", "json", req, runtime));
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
            return TeaModel.ToObject<AddKnowledgeResponse>(await DoROARequestAsync("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges", "json", req, runtime));
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
            return TeaModel.ToObject<AddLibraryResponse>(DoROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/librarys", "json", req, runtime));
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
            return TeaModel.ToObject<AddLibraryResponse>(await DoROARequestAsync("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/librarys", "json", req, runtime));
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
            return TeaModel.ToObject<AddMemberToServiceGroupResponse>(DoROARequest("AddMemberToServiceGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members", "json", req, runtime));
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
            return TeaModel.ToObject<AddMemberToServiceGroupResponse>(await DoROARequestAsync("AddMemberToServiceGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenCategoryResponse>(DoROARequest("AddOpenCategory", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openCategories", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenCategoryResponse>(await DoROARequestAsync("AddOpenCategory", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openCategories", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenKnowledgeResponse>(DoROARequest("AddOpenKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openKnowledges", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenKnowledgeResponse>(await DoROARequestAsync("AddOpenKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openKnowledges", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenLibraryResponse>(DoROARequest("AddOpenLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openLibraries", "json", req, runtime));
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
            return TeaModel.ToObject<AddOpenLibraryResponse>(await DoROARequestAsync("AddOpenLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openLibraries", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<AddTicketMemoResponse>(DoROARequest("AddTicketMemo", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/memos", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<AddTicketMemoResponse>(await DoROARequestAsync("AddTicketMemo", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/memos", "none", req, runtime));
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

        public AssignTicketResponse AssignTicketWithOptions(AssignTicketRequest request, AssignTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<AssignTicketResponse>(DoROARequest("AssignTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/assign", "none", req, runtime));
        }

        public async Task<AssignTicketResponse> AssignTicketWithOptionsAsync(AssignTicketRequest request, AssignTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<AssignTicketResponse>(await DoROARequestAsync("AssignTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/assign", "none", req, runtime));
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
            return TeaModel.ToObject<BatchBindingGroupBizIdsResponse>(DoROARequest("BatchBindingGroupBizIds", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/bind", "json", req, runtime));
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
            return TeaModel.ToObject<BatchBindingGroupBizIdsResponse>(await DoROARequestAsync("BatchBindingGroupBizIds", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/bind", "json", req, runtime));
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
            return TeaModel.ToObject<BatchGetGroupSetConfigResponse>(DoROARequest("BatchGetGroupSetConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSetConfigs/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<BatchGetGroupSetConfigResponse>(await DoROARequestAsync("BatchGetGroupSetConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSetConfigs/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<BatchQuerySendMessageTaskResponse>(DoROARequest("BatchQuerySendMessageTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/query", "json", req, runtime));
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
            return TeaModel.ToObject<BatchQuerySendMessageTaskResponse>(await DoROARequestAsync("BatchQuerySendMessageTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/query", "json", req, runtime));
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
            return TeaModel.ToObject<BoundTemplateToTeamResponse>(DoROARequest("BoundTemplateToTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams/templates/bound", "json", req, runtime));
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
            return TeaModel.ToObject<BoundTemplateToTeamResponse>(await DoROARequestAsync("BoundTemplateToTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams/templates/bound", "json", req, runtime));
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

        public CancelTicketResponse CancelTicketWithOptions(CancelTicketRequest request, CancelTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<CancelTicketResponse>(DoROARequest("CancelTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/cancel", "none", req, runtime));
        }

        public async Task<CancelTicketResponse> CancelTicketWithOptionsAsync(CancelTicketRequest request, CancelTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<CancelTicketResponse>(await DoROARequestAsync("CancelTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/cancel", "none", req, runtime));
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
            return TeaModel.ToObject<CategoryStatisticsResponse>(DoROARequest("CategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/categories/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<CategoryStatisticsResponse>(await DoROARequestAsync("CategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/categories/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<CloseConversationResponse>(DoROARequest("CloseConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/conversions", "json", req, runtime));
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
            return TeaModel.ToObject<CloseConversationResponse>(await DoROARequestAsync("CloseConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/conversions", "json", req, runtime));
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
            return TeaModel.ToObject<CloseHumanSessionResponse>(DoROARequest("CloseHumanSession", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/humanSessions/close", "json", req, runtime));
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
            return TeaModel.ToObject<CloseHumanSessionResponse>(await DoROARequestAsync("CloseHumanSession", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/humanSessions/close", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationCreatedNotifyResponse>(DoROARequest("ConversationCreatedNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationCreatedNotifyResponse>(await DoROARequestAsync("ConversationCreatedNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationTransferBeginNotifyResponse>(DoROARequest("ConversationTransferBeginNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/transfers", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationTransferBeginNotifyResponse>(await DoROARequestAsync("ConversationTransferBeginNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/transfers", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationTransferCompleteNotifyResponse>(DoROARequest("ConversationTransferCompleteNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/completes", "json", req, runtime));
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
            return TeaModel.ToObject<ConversationTransferCompleteNotifyResponse>(await DoROARequestAsync("ConversationTransferCompleteNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/completes", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupResponse>(DoROARequest("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupResponse>(await DoROARequestAsync("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupConversationResponse>(DoROARequest("CreateGroupConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/create/conversations", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupConversationResponse>(await DoROARequestAsync("CreateGroupConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/create/conversations", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupSetResponse>(DoROARequest("CreateGroupSet", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime));
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
            return TeaModel.ToObject<CreateGroupSetResponse>(await DoROARequestAsync("CreateGroupSet", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceResponse>(DoROARequest("CreateInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInstanceResponse>(await DoROARequestAsync("CreateInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTeamResponse>(DoROARequest("CreateTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTeamResponse>(await DoROARequestAsync("CreateTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext.ToMap()))
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
            return TeaModel.ToObject<CreateTicketResponse>(DoROARequest("CreateTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext.ToMap()))
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
            return TeaModel.ToObject<CreateTicketResponse>(await DoROARequestAsync("CreateTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteGroupMembersFromGroupResponse>(DoROARequest("DeleteGroupMembersFromGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members/remove", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteGroupMembersFromGroupResponse>(await DoROARequestAsync("DeleteGroupMembersFromGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members/remove", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteInstanceResponse>(DoROARequest("DeleteInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/remove", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoROARequestAsync("DeleteInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/remove", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteKnowledgeResponse>(DoROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges/batchDelete", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteKnowledgeResponse>(await DoROARequestAsync("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges/batchDelete", "json", req, runtime));
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
            return TeaModel.ToObject<EmotionStatisticsResponse>(DoROARequest("EmotionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/emotions/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<EmotionStatisticsResponse>(await DoROARequestAsync("EmotionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/emotions/statistics", "json", req, runtime));
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

        public FinishTicketResponse FinishTicketWithOptions(FinishTicketRequest request, FinishTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<FinishTicketResponse>(DoROARequest("FinishTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/finish", "none", req, runtime));
        }

        public async Task<FinishTicketResponse> FinishTicketWithOptionsAsync(FinishTicketRequest request, FinishTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<FinishTicketResponse>(await DoROARequestAsync("FinishTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/finish", "none", req, runtime));
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
            return TeaModel.ToObject<GetAuthTokenResponse>(DoROARequest("GetAuthToken", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/get/tokens", "json", req, runtime));
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
            return TeaModel.ToObject<GetAuthTokenResponse>(await DoROARequestAsync("GetAuthToken", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/get/tokens", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstancesByIdsResponse>(DoROARequest("GetInstancesByIds", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<GetInstancesByIdsResponse>(await DoROARequestAsync("GetInstancesByIds", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<GetNegativeWordCloudResponse>(DoROARequest("GetNegativeWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/negatives/wordClouds", "json", req, runtime));
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
            return TeaModel.ToObject<GetNegativeWordCloudResponse>(await DoROARequestAsync("GetNegativeWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/negatives/wordClouds", "json", req, runtime));
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
            return TeaModel.ToObject<GetOssTempUrlResponse>(DoROARequest("GetOssTempUrl", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/ossServices/tempUrls", "json", req, runtime));
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
            return TeaModel.ToObject<GetOssTempUrlResponse>(await DoROARequestAsync("GetOssTempUrl", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/ossServices/tempUrls", "json", req, runtime));
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
            return TeaModel.ToObject<GetStoragePolicyResponse>(DoROARequest("GetStoragePolicy", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/ossServices/policies", "json", req, runtime));
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
            return TeaModel.ToObject<GetStoragePolicyResponse>(await DoROARequestAsync("GetStoragePolicy", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/ossServices/policies", "json", req, runtime));
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
            return TeaModel.ToObject<GetTicketResponse>(DoROARequest("GetTicket", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime));
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
            return TeaModel.ToObject<GetTicketResponse>(await DoROARequestAsync("GetTicket", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime));
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
            return TeaModel.ToObject<GetWordCloudResponse>(DoROARequest("GetWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/wordClouds", "json", req, runtime));
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
            return TeaModel.ToObject<GetWordCloudResponse>(await DoROARequestAsync("GetWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/wordClouds", "json", req, runtime));
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
            return TeaModel.ToObject<GroupStatisticsResponse>(DoROARequest("GroupStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/groups/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<GroupStatisticsResponse>(await DoROARequestAsync("GroupStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/groups/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<IntentionCategoryStatisticsResponse>(DoROARequest("IntentionCategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<IntentionCategoryStatisticsResponse>(await DoROARequestAsync("IntentionCategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<IntentionStatisticsResponse>(DoROARequest("IntentionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentions/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<IntentionStatisticsResponse>(await DoROARequestAsync("IntentionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentions/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<ListTicketOperateRecordResponse>(DoROARequest("ListTicketOperateRecord", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets/operateRecords", "json", req, runtime));
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
            return TeaModel.ToObject<ListTicketOperateRecordResponse>(await DoROARequestAsync("ListTicketOperateRecord", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets/operateRecords", "json", req, runtime));
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

        public ListUserTeamsResponse ListUserTeamsWithOptions(string userId, ListUserTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<ListUserTeamsResponse>(DoROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/users/" + userId + "/teams", "json", req, runtime));
        }

        public async Task<ListUserTeamsResponse> ListUserTeamsWithOptionsAsync(string userId, ListUserTeamsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<ListUserTeamsResponse>(await DoROARequestAsync("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/users/" + userId + "/teams", "json", req, runtime));
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
            return TeaModel.ToObject<QueryActiveUsersResponse>(DoROARequest("QueryActiveUsers", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groups/queryActiveUsers", "json", req, runtime));
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
            return TeaModel.ToObject<QueryActiveUsersResponse>(await DoROARequestAsync("QueryActiveUsers", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groups/queryActiveUsers", "json", req, runtime));
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
            return TeaModel.ToObject<QueryCrmGroupContactResponse>(DoROARequest("QueryCrmGroupContact", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/contacts/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryCrmGroupContactResponse>(await DoROARequestAsync("QueryCrmGroupContact", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/contacts/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryCustomerCardResponse>(DoROARequest("QueryCustomerCard", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/userDetials", "json", req, runtime));
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
            return TeaModel.ToObject<QueryCustomerCardResponse>(await DoROARequestAsync("QueryCustomerCard", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/userDetials", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupResponse>(DoROARequest("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupResponse>(await DoROARequestAsync("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupMemberResponse>(DoROARequest("QueryGroupMember", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupMemberResponse>(await DoROARequestAsync("QueryGroupMember", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupSetResponse>(DoROARequest("QueryGroupSet", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime));
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
            return TeaModel.ToObject<QueryGroupSetResponse>(await DoROARequestAsync("QueryGroupSet", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime));
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
            return TeaModel.ToObject<QueryInstancesByMultiConditionsResponse>(DoROARequest("QueryInstancesByMultiConditions", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<QueryInstancesByMultiConditionsResponse>(await DoROARequestAsync("QueryInstancesByMultiConditions", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery", "json", req, runtime));
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
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsResponse>(DoROARequest("QuerySendMsgTaskStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/query", "json", req, runtime));
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
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsResponse>(await DoROARequestAsync("QuerySendMsgTaskStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/query", "json", req, runtime));
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
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsDetailResponse>(DoROARequest("QuerySendMsgTaskStatisticsDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/details/query", "json", req, runtime));
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
            return TeaModel.ToObject<QuerySendMsgTaskStatisticsDetailResponse>(await DoROARequestAsync("QuerySendMsgTaskStatisticsDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/details/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryServiceGroupMessageReadStatusResponse>(DoROARequest("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/readStatus/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryServiceGroupMessageReadStatusResponse>(await DoROARequestAsync("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/readStatus/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueueNotifyResponse>(DoROARequest("QueueNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/dts", "json", req, runtime));
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
            return TeaModel.ToObject<QueueNotifyResponse>(await DoROARequestAsync("QueueNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/dts", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveContactFromOrgResponse>(DoROARequest("RemoveContactFromOrg", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/organizations/contacts/remove", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveContactFromOrgResponse>(await DoROARequestAsync("RemoveContactFromOrg", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/organizations/contacts/remove", "json", req, runtime));
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
            return TeaModel.ToObject<ReportCustomerDetailResponse>(DoROARequest("ReportCustomerDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/details/query", "json", req, runtime));
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
            return TeaModel.ToObject<ReportCustomerDetailResponse>(await DoROARequestAsync("ReportCustomerDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/details/query", "json", req, runtime));
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
            return TeaModel.ToObject<ReportCustomerStatisticsResponse>(DoROARequest("ReportCustomerStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/statistics/query", "json", req, runtime));
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
            return TeaModel.ToObject<ReportCustomerStatisticsResponse>(await DoROARequestAsync("ReportCustomerStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/statistics/query", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext.ToMap()))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<ResubmitTicketResponse>(DoROARequest("ResubmitTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/resubmit", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneContext.ToMap()))
            {
                body["sceneContext"] = request.SceneContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<ResubmitTicketResponse>(await DoROARequestAsync("ResubmitTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/resubmit", "none", req, runtime));
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

        public RetractTicketResponse RetractTicketWithOptions(RetractTicketRequest request, RetractTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<RetractTicketResponse>(DoROARequest("RetractTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/retract", "none", req, runtime));
        }

        public async Task<RetractTicketResponse> RetractTicketWithOptionsAsync(RetractTicketRequest request, RetractTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<RetractTicketResponse>(await DoROARequestAsync("RetractTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/retract", "none", req, runtime));
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
            return TeaModel.ToObject<RobotMessageRecallResponse>(DoROARequest("RobotMessageRecall", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/robots/messages/recall", "json", req, runtime));
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
            return TeaModel.ToObject<RobotMessageRecallResponse>(await DoROARequestAsync("RobotMessageRecall", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/robots/messages/recall", "json", req, runtime));
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
            return TeaModel.ToObject<SearchGroupResponse>(DoROARequest("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/search", "json", req, runtime));
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
            return TeaModel.ToObject<SearchGroupResponse>(await DoROARequestAsync("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/search", "json", req, runtime));
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

        public SendMsgByTaskResponse SendMsgByTaskWithOptions(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent.ToMap()))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryGroup.ToMap()))
            {
                body["queryGroup"] = request.QueryGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig.ToMap()))
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
            return TeaModel.ToObject<SendMsgByTaskResponse>(DoROARequest("SendMsgByTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/tasks/send", "json", req, runtime));
        }

        public async Task<SendMsgByTaskResponse> SendMsgByTaskWithOptionsAsync(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent.ToMap()))
            {
                body["messageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTeamId))
            {
                body["openTeamId"] = request.OpenTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryGroup.ToMap()))
            {
                body["queryGroup"] = request.QueryGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendConfig.ToMap()))
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
            return TeaModel.ToObject<SendMsgByTaskResponse>(await DoROARequestAsync("SendMsgByTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/tasks/send", "json", req, runtime));
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
            return TeaModel.ToObject<SendServiceGroupMessageResponse>(DoROARequest("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/send", "json", req, runtime));
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
            return TeaModel.ToObject<SendServiceGroupMessageResponse>(await DoROARequestAsync("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/send", "json", req, runtime));
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
            return TeaModel.ToObject<SetRobotConfigResponse>(DoROARequest("SetRobotConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/configs/set", "json", req, runtime));
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
            return TeaModel.ToObject<SetRobotConfigResponse>(await DoROARequestAsync("SetRobotConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/configs/set", "json", req, runtime));
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
            return TeaModel.ToObject<TakeTicketResponse>(DoROARequest("TakeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/apply", "none", req, runtime));
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
            return TeaModel.ToObject<TakeTicketResponse>(await DoROARequestAsync("TakeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/apply", "none", req, runtime));
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
            return TeaModel.ToObject<TopicStatisticsResponse>(DoROARequest("TopicStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/topics/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<TopicStatisticsResponse>(await DoROARequestAsync("TopicStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/topics/statistics", "json", req, runtime));
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

        public TransferTicketResponse TransferTicketWithOptions(TransferTicketRequest request, TransferTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<TransferTicketResponse>(DoROARequest("TransferTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/transfer", "none", req, runtime));
        }

        public async Task<TransferTicketResponse> TransferTicketWithOptionsAsync(TransferTicketRequest request, TransferTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notify.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<TransferTicketResponse>(await DoROARequestAsync("TransferTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/transfer", "none", req, runtime));
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
            return TeaModel.ToObject<UpdateGroupTagResponse>(DoROARequest("UpdateGroupTag", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tags", "none", req, runtime));
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
            return TeaModel.ToObject<UpdateGroupTagResponse>(await DoROARequestAsync("UpdateGroupTag", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tags", "none", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceResponse>(DoROARequest("UpdateInstance", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/customForms/instances", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateInstanceResponse>(await DoROARequestAsync("UpdateInstance", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/customForms/instances", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<UpdateTicketResponse>(DoROARequest("UpdateTicket", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tickets", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<UpdateTicketResponse>(await DoROARequestAsync("UpdateTicket", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tickets", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeCloudGroupResponse>(DoROARequest("UpgradeCloudGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/cloudGroups/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeCloudGroupResponse>(await DoROARequestAsync("UpgradeCloudGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/cloudGroups/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeNormalGroupResponse>(DoROARequest("UpgradeNormalGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/normalGroups/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeNormalGroupResponse>(await DoROARequestAsync("UpgradeNormalGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/normalGroups/upgrade", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<UrgeTicketResponse>(DoROARequest("UrgeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/urge", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketMemo.ToMap()))
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
            return TeaModel.ToObject<UrgeTicketResponse>(await DoROARequestAsync("UrgeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/urge", "none", req, runtime));
        }

    }
}
