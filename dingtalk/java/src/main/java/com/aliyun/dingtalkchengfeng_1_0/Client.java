// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkchengfeng_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetAnalyzeDataResponse getAnalyzeData(GetAnalyzeDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAnalyzeDataHeaders headers = new GetAnalyzeDataHeaders();
        return this.getAnalyzeDataWithOptions(request, headers, runtime);
    }

    public GetAnalyzeDataResponse getAnalyzeDataWithOptions(GetAnalyzeDataRequest request, GetAnalyzeDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.periodIds)) {
            body.put("periodIds", request.periodIds);
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
        return TeaModel.toModel(this.doROARequest("GetAnalyzeData", "chengfeng_1.0", "HTTP", "POST", "AK", "/v1.0/chengfeng/okr/analyses/datas/query", "json", req, runtime), new GetAnalyzeDataResponse());
    }

    public GetEmployeeInfoByWorkNoResponse getEmployeeInfoByWorkNo(GetEmployeeInfoByWorkNoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmployeeInfoByWorkNoHeaders headers = new GetEmployeeInfoByWorkNoHeaders();
        return this.getEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
    }

    public GetEmployeeInfoByWorkNoResponse getEmployeeInfoByWorkNoWithOptions(GetEmployeeInfoByWorkNoRequest request, GetEmployeeInfoByWorkNoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.workNo)) {
            query.put("workNo", request.workNo);
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
        return TeaModel.toModel(this.doROARequest("GetEmployeeInfoByWorkNo", "chengfeng_1.0", "HTTP", "GET", "AK", "/v1.0/chengfeng/workNumbers/employees", "json", req, runtime), new GetEmployeeInfoByWorkNoResponse());
    }

    public GetUserResponse getUser(GetUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(request, headers, runtime);
    }

    public GetUserResponse getUserWithOptions(GetUserRequest request, GetUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.okrUserId)) {
            query.put("okrUserId", request.okrUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("GetUser", "chengfeng_1.0", "HTTP", "GET", "AK", "/v1.0/chengfeng/okr/users", "json", req, runtime), new GetUserResponse());
    }

    public ListAnalyzePeriodsResponse listAnalyzePeriods() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAnalyzePeriodsHeaders headers = new ListAnalyzePeriodsHeaders();
        return this.listAnalyzePeriodsWithOptions(headers, runtime);
    }

    public ListAnalyzePeriodsResponse listAnalyzePeriodsWithOptions(ListAnalyzePeriodsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("ListAnalyzePeriods", "chengfeng_1.0", "HTTP", "GET", "AK", "/v1.0/chengfeng/okr/analyses/periods", "json", req, runtime), new ListAnalyzePeriodsResponse());
    }

    public ListObjectiveByIdsResponse listObjectiveByIds(ListObjectiveByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListObjectiveByIdsHeaders headers = new ListObjectiveByIdsHeaders();
        return this.listObjectiveByIdsWithOptions(request, headers, runtime);
    }

    public ListObjectiveByIdsResponse listObjectiveByIdsWithOptions(ListObjectiveByIdsRequest request, ListObjectiveByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveIds)) {
            body.put("objectiveIds", request.objectiveIds);
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
        return TeaModel.toModel(this.doROARequest("ListObjectiveByIds", "chengfeng_1.0", "HTTP", "POST", "AK", "/v1.0/chengfeng/okr/objectives/query", "json", req, runtime), new ListObjectiveByIdsResponse());
    }

    public ListObjectiveByUserResponse listObjectiveByUser(ListObjectiveByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListObjectiveByUserHeaders headers = new ListObjectiveByUserHeaders();
        return this.listObjectiveByUserWithOptions(request, headers, runtime);
    }

    public ListObjectiveByUserResponse listObjectiveByUserWithOptions(ListObjectiveByUserRequest request, ListObjectiveByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("ListObjectiveByUser", "chengfeng_1.0", "HTTP", "GET", "AK", "/v1.0/chengfeng/okr/users/objectives", "json", req, runtime), new ListObjectiveByUserResponse());
    }

    public ListProgressByIdsResponse listProgressByIds(ListProgressByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListProgressByIdsHeaders headers = new ListProgressByIdsHeaders();
        return this.listProgressByIdsWithOptions(request, headers, runtime);
    }

    public ListProgressByIdsResponse listProgressByIdsWithOptions(ListProgressByIdsRequest request, ListProgressByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.progressIds)) {
            body.put("progressIds", request.progressIds);
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
        return TeaModel.toModel(this.doROARequest("ListProgressByIds", "chengfeng_1.0", "HTTP", "POST", "AK", "/v1.0/chengfeng/okr/objectives/progresses/query", "json", req, runtime), new ListProgressByIdsResponse());
    }

    public PageListObjectiveProgressResponse pageListObjectiveProgress(PageListObjectiveProgressRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PageListObjectiveProgressHeaders headers = new PageListObjectiveProgressHeaders();
        return this.pageListObjectiveProgressWithOptions(request, headers, runtime);
    }

    public PageListObjectiveProgressResponse pageListObjectiveProgressWithOptions(PageListObjectiveProgressRequest request, PageListObjectiveProgressHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("PageListObjectiveProgress", "chengfeng_1.0", "HTTP", "GET", "AK", "/v1.0/chengfeng/okr/objectives/progresses/records", "json", req, runtime), new PageListObjectiveProgressResponse());
    }

    public TransferUserObjectiveResponse transferUserObjective(TransferUserObjectiveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferUserObjectiveHeaders headers = new TransferUserObjectiveHeaders();
        return this.transferUserObjectiveWithOptions(request, headers, runtime);
    }

    public TransferUserObjectiveResponse transferUserObjectiveWithOptions(TransferUserObjectiveRequest request, TransferUserObjectiveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUserId)) {
            query.put("targetUserId", request.targetUserId);
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
        return TeaModel.toModel(this.doROARequest("TransferUserObjective", "chengfeng_1.0", "HTTP", "POST", "AK", "/v1.0/chengfeng/okr/objectives/transfer", "json", req, runtime), new TransferUserObjectiveResponse());
    }
}
