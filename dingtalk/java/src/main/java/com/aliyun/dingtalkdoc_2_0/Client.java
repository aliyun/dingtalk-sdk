// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdoc_2_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateDentryResponse createDentry(String spaceId, CreateDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDentryHeaders headers = new CreateDentryHeaders();
        return this.createDentryWithOptions(spaceId, request, headers, runtime);
    }

    public CreateDentryResponse createDentryWithOptions(String spaceId, CreateDentryRequest request, CreateDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryType)) {
            body.put("dentryType", request.dentryType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.documentType)) {
            body.put("documentType", request.documentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDentryId)) {
            body.put("parentDentryId", request.parentDentryId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries", "json", req, runtime), new CreateDentryResponse());
    }

    public GetSpaceDirectoriesResponse getSpaceDirectories(String spaceId, GetSpaceDirectoriesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSpaceDirectoriesHeaders headers = new GetSpaceDirectoriesHeaders();
        return this.getSpaceDirectoriesWithOptions(spaceId, request, headers, runtime);
    }

    public GetSpaceDirectoriesResponse getSpaceDirectoriesWithOptions(String spaceId, GetSpaceDirectoriesRequest request, GetSpaceDirectoriesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryId)) {
            query.put("dentryId", request.dentryId);
        }

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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSpaceDirectories", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/directories", "json", req, runtime), new GetSpaceDirectoriesResponse());
    }

    public MoveDentryResponse moveDentry(String spaceId, String dentryId, MoveDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MoveDentryHeaders headers = new MoveDentryHeaders();
        return this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public MoveDentryResponse moveDentryWithOptions(String spaceId, String dentryId, MoveDentryRequest request, MoveDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toNextDentryId)) {
            body.put("toNextDentryId", request.toNextDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toParentDentryId)) {
            body.put("toParentDentryId", request.toParentDentryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toPrevDentryId)) {
            body.put("toPrevDentryId", request.toPrevDentryId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("MoveDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime), new MoveDentryResponse());
    }

    public QueryDentryResponse queryDentry(String spaceId, String dentryId, QueryDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDentryHeaders headers = new QueryDentryHeaders();
        return this.queryDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public QueryDentryResponse queryDentryWithOptions(String spaceId, String dentryId, QueryDentryRequest request, QueryDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeSpace)) {
            query.put("includeSpace", request.includeSpace);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryDentry", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "", "json", req, runtime), new QueryDentryResponse());
    }

    public QuerySpaceResponse querySpace(String spaceId, QuerySpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySpaceHeaders headers = new QuerySpaceHeaders();
        return this.querySpaceWithOptions(spaceId, request, headers, runtime);
    }

    public QuerySpaceResponse querySpaceWithOptions(String spaceId, QuerySpaceRequest request, QuerySpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QuerySpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/" + spaceId + "", "json", req, runtime), new QuerySpaceResponse());
    }
}