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


    public CopyDentryResponse copyDentry(String spaceId, String dentryId, CopyDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CopyDentryHeaders headers = new CopyDentryHeaders();
        return this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public CopyDentryResponse copyDentryWithOptions(String spaceId, String dentryId, CopyDentryRequest request, CopyDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

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
        return TeaModel.toModel(this.doROARequest("CopyDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime), new CopyDentryResponse());
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

    public GetSchemaResponse getSchema(String teamId, GetSchemaRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSchemaHeaders headers = new GetSchemaHeaders();
        return this.getSchemaWithOptions(teamId, request, headers, runtime);
    }

    public GetSchemaResponse getSchemaWithOptions(String teamId, GetSchemaRequest request, GetSchemaHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        teamId = com.aliyun.openapiutil.Client.getEncodeParam(teamId);
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
        return TeaModel.toModel(this.doROARequest("GetSchema", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/schemas", "json", req, runtime), new GetSchemaResponse());
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

    public GetTeamResponse getTeam(String teamId, GetTeamRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTeamHeaders headers = new GetTeamHeaders();
        return this.getTeamWithOptions(teamId, request, headers, runtime);
    }

    public GetTeamResponse getTeamWithOptions(String teamId, GetTeamRequest request, GetTeamHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        teamId = com.aliyun.openapiutil.Client.getEncodeParam(teamId);
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
        return TeaModel.toModel(this.doROARequest("GetTeam", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "", "json", req, runtime), new GetTeamResponse());
    }

    public GetUserInfoByOpenTokenResponse getUserInfoByOpenToken(GetUserInfoByOpenTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserInfoByOpenTokenHeaders headers = new GetUserInfoByOpenTokenHeaders();
        return this.getUserInfoByOpenTokenWithOptions(request, headers, runtime);
    }

    public GetUserInfoByOpenTokenResponse getUserInfoByOpenTokenWithOptions(GetUserInfoByOpenTokenRequest request, GetUserInfoByOpenTokenHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.docKey)) {
            query.put("docKey", request.docKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openToken)) {
            query.put("openToken", request.openToken);
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
        return TeaModel.toModel(this.doROARequest("GetUserInfoByOpenToken", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/userInfos", "json", req, runtime), new GetUserInfoByOpenTokenResponse());
    }

    public ListFeedsResponse listFeeds(String teamId, ListFeedsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListFeedsHeaders headers = new ListFeedsHeaders();
        return this.listFeedsWithOptions(teamId, request, headers, runtime);
    }

    public ListFeedsResponse listFeedsWithOptions(String teamId, ListFeedsRequest request, ListFeedsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        teamId = com.aliyun.openapiutil.Client.getEncodeParam(teamId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.excludeFile)) {
            query.put("excludeFile", request.excludeFile);
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
        return TeaModel.toModel(this.doROARequest("ListFeeds", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/feeds", "json", req, runtime), new ListFeedsResponse());
    }

    public ListHotDocsResponse listHotDocs(String teamId, ListHotDocsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListHotDocsHeaders headers = new ListHotDocsHeaders();
        return this.listHotDocsWithOptions(teamId, request, headers, runtime);
    }

    public ListHotDocsResponse listHotDocsWithOptions(String teamId, ListHotDocsRequest request, ListHotDocsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        teamId = com.aliyun.openapiutil.Client.getEncodeParam(teamId);
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
        return TeaModel.toModel(this.doROARequest("ListHotDocs", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/hotDocs", "json", req, runtime), new ListHotDocsResponse());
    }

    public ListRelatedSpaceTeamsResponse listRelatedSpaceTeams(ListRelatedSpaceTeamsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListRelatedSpaceTeamsHeaders headers = new ListRelatedSpaceTeamsHeaders();
        return this.listRelatedSpaceTeamsWithOptions(request, headers, runtime);
    }

    public ListRelatedSpaceTeamsResponse listRelatedSpaceTeamsWithOptions(ListRelatedSpaceTeamsRequest request, ListRelatedSpaceTeamsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
        return TeaModel.toModel(this.doROARequest("ListRelatedSpaceTeams", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/relations/spaceTeams", "json", req, runtime), new ListRelatedSpaceTeamsResponse());
    }

    public ListSpaceSectionsResponse listSpaceSections(String teamId, ListSpaceSectionsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSpaceSectionsHeaders headers = new ListSpaceSectionsHeaders();
        return this.listSpaceSectionsWithOptions(teamId, request, headers, runtime);
    }

    public ListSpaceSectionsResponse listSpaceSectionsWithOptions(String teamId, ListSpaceSectionsRequest request, ListSpaceSectionsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        teamId = com.aliyun.openapiutil.Client.getEncodeParam(teamId);
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
        return TeaModel.toModel(this.doROARequest("ListSpaceSections", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/teams/" + teamId + "/spaceSections", "json", req, runtime), new ListSpaceSectionsResponse());
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

    public QueryMineSpaceResponse queryMineSpace(String unionId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryMineSpaceHeaders headers = new QueryMineSpaceHeaders();
        return this.queryMineSpaceWithOptions(unionId, headers, runtime);
    }

    public QueryMineSpaceResponse queryMineSpaceWithOptions(String unionId, QueryMineSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        unionId = com.aliyun.openapiutil.Client.getEncodeParam(unionId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryMineSpace", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/users/" + unionId + "/mine", "json", req, runtime), new QueryMineSpaceResponse());
    }

    public QueryRecentListResponse queryRecentList(QueryRecentListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryRecentListHeaders headers = new QueryRecentListHeaders();
        return this.queryRecentListWithOptions(request, headers, runtime);
    }

    public QueryRecentListResponse queryRecentListWithOptions(QueryRecentListRequest request, QueryRecentListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorType)) {
            query.put("creatorType", request.creatorType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileType)) {
            query.put("fileType", request.fileType);
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

        if (!com.aliyun.teautil.Common.isUnset(request.recentType)) {
            query.put("recentType", request.recentType);
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
        return TeaModel.toModel(this.doROARequest("QueryRecentList", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/spaces/docs/recent", "json", req, runtime), new QueryRecentListResponse());
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

    public RelatedSpacesResponse relatedSpaces(RelatedSpacesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RelatedSpacesHeaders headers = new RelatedSpacesHeaders();
        return this.relatedSpacesWithOptions(request, headers, runtime);
    }

    public RelatedSpacesResponse relatedSpacesWithOptions(RelatedSpacesRequest request, RelatedSpacesHeaders headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            query.put("teamId", request.teamId);
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
        return TeaModel.toModel(this.doROARequest("RelatedSpaces", "doc_2.0", "HTTP", "GET", "AK", "/v2.0/doc/relations/spaces", "json", req, runtime), new RelatedSpacesResponse());
    }

    public RenameDentryResponse renameDentry(String spaceId, String dentryId, RenameDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RenameDentryHeaders headers = new RenameDentryHeaders();
        return this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public RenameDentryResponse renameDentryWithOptions(String spaceId, String dentryId, RenameDentryRequest request, RenameDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
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
        return TeaModel.toModel(this.doROARequest("RenameDentry", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime), new RenameDentryResponse());
    }

    public SearchResponse search(SearchRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchHeaders headers = new SearchHeaders();
        return this.searchWithOptions(request, headers, runtime);
    }

    public SearchResponse searchWithOptions(SearchRequest request, SearchHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.dentryRequest))) {
            body.put("dentryRequest", request.dentryRequest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.spaceRequest))) {
            body.put("spaceRequest", request.spaceRequest);
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
        return TeaModel.toModel(this.doROARequest("Search", "doc_2.0", "HTTP", "POST", "AK", "/v2.0/doc/search", "json", req, runtime), new SearchResponse());
    }
}
