// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkindustry_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0
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


        public CustomizeContactCreateResponse CustomizeContactCreate(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return CustomizeContactCreateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactCreateResponse> CustomizeContactCreateAsync(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return await CustomizeContactCreateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactCreateResponse CustomizeContactCreateWithOptions(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactCreateResponse>(DoROARequest("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public async Task<CustomizeContactCreateResponse> CustomizeContactCreateWithOptionsAsync(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactCreateResponse>(await DoROARequestAsync("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public CustomizeContactDeleteResponse CustomizeContactDelete(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return CustomizeContactDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeleteResponse> CustomizeContactDeleteAsync(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return await CustomizeContactDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeleteResponse CustomizeContactDeleteWithOptions(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(DoROARequest("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public async Task<CustomizeContactDeleteResponse> CustomizeContactDeleteWithOptionsAsync(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(await DoROARequestAsync("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public CustomizeContactDeptCreateResponse CustomizeContactDeptCreate(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return CustomizeContactDeptCreateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptCreateResponse> CustomizeContactDeptCreateAsync(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return await CustomizeContactDeptCreateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptCreateResponse CustomizeContactDeptCreateWithOptions(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefId))
            {
                body["refId"] = request.RefId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(DoROARequest("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public async Task<CustomizeContactDeptCreateResponse> CustomizeContactDeptCreateWithOptionsAsync(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefId))
            {
                body["refId"] = request.RefId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(await DoROARequestAsync("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public CustomizeContactDeptDeleteResponse CustomizeContactDeptDelete(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return CustomizeContactDeptDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptDeleteResponse> CustomizeContactDeptDeleteAsync(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return await CustomizeContactDeptDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptDeleteResponse CustomizeContactDeptDeleteWithOptions(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(DoROARequest("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public async Task<CustomizeContactDeptDeleteResponse> CustomizeContactDeptDeleteWithOptionsAsync(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(await DoROARequestAsync("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public CustomizeContactDeptInfoResponse CustomizeContactDeptInfo(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return CustomizeContactDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptInfoResponse> CustomizeContactDeptInfoAsync(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return await CustomizeContactDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptInfoResponse CustomizeContactDeptInfoWithOptions(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(DoROARequest("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public async Task<CustomizeContactDeptInfoResponse> CustomizeContactDeptInfoWithOptionsAsync(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(await DoROARequestAsync("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public CustomizeContactDeptListResponse CustomizeContactDeptList(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return CustomizeContactDeptListWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptListResponse> CustomizeContactDeptListAsync(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return await CustomizeContactDeptListWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptListResponse CustomizeContactDeptListWithOptions(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(DoROARequest("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime));
        }

        public async Task<CustomizeContactDeptListResponse> CustomizeContactDeptListWithOptionsAsync(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(await DoROARequestAsync("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime));
        }

        public CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return CustomizeContactDeptUpdateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptUpdateResponse> CustomizeContactDeptUpdateAsync(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return await CustomizeContactDeptUpdateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdateWithOptions(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(DoROARequest("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public async Task<CustomizeContactDeptUpdateResponse> CustomizeContactDeptUpdateWithOptionsAsync(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(await DoROARequestAsync("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
        }

        public CustomizeContactEmpAddResponse CustomizeContactEmpAdd(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return CustomizeContactEmpAddWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpAddResponse> CustomizeContactEmpAddAsync(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return await CustomizeContactEmpAddWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpAddResponse CustomizeContactEmpAddWithOptions(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(DoROARequest("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
        }

        public async Task<CustomizeContactEmpAddResponse> CustomizeContactEmpAddWithOptionsAsync(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(await DoROARequestAsync("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
        }

        public CustomizeContactEmpDeleteResponse CustomizeContactEmpDelete(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return CustomizeContactEmpDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpDeleteResponse> CustomizeContactEmpDeleteAsync(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return await CustomizeContactEmpDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpDeleteResponse CustomizeContactEmpDeleteWithOptions(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(DoROARequest("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime));
        }

        public async Task<CustomizeContactEmpDeleteResponse> CustomizeContactEmpDeleteWithOptionsAsync(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(await DoROARequestAsync("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime));
        }

        public CustomizeContactEmpListResponse CustomizeContactEmpList(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return CustomizeContactEmpListWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpListResponse> CustomizeContactEmpListAsync(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return await CustomizeContactEmpListWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpListResponse CustomizeContactEmpListWithOptions(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(DoROARequest("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
        }

        public async Task<CustomizeContactEmpListResponse> CustomizeContactEmpListWithOptionsAsync(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(await DoROARequestAsync("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
        }

        public CustomizeContactListResponse CustomizeContactList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return CustomizeContactListWithOptions(headers, runtime);
        }

        public async Task<CustomizeContactListResponse> CustomizeContactListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return await CustomizeContactListWithOptionsAsync(headers, runtime);
        }

        public CustomizeContactListResponse CustomizeContactListWithOptions(CustomizeContactListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CustomizeContactListResponse>(DoROARequest("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public async Task<CustomizeContactListResponse> CustomizeContactListWithOptionsAsync(CustomizeContactListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CustomizeContactListResponse>(await DoROARequestAsync("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public CustomizeContactUpdateResponse CustomizeContactUpdate(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return CustomizeContactUpdateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactUpdateResponse> CustomizeContactUpdateAsync(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return await CustomizeContactUpdateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactUpdateResponse CustomizeContactUpdateWithOptions(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(DoROARequest("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public async Task<CustomizeContactUpdateResponse> CustomizeContactUpdateWithOptionsAsync(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(await DoROARequestAsync("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
        }

        public IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return IndustryManufactureCostRecordListGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureCostRecordListGetResponse> IndustryManufactureCostRecordListGetAsync(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return await IndustryManufactureCostRecordListGetWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(DoROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime));
        }

        public async Task<IndustryManufactureCostRecordListGetResponse> IndustryManufactureCostRecordListGetWithOptionsAsync(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(await DoROARequestAsync("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime));
        }

        public IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return IndustryManufactureFeeListGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureFeeListGetResponse> IndustryManufactureFeeListGetAsync(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return await IndustryManufactureFeeListGetWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(DoROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime));
        }

        public async Task<IndustryManufactureFeeListGetResponse> IndustryManufactureFeeListGetWithOptionsAsync(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(await DoROARequestAsync("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime));
        }

        public IndustryManufactureLabourCostResponse IndustryManufactureLabourCost(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return IndustryManufactureLabourCostWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureLabourCostResponse> IndustryManufactureLabourCostAsync(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return await IndustryManufactureLabourCostWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureLabourCostResponse IndustryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNo))
            {
                body["processNo"] = request.ProcessNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(DoROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime));
        }

        public async Task<IndustryManufactureLabourCostResponse> IndustryManufactureLabourCostWithOptionsAsync(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNo))
            {
                body["processNo"] = request.ProcessNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(await DoROARequestAsync("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime));
        }

        public IndustryManufactureMaterialListResponse IndustryManufactureMaterialList(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return IndustryManufactureMaterialListWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMaterialListResponse> IndustryManufactureMaterialListAsync(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return await IndustryManufactureMaterialListWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMaterialListResponse IndustryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(DoROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime));
        }

        public async Task<IndustryManufactureMaterialListResponse> IndustryManufactureMaterialListWithOptionsAsync(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(await DoROARequestAsync("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime));
        }

        public IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return IndustryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryMmanufactureMaterialCostGetResponse> IndustryMmanufactureMaterialCostGetAsync(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return await IndustryMmanufactureMaterialCostGetWithOptionsAsync(request, headers, runtime);
        }

        public IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(DoROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime));
        }

        public async Task<IndustryMmanufactureMaterialCostGetResponse> IndustryMmanufactureMaterialCostGetWithOptionsAsync(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(await DoROARequestAsync("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime));
        }

        public QueryAllDepartmentResponse QueryAllDepartment(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return QueryAllDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentAsync(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return await QueryAllDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllDepartmentResponse QueryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(DoROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
        }

        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentWithOptionsAsync(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(await DoROARequestAsync("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
        }

        public QueryAllDoctorsResponse QueryAllDoctors(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return QueryAllDoctorsWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsAsync(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return await QueryAllDoctorsWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllDoctorsResponse QueryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(DoROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
        }

        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsWithOptionsAsync(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(await DoROARequestAsync("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
        }

        public QueryAllGroupResponse QueryAllGroup(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return QueryAllGroupWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllGroupResponse> QueryAllGroupAsync(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return await QueryAllGroupWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllGroupResponse QueryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllGroupResponse>(DoROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime));
        }

        public async Task<QueryAllGroupResponse> QueryAllGroupWithOptionsAsync(QueryAllGroupRequest request, QueryAllGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllGroupResponse>(await DoROARequestAsync("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime));
        }

        public QueryAllGroupsInDeptResponse QueryAllGroupsInDept(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return QueryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptAsync(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return await QueryAllGroupsInDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        public QueryAllGroupsInDeptResponse QueryAllGroupsInDeptWithOptions(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(DoROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptWithOptionsAsync(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(await DoROARequestAsync("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
        }

        public QueryAllMemberByDeptResponse QueryAllMemberByDept(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return QueryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptAsync(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return await QueryAllMemberByDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        public QueryAllMemberByDeptResponse QueryAllMemberByDeptWithOptions(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(DoROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptWithOptionsAsync(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(await DoROARequestAsync("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime));
        }

        public QueryAllMemberByGroupResponse QueryAllMemberByGroup(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return QueryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupAsync(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return await QueryAllMemberByGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public QueryAllMemberByGroupResponse QueryAllMemberByGroupWithOptions(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(DoROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupWithOptionsAsync(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(await DoROARequestAsync("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
        }

        public QueryBizOptLogResponse QueryBizOptLog(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return QueryBizOptLogWithOptions(request, headers, runtime);
        }

        public async Task<QueryBizOptLogResponse> QueryBizOptLogAsync(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return await QueryBizOptLogWithOptionsAsync(request, headers, runtime);
        }

        public QueryBizOptLogResponse QueryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(DoROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
        }

        public async Task<QueryBizOptLogResponse> QueryBizOptLogWithOptionsAsync(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(await DoROARequestAsync("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
        }

        public QueryDepartmentInfoResponse QueryDepartmentInfo(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return QueryDepartmentInfoWithOptions(deptId, headers, runtime);
        }

        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoAsync(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return await QueryDepartmentInfoWithOptionsAsync(deptId, headers, runtime);
        }

        public QueryDepartmentInfoResponse QueryDepartmentInfoWithOptions(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(DoROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
        }

        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoWithOptionsAsync(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(await DoROARequestAsync("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
        }

        public QueryGroupInfoResponse QueryGroupInfo(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return QueryGroupInfoWithOptions(groupId, headers, runtime);
        }

        public async Task<QueryGroupInfoResponse> QueryGroupInfoAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return await QueryGroupInfoWithOptionsAsync(groupId, headers, runtime);
        }

        public QueryGroupInfoResponse QueryGroupInfoWithOptions(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryGroupInfoResponse>(DoROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
        }

        public async Task<QueryGroupInfoResponse> QueryGroupInfoWithOptionsAsync(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryGroupInfoResponse>(await DoROARequestAsync("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
        }

        public QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return QueryHospitalDistrictInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryHospitalDistrictInfoResponse> QueryHospitalDistrictInfoAsync(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return await QueryHospitalDistrictInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(DoROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime));
        }

        public async Task<QueryHospitalDistrictInfoResponse> QueryHospitalDistrictInfoWithOptionsAsync(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(await DoROARequestAsync("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime));
        }

        public QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return QueryHospitalRoleUserInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryHospitalRoleUserInfoResponse> QueryHospitalRoleUserInfoAsync(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return await QueryHospitalRoleUserInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(DoROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime));
        }

        public async Task<QueryHospitalRoleUserInfoResponse> QueryHospitalRoleUserInfoWithOptionsAsync(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(await DoROARequestAsync("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime));
        }

        public QueryHospitalRolesResponse QueryHospitalRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return QueryHospitalRolesWithOptions(headers, runtime);
        }

        public async Task<QueryHospitalRolesResponse> QueryHospitalRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return await QueryHospitalRolesWithOptionsAsync(headers, runtime);
        }

        public QueryHospitalRolesResponse QueryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryHospitalRolesResponse>(DoROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime));
        }

        public async Task<QueryHospitalRolesResponse> QueryHospitalRolesWithOptionsAsync(QueryHospitalRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryHospitalRolesResponse>(await DoROARequestAsync("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime));
        }

        public QueryJobCodeDictionaryResponse QueryJobCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return QueryJobCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryJobCodeDictionaryResponse> QueryJobCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return await QueryJobCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryJobCodeDictionaryResponse QueryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(DoROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime));
        }

        public async Task<QueryJobCodeDictionaryResponse> QueryJobCodeDictionaryWithOptionsAsync(QueryJobCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(await DoROARequestAsync("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime));
        }

        public QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return QueryJobStatusCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryJobStatusCodeDictionaryResponse> QueryJobStatusCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return await QueryJobStatusCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(DoROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime));
        }

        public async Task<QueryJobStatusCodeDictionaryResponse> QueryJobStatusCodeDictionaryWithOptionsAsync(QueryJobStatusCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(await DoROARequestAsync("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime));
        }

        public QueryMedicalEventsResponse QueryMedicalEvents()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return QueryMedicalEventsWithOptions(headers, runtime);
        }

        public async Task<QueryMedicalEventsResponse> QueryMedicalEventsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return await QueryMedicalEventsWithOptionsAsync(headers, runtime);
        }

        public QueryMedicalEventsResponse QueryMedicalEventsWithOptions(QueryMedicalEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryMedicalEventsResponse>(DoROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime));
        }

        public async Task<QueryMedicalEventsResponse> QueryMedicalEventsWithOptionsAsync(QueryMedicalEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryMedicalEventsResponse>(await DoROARequestAsync("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime));
        }

        public QueryUserCredentialsResponse QueryUserCredentials(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return QueryUserCredentialsWithOptions(request, headers, runtime);
        }

        public async Task<QueryUserCredentialsResponse> QueryUserCredentialsAsync(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return await QueryUserCredentialsWithOptionsAsync(request, headers, runtime);
        }

        public QueryUserCredentialsResponse QueryUserCredentialsWithOptions(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<QueryUserCredentialsResponse>(DoROARequest("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime));
        }

        public async Task<QueryUserCredentialsResponse> QueryUserCredentialsWithOptionsAsync(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<QueryUserCredentialsResponse>(await DoROARequestAsync("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime));
        }

        public QueryUserExtInfoResponse QueryUserExtInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return QueryUserExtInfoWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return await QueryUserExtInfoWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserExtInfoResponse QueryUserExtInfoWithOptions(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserExtInfoResponse>(DoROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
        }

        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoWithOptionsAsync(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserExtInfoResponse>(await DoROARequestAsync("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
        }

        public QueryUserExtendValuesResponse QueryUserExtendValues(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return QueryUserExtendValuesWithOptions(request, headers, runtime);
        }

        public async Task<QueryUserExtendValuesResponse> QueryUserExtendValuesAsync(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return await QueryUserExtendValuesWithOptionsAsync(request, headers, runtime);
        }

        public QueryUserExtendValuesResponse QueryUserExtendValuesWithOptions(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                body["userExtendKey"] = request.UserExtendKey;
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
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(DoROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime));
        }

        public async Task<QueryUserExtendValuesResponse> QueryUserExtendValuesWithOptionsAsync(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                body["userExtendKey"] = request.UserExtendKey;
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
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(await DoROARequestAsync("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime));
        }

        public QueryUserInfoResponse QueryUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return QueryUserInfoWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return await QueryUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserInfoResponse QueryUserInfoWithOptions(string userId, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserInfoResponse>(DoROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoWithOptionsAsync(string userId, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserInfoResponse>(await DoROARequestAsync("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
        }

        public QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return QueryUserProbCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryUserProbCodeDictionaryResponse> QueryUserProbCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return await QueryUserProbCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(DoROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime));
        }

        public async Task<QueryUserProbCodeDictionaryResponse> QueryUserProbCodeDictionaryWithOptionsAsync(QueryUserProbCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(await DoROARequestAsync("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime));
        }

        public QueryUserRolesResponse QueryUserRoles(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return QueryUserRolesWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserRolesResponse> QueryUserRolesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return await QueryUserRolesWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserRolesResponse QueryUserRolesWithOptions(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserRolesResponse>(DoROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
        }

        public async Task<QueryUserRolesResponse> QueryUserRolesWithOptionsAsync(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryUserRolesResponse>(await DoROARequestAsync("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
        }

        public SaveUserExtendValuesResponse SaveUserExtendValues(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return SaveUserExtendValuesWithOptions(userId, request, headers, runtime);
        }

        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesAsync(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return await SaveUserExtendValuesWithOptionsAsync(userId, request, headers, runtime);
        }

        public SaveUserExtendValuesResponse SaveUserExtendValuesWithOptions(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["userDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                query["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendValue))
            {
                query["userExtendValue"] = request.UserExtendValue;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(DoROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime));
        }

        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesWithOptionsAsync(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["userDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                query["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendValue))
            {
                query["userExtendValue"] = request.UserExtendValue;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(await DoROARequestAsync("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime));
        }

        public UpdateUserExtendInfoResponse UpdateUserExtendInfo(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return UpdateUserExtendInfoWithOptions(userId, request, headers, runtime);
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoAsync(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return await UpdateUserExtendInfoWithOptionsAsync(userId, request, headers, runtime);
        }

        public UpdateUserExtendInfoResponse UpdateUserExtendInfoWithOptions(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(DoROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoWithOptionsAsync(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(await DoROARequestAsync("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
        }

    }
}
