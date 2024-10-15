// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkapaas_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>批量创建模板</p>
     * 
     * @param request BatchCreateTemplateRequest
     * @param headers BatchCreateTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateTemplateResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchCreateTemplate"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建模板</p>
     * 
     * @param request BatchCreateTemplateRequest
     * @return BatchCreateTemplateResponse
     */
    public BatchCreateTemplateResponse batchCreateTemplate(BatchCreateTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateTemplateHeaders headers = new BatchCreateTemplateHeaders();
        return this.batchCreateTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询模板</p>
     * 
     * @param request BatchQueryByTemplateKeyRequest
     * @param headers BatchQueryByTemplateKeyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryByTemplateKeyResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchQueryByTemplateKey"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryByTemplateKeyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询模板</p>
     * 
     * @param request BatchQueryByTemplateKeyRequest
     * @return BatchQueryByTemplateKeyResponse
     */
    public BatchQueryByTemplateKeyResponse batchQueryByTemplateKey(BatchQueryByTemplateKeyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryByTemplateKeyHeaders headers = new BatchQueryByTemplateKeyHeaders();
        return this.batchQueryByTemplateKeyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改模板</p>
     * 
     * @param request BatchUpdateTemplateRequest
     * @param headers BatchUpdateTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateTemplateResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchUpdateTemplate"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量修改模板</p>
     * 
     * @param request BatchUpdateTemplateRequest
     * @return BatchUpdateTemplateResponse
     */
    public BatchUpdateTemplateResponse batchUpdateTemplate(BatchUpdateTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateTemplateHeaders headers = new BatchUpdateTemplateHeaders();
        return this.batchUpdateTemplateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询行业标签</p>
     * 
     * @param headers QueryIndustryTagListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryIndustryTagListResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryIndustryTagList"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates/industries"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryIndustryTagListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询行业标签</p>
     * @return QueryIndustryTagListResponse
     */
    public QueryIndustryTagListResponse queryIndustryTagList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryIndustryTagListHeaders headers = new QueryIndustryTagListHeaders();
        return this.queryIndustryTagListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询角色</p>
     * 
     * @param headers QueryRoleTagListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRoleTagListResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryRoleTagList"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRoleTagListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询角色</p>
     * @return QueryRoleTagListResponse
     */
    public QueryRoleTagListResponse queryRoleTagList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRoleTagListHeaders headers = new QueryRoleTagListHeaders();
        return this.queryRoleTagListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询模板分类</p>
     * 
     * @param headers QueryTemplateCategorysHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTemplateCategorysResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryTemplateCategorys"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates/categories"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTemplateCategorysResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询模板分类</p>
     * @return QueryTemplateCategorysResponse
     */
    public QueryTemplateCategorysResponse queryTemplateCategorys() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTemplateCategorysHeaders headers = new QueryTemplateCategorysHeaders();
        return this.queryTemplateCategorysWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤回模板审核</p>
     * 
     * @param request RecallAuditTemplateRequest
     * @param headers RecallAuditTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RecallAuditTemplateResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RecallAuditTemplate"),
            new TeaPair("version", "apaas_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/apaas/templates/audits/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RecallAuditTemplateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤回模板审核</p>
     * 
     * @param request RecallAuditTemplateRequest
     * @return RecallAuditTemplateResponse
     */
    public RecallAuditTemplateResponse recallAuditTemplate(RecallAuditTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecallAuditTemplateHeaders headers = new RecallAuditTemplateHeaders();
        return this.recallAuditTemplateWithOptions(request, headers, runtime);
    }
}
