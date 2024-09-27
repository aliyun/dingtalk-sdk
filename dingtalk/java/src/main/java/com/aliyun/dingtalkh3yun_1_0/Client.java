// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkh3yun_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>批量创建表单业务对象数据</p>
     * 
     * @param request BatchInsertBizObjectRequest
     * @param headers BatchInsertBizObjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchInsertBizObjectResponse
     */
    public BatchInsertBizObjectResponse batchInsertBizObjectWithOptions(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJsonArray)) {
            body.put("bizObjectJsonArray", request.bizObjectJsonArray);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDraft)) {
            body.put("isDraft", request.isDraft);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("action", "BatchInsertBizObject"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchInsertBizObjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量创建表单业务对象数据</p>
     * 
     * @param request BatchInsertBizObjectRequest
     * @return BatchInsertBizObjectResponse
     */
    public BatchInsertBizObjectResponse batchInsertBizObject(BatchInsertBizObjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
        return this.batchInsertBizObjectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消流程实例</p>
     * 
     * @param request CancelProcessInstanceRequest
     * @param headers CancelProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelProcessInstanceResponse
     */
    public CancelProcessInstanceResponse cancelProcessInstanceWithOptions(CancelProcessInstanceRequest request, CancelProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("action", "CancelProcessInstance"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/processes/instances/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消流程实例</p>
     * 
     * @param request CancelProcessInstanceRequest
     * @return CancelProcessInstanceResponse
     */
    public CancelProcessInstanceResponse cancelProcessInstance(CancelProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelProcessInstanceHeaders headers = new CancelProcessInstanceHeaders();
        return this.cancelProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建单条表单业务对象实例</p>
     * 
     * @param request CreateBizObjectRequest
     * @param headers CreateBizObjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateBizObjectResponse
     */
    public CreateBizObjectResponse createBizObjectWithOptions(CreateBizObjectRequest request, CreateBizObjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJson)) {
            body.put("bizObjectJson", request.bizObjectJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDraft)) {
            body.put("isDraft", request.isDraft);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("action", "CreateBizObject"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateBizObjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建单条表单业务对象实例</p>
     * 
     * @param request CreateBizObjectRequest
     * @return CreateBizObjectResponse
     */
    public CreateBizObjectResponse createBizObject(CreateBizObjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
        return this.createBizObjectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程实例</p>
     * 
     * @param request CreateProcessesInstanceRequest
     * @param headers CreateProcessesInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProcessesInstanceResponse
     */
    public CreateProcessesInstanceResponse createProcessesInstanceWithOptions(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            body.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("action", "CreateProcessesInstance"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/processes/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProcessesInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程实例</p>
     * 
     * @param request CreateProcessesInstanceRequest
     * @return CreateProcessesInstanceResponse
     */
    public CreateProcessesInstanceResponse createProcessesInstance(CreateProcessesInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
        return this.createProcessesInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除表单业务对象实例</p>
     * 
     * @param request DeleteBizObjectRequest
     * @param headers DeleteBizObjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteBizObjectResponse
     */
    public DeleteBizObjectResponse deleteBizObjectWithOptions(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteBizObject"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteBizObjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除表单业务对象实例</p>
     * 
     * @param request DeleteBizObjectRequest
     * @return DeleteBizObjectResponse
     */
    public DeleteBizObjectResponse deleteBizObject(DeleteBizObjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
        return this.deleteBizObjectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除流程实例</p>
     * 
     * @param request DeleteProcessesInstanceRequest
     * @param headers DeleteProcessesInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteProcessesInstanceResponse
     */
    public DeleteProcessesInstanceResponse deleteProcessesInstanceWithOptions(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isAutoUpdateBizObject)) {
            query.put("isAutoUpdateBizObject", request.isAutoUpdateBizObject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteProcessesInstance"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/processes/instances"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteProcessesInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除流程实例</p>
     * 
     * @param request DeleteProcessesInstanceRequest
     * @return DeleteProcessesInstanceResponse
     */
    public DeleteProcessesInstanceResponse deleteProcessesInstance(DeleteProcessesInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
        return this.deleteProcessesInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用数据</p>
     * 
     * @param request GetAppsRequest
     * @param headers GetAppsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAppsResponse
     */
    public GetAppsResponse getAppsWithOptions(GetAppsRequest request, GetAppsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.queryType)) {
            body.put("queryType", request.queryType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.values)) {
            body.put("values", request.values);
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
            new TeaPair("action", "GetApps"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/apps/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAppsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用数据</p>
     * 
     * @param request GetAppsRequest
     * @return GetAppsResponse
     */
    public GetAppsResponse getApps(GetAppsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAppsHeaders headers = new GetAppsHeaders();
        return this.getAppsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取附件临时免登地址</p>
     * 
     * @param request GetAttachmentTemporaryUrlRequest
     * @param headers GetAttachmentTemporaryUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAttachmentTemporaryUrlResponse
     */
    public GetAttachmentTemporaryUrlResponse getAttachmentTemporaryUrlWithOptions(GetAttachmentTemporaryUrlRequest request, GetAttachmentTemporaryUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachmentId)) {
            query.put("attachmentId", request.attachmentId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAttachmentTemporaryUrl"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/attachments/temporaryUrls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAttachmentTemporaryUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取附件临时免登地址</p>
     * 
     * @param request GetAttachmentTemporaryUrlRequest
     * @return GetAttachmentTemporaryUrlResponse
     */
    public GetAttachmentTemporaryUrlResponse getAttachmentTemporaryUrl(GetAttachmentTemporaryUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAttachmentTemporaryUrlHeaders headers = new GetAttachmentTemporaryUrlHeaders();
        return this.getAttachmentTemporaryUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织数据</p>
     * 
     * @param request GetOrganizationsRequest
     * @param headers GetOrganizationsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrganizationsResponse
     */
    public GetOrganizationsResponse getOrganizationsWithOptions(GetOrganizationsRequest request, GetOrganizationsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetOrganizations"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/departments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrganizationsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取组织数据</p>
     * 
     * @param request GetOrganizationsRequest
     * @return GetOrganizationsResponse
     */
    public GetOrganizationsResponse getOrganizations(GetOrganizationsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
        return this.getOrganizationsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色用户信息</p>
     * 
     * @param request GetRoleUsersRequest
     * @param headers GetRoleUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRoleUsersResponse
     */
    public GetRoleUsersResponse getRoleUsersWithOptions(GetRoleUsersRequest request, GetRoleUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetRoleUsers"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/roles/roleUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRoleUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色用户信息</p>
     * 
     * @param request GetRoleUsersRequest
     * @return GetRoleUsersResponse
     */
    public GetRoleUsersResponse getRoleUsers(GetRoleUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
        return this.getRoleUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色数据</p>
     * 
     * @param headers GetRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRolesResponse
     */
    public GetRolesResponse getRolesWithOptions(GetRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetRoles"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取角色数据</p>
     * @return GetRolesResponse
     */
    public GetRolesResponse getRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRolesHeaders headers = new GetRolesHeaders();
        return this.getRolesWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件上传地址</p>
     * 
     * @param request GetUploadUrlRequest
     * @param headers GetUploadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUploadUrlResponse
     */
    public GetUploadUrlResponse getUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fieldName)) {
            query.put("fieldName", request.fieldName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isOverwrite)) {
            query.put("isOverwrite", request.isOverwrite);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUploadUrl"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/attachments/uploadUrls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUploadUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件上传地址</p>
     * 
     * @param request GetUploadUrlRequest
     * @return GetUploadUrlResponse
     */
    public GetUploadUrlResponse getUploadUrl(GetUploadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
        return this.getUploadUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户数据</p>
     * 
     * @param request GetUsersRequest
     * @param headers GetUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUsersResponse
     */
    public GetUsersResponse getUsersWithOptions(GetUsersRequest request, GetUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecursive)) {
            query.put("isRecursive", request.isRecursive);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUsers"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户数据</p>
     * 
     * @param request GetUsersRequest
     * @return GetUsersResponse
     */
    public GetUsersResponse getUsers(GetUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUsersHeaders headers = new GetUsersHeaders();
        return this.getUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单业务字段信息</p>
     * 
     * @param request LoadBizFieldsRequest
     * @param headers LoadBizFieldsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LoadBizFieldsResponse
     */
    public LoadBizFieldsResponse loadBizFieldsWithOptions(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "LoadBizFields"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/loadBizFields"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LoadBizFieldsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单业务字段信息</p>
     * 
     * @param request LoadBizFieldsRequest
     * @return LoadBizFieldsResponse
     */
    public LoadBizFieldsResponse loadBizFields(LoadBizFieldsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
        return this.loadBizFieldsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取单条表单业务对象实例</p>
     * 
     * @param request LoadBizObjectRequest
     * @param headers LoadBizObjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LoadBizObjectResponse
     */
    public LoadBizObjectResponse loadBizObjectWithOptions(LoadBizObjectRequest request, LoadBizObjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "LoadBizObject"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances/loadInstances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LoadBizObjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取单条表单业务对象实例</p>
     * 
     * @param request LoadBizObjectRequest
     * @return LoadBizObjectResponse
     */
    public LoadBizObjectResponse loadBizObject(LoadBizObjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
        return this.loadBizObjectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询表单实例列表</p>
     * 
     * @param request LoadBizObjectsRequest
     * @param headers LoadBizObjectsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LoadBizObjectsResponse
     */
    public LoadBizObjectsResponse loadBizObjectsWithOptions(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.matcherJson)) {
            body.put("matcherJson", request.matcherJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.returnFields)) {
            body.put("returnFields", request.returnFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortByFields)) {
            body.put("sortByFields", request.sortByFields);
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
            new TeaPair("action", "LoadBizObjects"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LoadBizObjectsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询表单实例列表</p>
     * 
     * @param request LoadBizObjectsRequest
     * @return LoadBizObjectsResponse
     */
    public LoadBizObjectsResponse loadBizObjects(LoadBizObjectsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
        return this.loadBizObjectsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用的功能节点信息</p>
     * 
     * @param request QueryAppFunctionNodesRequest
     * @param headers QueryAppFunctionNodesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAppFunctionNodesResponse
     */
    public QueryAppFunctionNodesResponse queryAppFunctionNodesWithOptions(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appCode)) {
            query.put("appCode", request.appCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryAppFunctionNodes"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/apps/functionNodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAppFunctionNodesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取应用的功能节点信息</p>
     * 
     * @param request QueryAppFunctionNodesRequest
     * @return QueryAppFunctionNodesResponse
     */
    public QueryAppFunctionNodesResponse queryAppFunctionNodes(QueryAppFunctionNodesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
        return this.queryAppFunctionNodesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程实例</p>
     * 
     * @param request QueryProcessesInstanceRequest
     * @param headers QueryProcessesInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProcessesInstanceResponse
     */
    public QueryProcessesInstanceResponse queryProcessesInstanceWithOptions(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryProcessesInstance"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/processes/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProcessesInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程实例</p>
     * 
     * @param request QueryProcessesInstanceRequest
     * @return QueryProcessesInstanceResponse
     */
    public QueryProcessesInstanceResponse queryProcessesInstance(QueryProcessesInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
        return this.queryProcessesInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程实例节点工作项</p>
     * 
     * @param request QueryProcessesWorkItemsRequest
     * @param headers QueryProcessesWorkItemsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProcessesWorkItemsResponse
     */
    public QueryProcessesWorkItemsResponse queryProcessesWorkItemsWithOptions(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryProcessesWorkItems"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/processes/workItems"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProcessesWorkItemsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程实例节点工作项</p>
     * 
     * @param request QueryProcessesWorkItemsRequest
     * @return QueryProcessesWorkItemsResponse
     */
    public QueryProcessesWorkItemsResponse queryProcessesWorkItems(QueryProcessesWorkItemsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
        return this.queryProcessesWorkItemsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改表单业务对象数据</p>
     * 
     * @param request UpdateBizObjectRequest
     * @param headers UpdateBizObjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateBizObjectResponse
     */
    public UpdateBizObjectResponse updateBizObjectWithOptions(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            body.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJson)) {
            body.put("bizObjectJson", request.bizObjectJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("action", "UpdateBizObject"),
            new TeaPair("version", "h3yun_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/h3yun/forms/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateBizObjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改表单业务对象数据</p>
     * 
     * @param request UpdateBizObjectRequest
     * @return UpdateBizObjectResponse
     */
    public UpdateBizObjectResponse updateBizObject(UpdateBizObjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
        return this.updateBizObjectWithOptions(request, headers, runtime);
    }
}
