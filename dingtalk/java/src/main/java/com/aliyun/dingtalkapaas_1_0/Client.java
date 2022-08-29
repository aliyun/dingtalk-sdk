// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkapaas_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public BatchCreateTemplateResponse batchCreateTemplate(BatchCreateTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
        return this.batchCreateTemplateWithOptions(request, headers, runtime);
    }

    public BatchCreateTemplateResponse batchCreateTemplateWithOptions(BatchCreateTemplateRequest request, BatchCreateTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateList)) {
            body.put("templateList", request.templateList);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchCreateTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates", "json", req, runtime), new BatchCreateTemplateResponse());
    }

    public BatchQueryByTemplateKeyResponse batchQueryByTemplateKey(BatchQueryByTemplateKeyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
        return this.batchQueryByTemplateKeyWithOptions(request, headers, runtime);
    }

    public BatchQueryByTemplateKeyResponse batchQueryByTemplateKeyWithOptions(BatchQueryByTemplateKeyRequest request, BatchQueryByTemplateKeyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateKeys)) {
            body.put("templateKeys", request.templateKeys);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchQueryByTemplateKey", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/query", "json", req, runtime), new BatchQueryByTemplateKeyResponse());
    }

    public BatchUpdateTemplateResponse batchUpdateTemplate(BatchUpdateTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
        return this.batchUpdateTemplateWithOptions(request, headers, runtime);
    }

    public BatchUpdateTemplateResponse batchUpdateTemplateWithOptions(BatchUpdateTemplateRequest request, BatchUpdateTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateList)) {
            body.put("templateList", request.templateList);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchUpdateTemplate", "apaas_1.0", "HTTP", "PUT", "AK", "/v1.0/apaas/templates", "json", req, runtime), new BatchUpdateTemplateResponse());
    }

    public QueryIndustryTagListResponse queryIndustryTagList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
        return this.queryIndustryTagListWithOptions(headers, runtime);
    }

    public QueryIndustryTagListResponse queryIndustryTagListWithOptions(QueryIndustryTagListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryIndustryTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/industries", "json", req, runtime), new QueryIndustryTagListResponse());
    }

    public QueryRoleTagListResponse queryRoleTagList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
        return this.queryRoleTagListWithOptions(headers, runtime);
    }

    public QueryRoleTagListResponse queryRoleTagListWithOptions(QueryRoleTagListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryRoleTagList", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/roles", "json", req, runtime), new QueryRoleTagListResponse());
    }

    public QueryTemplateCategorysResponse queryTemplateCategorys() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
        return this.queryTemplateCategorysWithOptions(headers, runtime);
    }

    public QueryTemplateCategorysResponse queryTemplateCategorysWithOptions(QueryTemplateCategorysHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryTemplateCategorys", "apaas_1.0", "HTTP", "GET", "AK", "/v1.0/apaas/templates/categories", "json", req, runtime), new QueryTemplateCategorysResponse());
    }

    public RecallAuditTemplateResponse recallAuditTemplate(RecallAuditTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
        return this.recallAuditTemplateWithOptions(request, headers, runtime);
    }

    public RecallAuditTemplateResponse recallAuditTemplateWithOptions(RecallAuditTemplateRequest request, RecallAuditTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.templateKeys)) {
            body.put("templateKeys", request.templateKeys);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RecallAuditTemplate", "apaas_1.0", "HTTP", "POST", "AK", "/v1.0/apaas/templates/audits/recall", "json", req, runtime), new RecallAuditTemplateResponse());
    }
}
