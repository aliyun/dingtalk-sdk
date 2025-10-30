// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalknotable_1_0.models.*;

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
     * <p>新增数据表字段</p>
     * 
     * @param request CreateFieldRequest
     * @param headers CreateFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateFieldResponse
     */
    public CreateFieldResponse createFieldWithOptions(String baseId, String sheetIdOrName, CreateFieldRequest request, CreateFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.property)) {
            body.put("property", request.property);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateField"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateFieldResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增数据表字段</p>
     * 
     * @param request CreateFieldRequest
     * @return CreateFieldResponse
     */
    public CreateFieldResponse createField(String baseId, String sheetIdOrName, CreateFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateFieldHeaders headers = new CreateFieldHeaders();
        return this.createFieldWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建数据表</p>
     * 
     * @param request CreateSheetRequest
     * @param headers CreateSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSheetResponse
     */
    public CreateSheetResponse createSheetWithOptions(String baseId, CreateSheetRequest request, CreateSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fields)) {
            body.put("fields", request.fields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateSheet"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSheetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建数据表</p>
     * 
     * @param request CreateSheetRequest
     * @return CreateSheetResponse
     */
    public CreateSheetResponse createSheet(String baseId, CreateSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSheetHeaders headers = new CreateSheetHeaders();
        return this.createSheetWithOptions(baseId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表字段</p>
     * 
     * @param request DeleteFieldRequest
     * @param headers DeleteFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteFieldResponse
     */
    public DeleteFieldResponse deleteFieldWithOptions(String baseId, String sheetIdOrName, String fieldIdOrName, DeleteFieldRequest request, DeleteFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "DeleteField"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteFieldResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表字段</p>
     * 
     * @param request DeleteFieldRequest
     * @return DeleteFieldResponse
     */
    public DeleteFieldResponse deleteField(String baseId, String sheetIdOrName, String fieldIdOrName, DeleteFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteFieldHeaders headers = new DeleteFieldHeaders();
        return this.deleteFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表多行记录</p>
     * 
     * @param request DeleteRecordsRequest
     * @param headers DeleteRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRecordsResponse
     */
    public DeleteRecordsResponse deleteRecordsWithOptions(String baseId, String sheetIdOrName, DeleteRecordsRequest request, DeleteRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recordIds)) {
            body.put("recordIds", request.recordIds);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteRecords"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/delete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表多行记录</p>
     * 
     * @param request DeleteRecordsRequest
     * @return DeleteRecordsResponse
     */
    public DeleteRecordsResponse deleteRecords(String baseId, String sheetIdOrName, DeleteRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRecordsHeaders headers = new DeleteRecordsHeaders();
        return this.deleteRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表</p>
     * 
     * @param request DeleteSheetRequest
     * @param headers DeleteSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSheetResponse
     */
    public DeleteSheetResponse deleteSheetWithOptions(String baseId, String sheetIdOrName, DeleteSheetRequest request, DeleteSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "DeleteSheet"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSheetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据表</p>
     * 
     * @param request DeleteSheetRequest
     * @return DeleteSheetResponse
     */
    public DeleteSheetResponse deleteSheet(String baseId, String sheetIdOrName, DeleteSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSheetHeaders headers = new DeleteSheetHeaders();
        return this.deleteSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取所有字段</p>
     * 
     * @param request GetAllFieldsRequest
     * @param headers GetAllFieldsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllFieldsResponse
     */
    public GetAllFieldsResponse getAllFieldsWithOptions(String baseId, String sheetIdOrName, GetAllFieldsRequest request, GetAllFieldsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetAllFields"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllFieldsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取所有字段</p>
     * 
     * @param request GetAllFieldsRequest
     * @return GetAllFieldsResponse
     */
    public GetAllFieldsResponse getAllFields(String baseId, String sheetIdOrName, GetAllFieldsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllFieldsHeaders headers = new GetAllFieldsHeaders();
        return this.getAllFieldsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取所有数据表</p>
     * 
     * @param request GetAllSheetsRequest
     * @param headers GetAllSheetsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAllSheetsResponse
     */
    public GetAllSheetsResponse getAllSheetsWithOptions(String baseId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetAllSheets"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAllSheetsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取所有数据表</p>
     * 
     * @param request GetAllSheetsRequest
     * @return GetAllSheetsResponse
     */
    public GetAllSheetsResponse getAllSheets(String baseId, GetAllSheetsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
        return this.getAllSheetsWithOptions(baseId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取记录</p>
     * 
     * @param request GetRecordRequest
     * @param headers GetRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecordResponse
     */
    public GetRecordResponse getRecordWithOptions(String baseId, String sheetIdOrName, String recordId, GetRecordRequest request, GetRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetRecord"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/" + recordId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取记录</p>
     * 
     * @param request GetRecordRequest
     * @return GetRecordResponse
     */
    public GetRecordResponse getRecord(String baseId, String sheetIdOrName, String recordId, GetRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecordHeaders headers = new GetRecordHeaders();
        return this.getRecordWithOptions(baseId, sheetIdOrName, recordId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取多行记录</p>
     * 
     * @param request GetRecordsRequest
     * @param headers GetRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecordsResponse
     */
    public GetRecordsResponse getRecordsWithOptions(String baseId, String sheetIdOrName, GetRecordsRequest request, GetRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetRecords"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取多行记录</p>
     * 
     * @param request GetRecordsRequest
     * @return GetRecordsResponse
     */
    public GetRecordsResponse getRecords(String baseId, String sheetIdOrName, GetRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecordsHeaders headers = new GetRecordsHeaders();
        return this.getRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据表</p>
     * 
     * @param request GetSheetRequest
     * @param headers GetSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSheetResponse
     */
    public GetSheetResponse getSheetWithOptions(String baseId, String sheetIdOrName, GetSheetRequest request, GetSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "GetSheet"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSheetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据表</p>
     * 
     * @param request GetSheetRequest
     * @return GetSheetResponse
     */
    public GetSheetResponse getSheet(String baseId, String sheetIdOrName, GetSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSheetHeaders headers = new GetSheetHeaders();
        return this.getSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增记录</p>
     * 
     * @param request InsertRecordsRequest
     * @param headers InsertRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertRecordsResponse
     */
    public InsertRecordsResponse insertRecordsWithOptions(String baseId, String sheetIdOrName, InsertRecordsRequest request, InsertRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.records)) {
            body.put("records", request.records);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "InsertRecords"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增记录</p>
     * 
     * @param request InsertRecordsRequest
     * @return InsertRecordsResponse
     */
    public InsertRecordsResponse insertRecords(String baseId, String sheetIdOrName, InsertRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertRecordsHeaders headers = new InsertRecordsHeaders();
        return this.insertRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>列出多行记录</p>
     * 
     * @param request ListRecordsRequest
     * @param headers ListRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRecordsResponse
     */
    public ListRecordsResponse listRecordsWithOptions(String baseId, String sheetIdOrName, ListRecordsRequest request, ListRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.calcFields)) {
            body.put("calcFields", request.calcFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.filter)) {
            body.put("filter", request.filter);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListRecords"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>列出多行记录</p>
     * 
     * @param request ListRecordsRequest
     * @return ListRecordsResponse
     */
    public ListRecordsResponse listRecords(String baseId, String sheetIdOrName, ListRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRecordsHeaders headers = new ListRecordsHeaders();
        return this.listRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>富文本值预处理</p>
     * 
     * @param request PrepareSetRichTextRequest
     * @param headers PrepareSetRichTextHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PrepareSetRichTextResponse
     */
    public PrepareSetRichTextResponse prepareSetRichTextWithOptions(String baseId, PrepareSetRichTextRequest request, PrepareSetRichTextHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.markdown)) {
            body.put("markdown", request.markdown);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PrepareSetRichText"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/prepareSetRichText"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PrepareSetRichTextResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>富文本值预处理</p>
     * 
     * @param request PrepareSetRichTextRequest
     * @return PrepareSetRichTextResponse
     */
    public PrepareSetRichTextResponse prepareSetRichText(String baseId, PrepareSetRichTextRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PrepareSetRichTextHeaders headers = new PrepareSetRichTextHeaders();
        return this.prepareSetRichTextWithOptions(baseId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表字段</p>
     * 
     * @param request UpdateFieldRequest
     * @param headers UpdateFieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFieldResponse
     */
    public UpdateFieldResponse updateFieldWithOptions(String baseId, String sheetIdOrName, String fieldIdOrName, UpdateFieldRequest request, UpdateFieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.property)) {
            body.put("property", request.property);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateField"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFieldResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表字段</p>
     * 
     * @param request UpdateFieldRequest
     * @return UpdateFieldResponse
     */
    public UpdateFieldResponse updateField(String baseId, String sheetIdOrName, String fieldIdOrName, UpdateFieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFieldHeaders headers = new UpdateFieldHeaders();
        return this.updateFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表多行记录</p>
     * 
     * @param request UpdateRecordsRequest
     * @param headers UpdateRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateRecordsResponse
     */
    public UpdateRecordsResponse updateRecordsWithOptions(String baseId, String sheetIdOrName, UpdateRecordsRequest request, UpdateRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.records)) {
            body.put("records", request.records);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateRecords"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表多行记录</p>
     * 
     * @param request UpdateRecordsRequest
     * @return UpdateRecordsResponse
     */
    public UpdateRecordsResponse updateRecords(String baseId, String sheetIdOrName, UpdateRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateRecordsHeaders headers = new UpdateRecordsHeaders();
        return this.updateRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表</p>
     * 
     * @param request UpdateSheetRequest
     * @param headers UpdateSheetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateSheetResponse
     */
    public UpdateSheetResponse updateSheetWithOptions(String baseId, String sheetIdOrName, UpdateSheetRequest request, UpdateSheetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateSheet"),
            new TeaPair("version", "notable_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateSheetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新数据表</p>
     * 
     * @param request UpdateSheetRequest
     * @return UpdateSheetResponse
     */
    public UpdateSheetResponse updateSheet(String baseId, String sheetIdOrName, UpdateSheetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateSheetHeaders headers = new UpdateSheetHeaders();
        return this.updateSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
    }
}
