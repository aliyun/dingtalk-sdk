// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0
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


        public BatchInsertBizObjectResponse BatchInsertBizObject(BatchInsertBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
            return BatchInsertBizObjectWithOptions(request, headers, runtime);
        }

        public async Task<BatchInsertBizObjectResponse> BatchInsertBizObjectAsync(BatchInsertBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
            return await BatchInsertBizObjectWithOptionsAsync(request, headers, runtime);
        }

        public BatchInsertBizObjectResponse BatchInsertBizObjectWithOptions(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJsonArray))
            {
                body["bizObjectJsonArray"] = request.BizObjectJsonArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<BatchInsertBizObjectResponse>(DoROARequest("BatchInsertBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/batch", "json", req, runtime));
        }

        public async Task<BatchInsertBizObjectResponse> BatchInsertBizObjectWithOptionsAsync(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJsonArray))
            {
                body["bizObjectJsonArray"] = request.BizObjectJsonArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<BatchInsertBizObjectResponse>(await DoROARequestAsync("BatchInsertBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/batch", "json", req, runtime));
        }

        public CreateBizObjectResponse CreateBizObject(CreateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
            return CreateBizObjectWithOptions(request, headers, runtime);
        }

        public async Task<CreateBizObjectResponse> CreateBizObjectAsync(CreateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
            return await CreateBizObjectWithOptionsAsync(request, headers, runtime);
        }

        public CreateBizObjectResponse CreateBizObjectWithOptions(CreateBizObjectRequest request, CreateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<CreateBizObjectResponse>(DoROARequest("CreateBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

        public async Task<CreateBizObjectResponse> CreateBizObjectWithOptionsAsync(CreateBizObjectRequest request, CreateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                body["isDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<CreateBizObjectResponse>(await DoROARequestAsync("CreateBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

        public CreateProcessesInstanceResponse CreateProcessesInstance(CreateProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
            return CreateProcessesInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateProcessesInstanceResponse> CreateProcessesInstanceAsync(CreateProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
            return await CreateProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateProcessesInstanceResponse CreateProcessesInstanceWithOptions(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<CreateProcessesInstanceResponse>(DoROARequest("CreateProcessesInstance", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public async Task<CreateProcessesInstanceResponse> CreateProcessesInstanceWithOptionsAsync(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserId))
            {
                body["opUserId"] = request.OpUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<CreateProcessesInstanceResponse>(await DoROARequestAsync("CreateProcessesInstance", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public DeleteBizObjectResponse DeleteBizObject(DeleteBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
            return DeleteBizObjectWithOptions(request, headers, runtime);
        }

        public async Task<DeleteBizObjectResponse> DeleteBizObjectAsync(DeleteBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
            return await DeleteBizObjectWithOptionsAsync(request, headers, runtime);
        }

        public DeleteBizObjectResponse DeleteBizObjectWithOptions(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<DeleteBizObjectResponse>(DoROARequest("DeleteBizObject", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

        public async Task<DeleteBizObjectResponse> DeleteBizObjectWithOptionsAsync(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<DeleteBizObjectResponse>(await DoROARequestAsync("DeleteBizObject", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

        public DeleteProcessesInstanceResponse DeleteProcessesInstance(DeleteProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
            return DeleteProcessesInstanceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteProcessesInstanceResponse> DeleteProcessesInstanceAsync(DeleteProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
            return await DeleteProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteProcessesInstanceResponse DeleteProcessesInstanceWithOptions(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoUpdateBizObject))
            {
                query["isAutoUpdateBizObject"] = request.IsAutoUpdateBizObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
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
            return TeaModel.ToObject<DeleteProcessesInstanceResponse>(DoROARequest("DeleteProcessesInstance", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public async Task<DeleteProcessesInstanceResponse> DeleteProcessesInstanceWithOptionsAsync(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAutoUpdateBizObject))
            {
                query["isAutoUpdateBizObject"] = request.IsAutoUpdateBizObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
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
            return TeaModel.ToObject<DeleteProcessesInstanceResponse>(await DoROARequestAsync("DeleteProcessesInstance", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public GetAppsResponse GetApps(GetAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppsHeaders headers = new GetAppsHeaders();
            return GetAppsWithOptions(request, headers, runtime);
        }

        public async Task<GetAppsResponse> GetAppsAsync(GetAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAppsHeaders headers = new GetAppsHeaders();
            return await GetAppsWithOptionsAsync(request, headers, runtime);
        }

        public GetAppsResponse GetAppsWithOptions(GetAppsRequest request, GetAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
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
            return TeaModel.ToObject<GetAppsResponse>(DoROARequest("GetApps", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/apps/search", "json", req, runtime));
        }

        public async Task<GetAppsResponse> GetAppsWithOptionsAsync(GetAppsRequest request, GetAppsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Values))
            {
                body["values"] = request.Values;
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
            return TeaModel.ToObject<GetAppsResponse>(await DoROARequestAsync("GetApps", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/apps/search", "json", req, runtime));
        }

        public GetOrganizationsResponse GetOrganizations(GetOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
            return GetOrganizationsWithOptions(request, headers, runtime);
        }

        public async Task<GetOrganizationsResponse> GetOrganizationsAsync(GetOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
            return await GetOrganizationsWithOptionsAsync(request, headers, runtime);
        }

        public GetOrganizationsResponse GetOrganizationsWithOptions(GetOrganizationsRequest request, GetOrganizationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<GetOrganizationsResponse>(DoROARequest("GetOrganizations", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/departments", "json", req, runtime));
        }

        public async Task<GetOrganizationsResponse> GetOrganizationsWithOptionsAsync(GetOrganizationsRequest request, GetOrganizationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
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
            return TeaModel.ToObject<GetOrganizationsResponse>(await DoROARequestAsync("GetOrganizations", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/departments", "json", req, runtime));
        }

        public GetRoleUsersResponse GetRoleUsers(GetRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
            return GetRoleUsersWithOptions(request, headers, runtime);
        }

        public async Task<GetRoleUsersResponse> GetRoleUsersAsync(GetRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
            return await GetRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        public GetRoleUsersResponse GetRoleUsersWithOptions(GetRoleUsersRequest request, GetRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
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
            return TeaModel.ToObject<GetRoleUsersResponse>(DoROARequest("GetRoleUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles/roleUsers", "json", req, runtime));
        }

        public async Task<GetRoleUsersResponse> GetRoleUsersWithOptionsAsync(GetRoleUsersRequest request, GetRoleUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
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
            return TeaModel.ToObject<GetRoleUsersResponse>(await DoROARequestAsync("GetRoleUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles/roleUsers", "json", req, runtime));
        }

        public GetRolesResponse GetRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRolesHeaders headers = new GetRolesHeaders();
            return GetRolesWithOptions(headers, runtime);
        }

        public async Task<GetRolesResponse> GetRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRolesHeaders headers = new GetRolesHeaders();
            return await GetRolesWithOptionsAsync(headers, runtime);
        }

        public GetRolesResponse GetRolesWithOptions(GetRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetRolesResponse>(DoROARequest("GetRoles", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles", "json", req, runtime));
        }

        public async Task<GetRolesResponse> GetRolesWithOptionsAsync(GetRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetRolesResponse>(await DoROARequestAsync("GetRoles", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles", "json", req, runtime));
        }

        public GetUsersResponse GetUsers(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUsersHeaders headers = new GetUsersHeaders();
            return GetUsersWithOptions(request, headers, runtime);
        }

        public async Task<GetUsersResponse> GetUsersAsync(GetUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUsersHeaders headers = new GetUsersHeaders();
            return await GetUsersWithOptionsAsync(request, headers, runtime);
        }

        public GetUsersResponse GetUsersWithOptions(GetUsersRequest request, GetUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecursive))
            {
                query["isRecursive"] = request.IsRecursive;
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
            return TeaModel.ToObject<GetUsersResponse>(DoROARequest("GetUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/users", "json", req, runtime));
        }

        public async Task<GetUsersResponse> GetUsersWithOptionsAsync(GetUsersRequest request, GetUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecursive))
            {
                query["isRecursive"] = request.IsRecursive;
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
            return TeaModel.ToObject<GetUsersResponse>(await DoROARequestAsync("GetUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/users", "json", req, runtime));
        }

        public LoadBizFieldsResponse LoadBizFields(LoadBizFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
            return LoadBizFieldsWithOptions(request, headers, runtime);
        }

        public async Task<LoadBizFieldsResponse> LoadBizFieldsAsync(LoadBizFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
            return await LoadBizFieldsWithOptionsAsync(request, headers, runtime);
        }

        public LoadBizFieldsResponse LoadBizFieldsWithOptions(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<LoadBizFieldsResponse>(DoROARequest("LoadBizFields", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/loadBizFields", "json", req, runtime));
        }

        public async Task<LoadBizFieldsResponse> LoadBizFieldsWithOptionsAsync(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<LoadBizFieldsResponse>(await DoROARequestAsync("LoadBizFields", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/loadBizFields", "json", req, runtime));
        }

        public LoadBizObjectResponse LoadBizObject(LoadBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
            return LoadBizObjectWithOptions(request, headers, runtime);
        }

        public async Task<LoadBizObjectResponse> LoadBizObjectAsync(LoadBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
            return await LoadBizObjectWithOptionsAsync(request, headers, runtime);
        }

        public LoadBizObjectResponse LoadBizObjectWithOptions(LoadBizObjectRequest request, LoadBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<LoadBizObjectResponse>(DoROARequest("LoadBizObject", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/instances/loadInstances", "json", req, runtime));
        }

        public async Task<LoadBizObjectResponse> LoadBizObjectWithOptionsAsync(LoadBizObjectRequest request, LoadBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<LoadBizObjectResponse>(await DoROARequestAsync("LoadBizObject", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/instances/loadInstances", "json", req, runtime));
        }

        public LoadBizObjectsResponse LoadBizObjects(LoadBizObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
            return LoadBizObjectsWithOptions(request, headers, runtime);
        }

        public async Task<LoadBizObjectsResponse> LoadBizObjectsAsync(LoadBizObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
            return await LoadBizObjectsWithOptionsAsync(request, headers, runtime);
        }

        public LoadBizObjectsResponse LoadBizObjectsWithOptions(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatcherJson))
            {
                body["matcherJson"] = request.MatcherJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                body["returnFields"] = request.ReturnFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByFields))
            {
                body["sortByFields"] = request.SortByFields;
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
            return TeaModel.ToObject<LoadBizObjectsResponse>(DoROARequest("LoadBizObjects", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/search", "json", req, runtime));
        }

        public async Task<LoadBizObjectsResponse> LoadBizObjectsWithOptionsAsync(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatcherJson))
            {
                body["matcherJson"] = request.MatcherJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnFields))
            {
                body["returnFields"] = request.ReturnFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByFields))
            {
                body["sortByFields"] = request.SortByFields;
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
            return TeaModel.ToObject<LoadBizObjectsResponse>(await DoROARequestAsync("LoadBizObjects", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/search", "json", req, runtime));
        }

        public QueryAppFunctionNodesResponse QueryAppFunctionNodes(QueryAppFunctionNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
            return QueryAppFunctionNodesWithOptions(request, headers, runtime);
        }

        public async Task<QueryAppFunctionNodesResponse> QueryAppFunctionNodesAsync(QueryAppFunctionNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
            return await QueryAppFunctionNodesWithOptionsAsync(request, headers, runtime);
        }

        public QueryAppFunctionNodesResponse QueryAppFunctionNodesWithOptions(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
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
            return TeaModel.ToObject<QueryAppFunctionNodesResponse>(DoROARequest("QueryAppFunctionNodes", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/apps/functionNodes", "json", req, runtime));
        }

        public async Task<QueryAppFunctionNodesResponse> QueryAppFunctionNodesWithOptionsAsync(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCode))
            {
                query["appCode"] = request.AppCode;
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
            return TeaModel.ToObject<QueryAppFunctionNodesResponse>(await DoROARequestAsync("QueryAppFunctionNodes", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/apps/functionNodes", "json", req, runtime));
        }

        public QueryProcessesInstanceResponse QueryProcessesInstance(QueryProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
            return QueryProcessesInstanceWithOptions(request, headers, runtime);
        }

        public async Task<QueryProcessesInstanceResponse> QueryProcessesInstanceAsync(QueryProcessesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
            return await QueryProcessesInstanceWithOptionsAsync(request, headers, runtime);
        }

        public QueryProcessesInstanceResponse QueryProcessesInstanceWithOptions(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<QueryProcessesInstanceResponse>(DoROARequest("QueryProcessesInstance", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public async Task<QueryProcessesInstanceResponse> QueryProcessesInstanceWithOptionsAsync(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                query["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                query["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<QueryProcessesInstanceResponse>(await DoROARequestAsync("QueryProcessesInstance", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime));
        }

        public QueryProcessesWorkItemsResponse QueryProcessesWorkItems(QueryProcessesWorkItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
            return QueryProcessesWorkItemsWithOptions(request, headers, runtime);
        }

        public async Task<QueryProcessesWorkItemsResponse> QueryProcessesWorkItemsAsync(QueryProcessesWorkItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
            return await QueryProcessesWorkItemsWithOptionsAsync(request, headers, runtime);
        }

        public QueryProcessesWorkItemsResponse QueryProcessesWorkItemsWithOptions(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
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
            return TeaModel.ToObject<QueryProcessesWorkItemsResponse>(DoROARequest("QueryProcessesWorkItems", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/workItems", "json", req, runtime));
        }

        public async Task<QueryProcessesWorkItemsResponse> QueryProcessesWorkItemsWithOptionsAsync(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["processInstanceId"] = request.ProcessInstanceId;
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
            return TeaModel.ToObject<QueryProcessesWorkItemsResponse>(await DoROARequestAsync("QueryProcessesWorkItems", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/workItems", "json", req, runtime));
        }

        public UpdateBizObjectResponse UpdateBizObject(UpdateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
            return UpdateBizObjectWithOptions(request, headers, runtime);
        }

        public async Task<UpdateBizObjectResponse> UpdateBizObjectAsync(UpdateBizObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
            return await UpdateBizObjectWithOptionsAsync(request, headers, runtime);
        }

        public UpdateBizObjectResponse UpdateBizObjectWithOptions(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<UpdateBizObjectResponse>(DoROARequest("UpdateBizObject", "h3yun_1.0", "HTTP", "PUT", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

        public async Task<UpdateBizObjectResponse> UpdateBizObjectWithOptionsAsync(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectId))
            {
                body["bizObjectId"] = request.BizObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizObjectJson))
            {
                body["bizObjectJson"] = request.BizObjectJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaCode))
            {
                body["schemaCode"] = request.SchemaCode;
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
            return TeaModel.ToObject<UpdateBizObjectResponse>(await DoROARequestAsync("UpdateBizObject", "h3yun_1.0", "HTTP", "PUT", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime));
        }

    }
}
