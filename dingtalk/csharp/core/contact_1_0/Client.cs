// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcontact_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0
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


        public QueryResourceManagementMembersResponse QueryResourceManagementMembers(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return QueryResourceManagementMembersWithOptions(resourceId, headers, runtime);
        }

        public async Task<QueryResourceManagementMembersResponse> QueryResourceManagementMembersAsync(string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
            return await QueryResourceManagementMembersWithOptionsAsync(resourceId, headers, runtime);
        }

        public QueryResourceManagementMembersResponse QueryResourceManagementMembersWithOptions(string resourceId, QueryResourceManagementMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryResourceManagementMembersResponse>(DoROARequest("QueryResourceManagementMembers", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/resources/" + resourceId + "/managementMembers", "json", req, runtime));
        }

        public async Task<QueryResourceManagementMembersResponse> QueryResourceManagementMembersWithOptionsAsync(string resourceId, QueryResourceManagementMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryResourceManagementMembersResponse>(await DoROARequestAsync("QueryResourceManagementMembers", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/resources/" + resourceId + "/managementMembers", "json", req, runtime));
        }

        public SortUserResponse SortUser(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return SortUserWithOptions(request, headers, runtime);
        }

        public async Task<SortUserResponse> SortUserAsync(SortUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SortUserHeaders headers = new SortUserHeaders();
            return await SortUserWithOptionsAsync(request, headers, runtime);
        }

        public SortUserResponse SortUserWithOptions(SortUserRequest request, SortUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
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
            return TeaModel.ToObject<SortUserResponse>(DoROARequest("SortUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/sort", "json", req, runtime));
        }

        public async Task<SortUserResponse> SortUserWithOptionsAsync(SortUserRequest request, SortUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
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
            return TeaModel.ToObject<SortUserResponse>(await DoROARequestAsync("SortUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/sort", "json", req, runtime));
        }

        public UpdateEmpAttrbuteVisibilitySettingResponse UpdateEmpAttrbuteVisibilitySetting(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return UpdateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
        }

        public async Task<UpdateEmpAttrbuteVisibilitySettingResponse> UpdateEmpAttrbuteVisibilitySettingAsync(UpdateEmpAttrbuteVisibilitySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
            return await UpdateEmpAttrbuteVisibilitySettingWithOptionsAsync(request, headers, runtime);
        }

        public UpdateEmpAttrbuteVisibilitySettingResponse UpdateEmpAttrbuteVisibilitySettingWithOptions(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
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
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(DoROARequest("UpdateEmpAttrbuteVisibilitySetting", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime));
        }

        public async Task<UpdateEmpAttrbuteVisibilitySettingResponse> UpdateEmpAttrbuteVisibilitySettingWithOptionsAsync(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectStaffIds))
            {
                body["objectStaffIds"] = request.ObjectStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDeptIds))
            {
                body["objectDeptIds"] = request.ObjectDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectTagIds))
            {
                body["objectTagIds"] = request.ObjectTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HideFields))
            {
                body["hideFields"] = request.HideFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeStaffIds))
            {
                body["excludeStaffIds"] = request.ExcludeStaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDeptIds))
            {
                body["excludeDeptIds"] = request.ExcludeDeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTagIds))
            {
                body["excludeTagIds"] = request.ExcludeTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["active"] = request.Active;
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
            return TeaModel.ToObject<UpdateEmpAttrbuteVisibilitySettingResponse>(await DoROARequestAsync("UpdateEmpAttrbuteVisibilitySetting", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime));
        }

        public DeleteEmpAttributeVisibilityResponse DeleteEmpAttributeVisibility(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return DeleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
        }

        public async Task<DeleteEmpAttributeVisibilityResponse> DeleteEmpAttributeVisibilityAsync(string settingId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
            return await DeleteEmpAttributeVisibilityWithOptionsAsync(settingId, headers, runtime);
        }

        public DeleteEmpAttributeVisibilityResponse DeleteEmpAttributeVisibilityWithOptions(string settingId, DeleteEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteEmpAttributeVisibilityResponse>(DoROARequest("DeleteEmpAttributeVisibility", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId, "none", req, runtime));
        }

        public async Task<DeleteEmpAttributeVisibilityResponse> DeleteEmpAttributeVisibilityWithOptionsAsync(string settingId, DeleteEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteEmpAttributeVisibilityResponse>(await DoROARequestAsync("DeleteEmpAttributeVisibility", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId, "none", req, runtime));
        }

        public SearchDepartmentResponse SearchDepartment(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return SearchDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<SearchDepartmentResponse> SearchDepartmentAsync(SearchDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
            return await SearchDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public SearchDepartmentResponse SearchDepartmentWithOptions(SearchDepartmentRequest request, SearchDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<SearchDepartmentResponse>(DoROARequest("SearchDepartment", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/departments/search", "json", req, runtime));
        }

        public async Task<SearchDepartmentResponse> SearchDepartmentWithOptionsAsync(SearchDepartmentRequest request, SearchDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<SearchDepartmentResponse>(await DoROARequestAsync("SearchDepartment", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/departments/search", "json", req, runtime));
        }

        public ListManagementGroupsResponse ListManagementGroups(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return ListManagementGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListManagementGroupsResponse> ListManagementGroupsAsync(ListManagementGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
            return await ListManagementGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListManagementGroupsResponse ListManagementGroupsWithOptions(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListManagementGroupsResponse>(DoROARequest("ListManagementGroups", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/managementGroups", "json", req, runtime));
        }

        public async Task<ListManagementGroupsResponse> ListManagementGroupsWithOptionsAsync(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListManagementGroupsResponse>(await DoROARequestAsync("ListManagementGroups", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/managementGroups", "json", req, runtime));
        }

        public ListEmpAttributeVisibilityResponse ListEmpAttributeVisibility(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return ListEmpAttributeVisibilityWithOptions(request, headers, runtime);
        }

        public async Task<ListEmpAttributeVisibilityResponse> ListEmpAttributeVisibilityAsync(ListEmpAttributeVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
            return await ListEmpAttributeVisibilityWithOptionsAsync(request, headers, runtime);
        }

        public ListEmpAttributeVisibilityResponse ListEmpAttributeVisibilityWithOptions(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListEmpAttributeVisibilityResponse>(DoROARequest("ListEmpAttributeVisibility", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime));
        }

        public async Task<ListEmpAttributeVisibilityResponse> ListEmpAttributeVisibilityWithOptionsAsync(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListEmpAttributeVisibilityResponse>(await DoROARequestAsync("ListEmpAttributeVisibility", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime));
        }

        public SearchUserResponse SearchUser(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return SearchUserWithOptions(request, headers, runtime);
        }

        public async Task<SearchUserResponse> SearchUserAsync(SearchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserHeaders headers = new SearchUserHeaders();
            return await SearchUserWithOptionsAsync(request, headers, runtime);
        }

        public SearchUserResponse SearchUserWithOptions(SearchUserRequest request, SearchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<SearchUserResponse>(DoROARequest("SearchUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/search", "json", req, runtime));
        }

        public async Task<SearchUserResponse> SearchUserWithOptionsAsync(SearchUserRequest request, SearchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryWord))
            {
                body["queryWord"] = request.QueryWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
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
            return TeaModel.ToObject<SearchUserResponse>(await DoROARequestAsync("SearchUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/search", "json", req, runtime));
        }

        public GetApplyInviteInfoResponse GetApplyInviteInfo(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return GetApplyInviteInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetApplyInviteInfoResponse> GetApplyInviteInfoAsync(GetApplyInviteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
            return await GetApplyInviteInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetApplyInviteInfoResponse GetApplyInviteInfoWithOptions(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviterUserId))
            {
                query["inviterUserId"] = request.InviterUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
            return TeaModel.ToObject<GetApplyInviteInfoResponse>(DoROARequest("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/invites/infos", "json", req, runtime));
        }

        public async Task<GetApplyInviteInfoResponse> GetApplyInviteInfoWithOptionsAsync(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InviterUserId))
            {
                query["inviterUserId"] = request.InviterUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
            return TeaModel.ToObject<GetApplyInviteInfoResponse>(await DoROARequestAsync("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/invites/infos", "json", req, runtime));
        }

        public CreateCooperateOrgResponse CreateCooperateOrg(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return CreateCooperateOrgWithOptions(request, headers, runtime);
        }

        public async Task<CreateCooperateOrgResponse> CreateCooperateOrgAsync(CreateCooperateOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
            return await CreateCooperateOrgWithOptionsAsync(request, headers, runtime);
        }

        public CreateCooperateOrgResponse CreateCooperateOrgWithOptions(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoMediaId))
            {
                body["logoMediaId"] = request.LogoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
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
            return TeaModel.ToObject<CreateCooperateOrgResponse>(DoROARequest("CreateCooperateOrg", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/cooperateCorps", "json", req, runtime));
        }

        public async Task<CreateCooperateOrgResponse> CreateCooperateOrgWithOptionsAsync(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                body["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoMediaId))
            {
                body["logoMediaId"] = request.LogoMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndustryCode))
            {
                body["industryCode"] = request.IndustryCode;
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
            return TeaModel.ToObject<CreateCooperateOrgResponse>(await DoROARequestAsync("CreateCooperateOrg", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/cooperateCorps", "json", req, runtime));
        }

        public QueryUserManagementResourcesResponse QueryUserManagementResources(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return QueryUserManagementResourcesWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserManagementResourcesResponse> QueryUserManagementResourcesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
            return await QueryUserManagementResourcesWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserManagementResourcesResponse QueryUserManagementResourcesWithOptions(string userId, QueryUserManagementResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserManagementResourcesResponse>(DoROARequest("QueryUserManagementResources", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + userId + "/managemementResources", "json", req, runtime));
        }

        public async Task<QueryUserManagementResourcesResponse> QueryUserManagementResourcesWithOptionsAsync(string userId, QueryUserManagementResourcesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserManagementResourcesResponse>(await DoROARequestAsync("QueryUserManagementResources", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + userId + "/managemementResources", "json", req, runtime));
        }

        public UpdateUserOwnnessResponse UpdateUserOwnness(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return UpdateUserOwnnessWithOptions(userId, request, headers, runtime);
        }

        public async Task<UpdateUserOwnnessResponse> UpdateUserOwnnessAsync(string userId, UpdateUserOwnnessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
            return await UpdateUserOwnnessWithOptionsAsync(userId, request, headers, runtime);
        }

        public UpdateUserOwnnessResponse UpdateUserOwnnessWithOptions(string userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletedFlag))
            {
                body["deletedFlag"] = request.DeletedFlag;
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
            return TeaModel.ToObject<UpdateUserOwnnessResponse>(DoROARequest("UpdateUserOwnness", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/user/" + userId + "/ownness", "json", req, runtime));
        }

        public async Task<UpdateUserOwnnessResponse> UpdateUserOwnnessWithOptionsAsync(string userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnenssType))
            {
                body["ownenssType"] = request.OwnenssType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletedFlag))
            {
                body["deletedFlag"] = request.DeletedFlag;
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
            return TeaModel.ToObject<UpdateUserOwnnessResponse>(await DoROARequestAsync("UpdateUserOwnness", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/user/" + userId + "/ownness", "json", req, runtime));
        }

        public GetCooperateOrgInviteInfoResponse GetCooperateOrgInviteInfo(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return GetCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
        }

        public async Task<GetCooperateOrgInviteInfoResponse> GetCooperateOrgInviteInfoAsync(string cooperateCorpId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
            return await GetCooperateOrgInviteInfoWithOptionsAsync(cooperateCorpId, headers, runtime);
        }

        public GetCooperateOrgInviteInfoResponse GetCooperateOrgInviteInfoWithOptions(string cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCooperateOrgInviteInfoResponse>(DoROARequest("GetCooperateOrgInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos", "json", req, runtime));
        }

        public async Task<GetCooperateOrgInviteInfoResponse> GetCooperateOrgInviteInfoWithOptionsAsync(string cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCooperateOrgInviteInfoResponse>(await DoROARequestAsync("GetCooperateOrgInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos", "json", req, runtime));
        }

        public CreateManagementGroupResponse CreateManagementGroup(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return CreateManagementGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateManagementGroupResponse> CreateManagementGroupAsync(CreateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
            return await CreateManagementGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateManagementGroupResponse CreateManagementGroupWithOptions(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
            return TeaModel.ToObject<CreateManagementGroupResponse>(DoROARequest("CreateManagementGroup", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/managementGroups", "json", req, runtime));
        }

        public async Task<CreateManagementGroupResponse> CreateManagementGroupWithOptionsAsync(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
            return TeaModel.ToObject<CreateManagementGroupResponse>(await DoROARequestAsync("CreateManagementGroup", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/managementGroups", "json", req, runtime));
        }

        public UpdateManagementGroupResponse UpdateManagementGroup(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return UpdateManagementGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<UpdateManagementGroupResponse> UpdateManagementGroupAsync(string groupId, UpdateManagementGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
            return await UpdateManagementGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public UpdateManagementGroupResponse UpdateManagementGroupWithOptions(string groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
            return TeaModel.ToObject<UpdateManagementGroupResponse>(DoROARequest("UpdateManagementGroup", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/managementGroups/" + groupId, "none", req, runtime));
        }

        public async Task<UpdateManagementGroupResponse> UpdateManagementGroupWithOptionsAsync(string groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope.ToMap()))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
            return TeaModel.ToObject<UpdateManagementGroupResponse>(await DoROARequestAsync("UpdateManagementGroup", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/managementGroups/" + groupId, "none", req, runtime));
        }

        public DeleteManagementGroupResponse DeleteManagementGroup(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return DeleteManagementGroupWithOptions(groupId, headers, runtime);
        }

        public async Task<DeleteManagementGroupResponse> DeleteManagementGroupAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
            return await DeleteManagementGroupWithOptionsAsync(groupId, headers, runtime);
        }

        public DeleteManagementGroupResponse DeleteManagementGroupWithOptions(string groupId, DeleteManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteManagementGroupResponse>(DoROARequest("DeleteManagementGroup", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/managementGroups/" + groupId, "none", req, runtime));
        }

        public async Task<DeleteManagementGroupResponse> DeleteManagementGroupWithOptionsAsync(string groupId, DeleteManagementGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<DeleteManagementGroupResponse>(await DoROARequestAsync("DeleteManagementGroup", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/managementGroups/" + groupId, "none", req, runtime));
        }

        public GetBranchAuthDataResponse GetBranchAuthData(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return GetBranchAuthDataWithOptions(request, headers, runtime);
        }

        public async Task<GetBranchAuthDataResponse> GetBranchAuthDataAsync(GetBranchAuthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
            return await GetBranchAuthDataWithOptionsAsync(request, headers, runtime);
        }

        public GetBranchAuthDataResponse GetBranchAuthDataWithOptions(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchCorpId))
            {
                query["branchCorpId"] = request.BranchCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> body = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body = request.Body;
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
            return TeaModel.ToObject<GetBranchAuthDataResponse>(DoROARequest("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/branchAuthDatas/search", "json", req, runtime));
        }

        public async Task<GetBranchAuthDataResponse> GetBranchAuthDataWithOptionsAsync(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchCorpId))
            {
                query["branchCorpId"] = request.BranchCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> body = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body = request.Body;
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
            return TeaModel.ToObject<GetBranchAuthDataResponse>(await DoROARequestAsync("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/branchAuthDatas/search", "json", req, runtime));
        }

        public GetLatestDingIndexResponse GetLatestDingIndex()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return GetLatestDingIndexWithOptions(headers, runtime);
        }

        public async Task<GetLatestDingIndexResponse> GetLatestDingIndexAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
            return await GetLatestDingIndexWithOptionsAsync(headers, runtime);
        }

        public GetLatestDingIndexResponse GetLatestDingIndexWithOptions(GetLatestDingIndexHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetLatestDingIndexResponse>(DoROARequest("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/dingIndexs", "json", req, runtime));
        }

        public async Task<GetLatestDingIndexResponse> GetLatestDingIndexWithOptionsAsync(GetLatestDingIndexHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetLatestDingIndexResponse>(await DoROARequestAsync("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/dingIndexs", "json", req, runtime));
        }

        public GetUserResponse GetUser(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(unionId, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(unionId, headers, runtime);
        }

        public GetUserResponse GetUserWithOptions(string unionId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetUserResponse>(DoROARequest("GetUser", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + unionId, "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(string unionId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetUserResponse>(await DoROARequestAsync("GetUser", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + unionId, "json", req, runtime));
        }

    }
}
