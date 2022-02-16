// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkapaas_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0
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


        public BatchCreateTemplateResponse BatchCreateTemplate(BatchCreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
            return BatchCreateTemplateWithOptions(request, headers, runtime);
        }

        public async Task<BatchCreateTemplateResponse> BatchCreateTemplateAsync(BatchCreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
            return await BatchCreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        public BatchCreateTemplateResponse BatchCreateTemplateWithOptions(BatchCreateTemplateRequest request, BatchCreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
            return TeaModel.ToObject<BatchCreateTemplateResponse>(DoROARequest("BatchCreateTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates", "json", req, runtime));
        }

        public async Task<BatchCreateTemplateResponse> BatchCreateTemplateWithOptionsAsync(BatchCreateTemplateRequest request, BatchCreateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
            return TeaModel.ToObject<BatchCreateTemplateResponse>(await DoROARequestAsync("BatchCreateTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates", "json", req, runtime));
        }

        public BatchQueryByTemplateKeyResponse BatchQueryByTemplateKey(BatchQueryByTemplateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
            return BatchQueryByTemplateKeyWithOptions(request, headers, runtime);
        }

        public async Task<BatchQueryByTemplateKeyResponse> BatchQueryByTemplateKeyAsync(BatchQueryByTemplateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
            return await BatchQueryByTemplateKeyWithOptionsAsync(request, headers, runtime);
        }

        public BatchQueryByTemplateKeyResponse BatchQueryByTemplateKeyWithOptions(BatchQueryByTemplateKeyRequest request, BatchQueryByTemplateKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
            return TeaModel.ToObject<BatchQueryByTemplateKeyResponse>(DoROARequest("BatchQueryByTemplateKey", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/query", "json", req, runtime));
        }

        public async Task<BatchQueryByTemplateKeyResponse> BatchQueryByTemplateKeyWithOptionsAsync(BatchQueryByTemplateKeyRequest request, BatchQueryByTemplateKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
            return TeaModel.ToObject<BatchQueryByTemplateKeyResponse>(await DoROARequestAsync("BatchQueryByTemplateKey", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/query", "json", req, runtime));
        }

        public BatchUpdateTemplateResponse BatchUpdateTemplate(BatchUpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
            return BatchUpdateTemplateWithOptions(request, headers, runtime);
        }

        public async Task<BatchUpdateTemplateResponse> BatchUpdateTemplateAsync(BatchUpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
            return await BatchUpdateTemplateWithOptionsAsync(request, headers, runtime);
        }

        public BatchUpdateTemplateResponse BatchUpdateTemplateWithOptions(BatchUpdateTemplateRequest request, BatchUpdateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
            return TeaModel.ToObject<BatchUpdateTemplateResponse>(DoROARequest("BatchUpdateTemplate", "apaas_1.0", "HTTP", "PUT", "AK", "/v1.0/apaas/templates", "json", req, runtime));
        }

        public async Task<BatchUpdateTemplateResponse> BatchUpdateTemplateWithOptionsAsync(BatchUpdateTemplateRequest request, BatchUpdateTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateList))
            {
                body["templateList"] = request.TemplateList;
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
            return TeaModel.ToObject<BatchUpdateTemplateResponse>(await DoROARequestAsync("BatchUpdateTemplate", "apaas_1.0", "HTTP", "PUT", "AK", "/v1.0/apaas/templates", "json", req, runtime));
        }

        public QueryIndustryTagListResponse QueryIndustryTagList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
            return QueryIndustryTagListWithOptions(headers, runtime);
        }

        public async Task<QueryIndustryTagListResponse> QueryIndustryTagListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
            return await QueryIndustryTagListWithOptionsAsync(headers, runtime);
        }

        public QueryIndustryTagListResponse QueryIndustryTagListWithOptions(QueryIndustryTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryIndustryTagListResponse>(DoROARequest("QueryIndustryTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/industries", "json", req, runtime));
        }

        public async Task<QueryIndustryTagListResponse> QueryIndustryTagListWithOptionsAsync(QueryIndustryTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryIndustryTagListResponse>(await DoROARequestAsync("QueryIndustryTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/industries", "json", req, runtime));
        }

        public QueryRoleTagListResponse QueryRoleTagList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
            return QueryRoleTagListWithOptions(headers, runtime);
        }

        public async Task<QueryRoleTagListResponse> QueryRoleTagListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
            return await QueryRoleTagListWithOptionsAsync(headers, runtime);
        }

        public QueryRoleTagListResponse QueryRoleTagListWithOptions(QueryRoleTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryRoleTagListResponse>(DoROARequest("QueryRoleTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/roles", "json", req, runtime));
        }

        public async Task<QueryRoleTagListResponse> QueryRoleTagListWithOptionsAsync(QueryRoleTagListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryRoleTagListResponse>(await DoROARequestAsync("QueryRoleTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/roles", "json", req, runtime));
        }

        public QueryTemplateCategorysResponse QueryTemplateCategorys()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
            return QueryTemplateCategorysWithOptions(headers, runtime);
        }

        public async Task<QueryTemplateCategorysResponse> QueryTemplateCategorysAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
            return await QueryTemplateCategorysWithOptionsAsync(headers, runtime);
        }

        public QueryTemplateCategorysResponse QueryTemplateCategorysWithOptions(QueryTemplateCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryTemplateCategorysResponse>(DoROARequest("QueryTemplateCategorys", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/categories", "json", req, runtime));
        }

        public async Task<QueryTemplateCategorysResponse> QueryTemplateCategorysWithOptionsAsync(QueryTemplateCategorysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryTemplateCategorysResponse>(await DoROARequestAsync("QueryTemplateCategorys", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/categories", "json", req, runtime));
        }

        public RecallAuditTemplateResponse RecallAuditTemplate(RecallAuditTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
            return RecallAuditTemplateWithOptions(request, headers, runtime);
        }

        public async Task<RecallAuditTemplateResponse> RecallAuditTemplateAsync(RecallAuditTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
            return await RecallAuditTemplateWithOptionsAsync(request, headers, runtime);
        }

        public RecallAuditTemplateResponse RecallAuditTemplateWithOptions(RecallAuditTemplateRequest request, RecallAuditTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
            return TeaModel.ToObject<RecallAuditTemplateResponse>(DoROARequest("RecallAuditTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/audits/recall", "json", req, runtime));
        }

        public async Task<RecallAuditTemplateResponse> RecallAuditTemplateWithOptionsAsync(RecallAuditTemplateRequest request, RecallAuditTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateKeys))
            {
                body["templateKeys"] = request.TemplateKeys;
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
            return TeaModel.ToObject<RecallAuditTemplateResponse>(await DoROARequestAsync("RecallAuditTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/audits/recall", "json", req, runtime));
        }

    }
}
