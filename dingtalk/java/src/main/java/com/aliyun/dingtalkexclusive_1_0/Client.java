// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkexclusive_1_0.models.*;
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


    public CreateTrustedDeviceResponse createTrustedDevice(CreateTrustedDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTrustedDeviceHeaders headers = new CreateTrustedDeviceHeaders();
        return this.createTrustedDeviceWithOptions(request, headers, runtime);
    }

    public CreateTrustedDeviceResponse createTrustedDeviceWithOptions(CreateTrustedDeviceRequest request, CreateTrustedDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.macAddress)) {
            body.put("macAddress", request.macAddress);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTrustedDevice", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices", "json", req, runtime), new CreateTrustedDeviceResponse());
    }

    public DeleteCommentResponse deleteComment(String publisherId, String commentId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteCommentHeaders headers = new DeleteCommentHeaders();
        return this.deleteCommentWithOptions(publisherId, commentId, headers, runtime);
    }

    public DeleteCommentResponse deleteCommentWithOptions(String publisherId, String commentId, DeleteCommentHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("DeleteComment", "exclusive_1.0", "HTTP", "DELETE", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/" + commentId + "", "boolean", req, runtime), new DeleteCommentResponse());
    }

    public GetGroupActiveInfoResponse getGroupActiveInfo(GetGroupActiveInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetGroupActiveInfoHeaders headers = new GetGroupActiveInfoHeaders();
        return this.getGroupActiveInfoWithOptions(request, headers, runtime);
    }

    public GetGroupActiveInfoResponse getGroupActiveInfoWithOptions(GetGroupActiveInfoRequest request, GetGroupActiveInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.statDate)) {
            query.put("statDate", request.statDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingGroupId)) {
            query.put("dingGroupId", request.dingGroupId);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetGroupActiveInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/data/activeGroups", "json", req, runtime), new GetGroupActiveInfoResponse());
    }

    public GetCommentListResponse getCommentList(String publisherId, GetCommentListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCommentListHeaders headers = new GetCommentListHeaders();
        return this.getCommentListWithOptions(publisherId, request, headers, runtime);
    }

    public GetCommentListResponse getCommentListWithOptions(String publisherId, GetCommentListRequest request, GetCommentListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetCommentList", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/publishers/" + publisherId + "/comments/list", "json", req, runtime), new GetCommentListResponse());
    }

    public GetTrustDeviceListResponse getTrustDeviceList(GetTrustDeviceListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTrustDeviceListHeaders headers = new GetTrustDeviceListHeaders();
        return this.getTrustDeviceListWithOptions(request, headers, runtime);
    }

    public GetTrustDeviceListResponse getTrustDeviceListWithOptions(GetTrustDeviceListRequest request, GetTrustDeviceListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetTrustDeviceList", "exclusive_1.0", "HTTP", "POST", "AK", "/v1.0/exclusive/trustedDevices/query", "json", req, runtime), new GetTrustDeviceListResponse());
    }

    public SearchOrgInnerGroupInfoResponse searchOrgInnerGroupInfo(SearchOrgInnerGroupInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchOrgInnerGroupInfoHeaders headers = new SearchOrgInnerGroupInfoHeaders();
        return this.searchOrgInnerGroupInfoWithOptions(request, headers, runtime);
    }

    public SearchOrgInnerGroupInfoResponse searchOrgInnerGroupInfoWithOptions(SearchOrgInnerGroupInfoRequest request, SearchOrgInnerGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupMembersCountEnd)) {
            query.put("groupMembersCountEnd", request.groupMembersCountEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncToDingpan)) {
            query.put("syncToDingpan", request.syncToDingpan);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupOwner)) {
            query.put("groupOwner", request.groupOwner);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTimeEnd)) {
            query.put("createTimeEnd", request.createTimeEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createTimeStart)) {
            query.put("createTimeStart", request.createTimeStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            query.put("uuid", request.uuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupMembersCountStart)) {
            query.put("groupMembersCountStart", request.groupMembersCountStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastActiveTimeEnd)) {
            query.put("lastActiveTimeEnd", request.lastActiveTimeEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            query.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            query.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageStart)) {
            query.put("pageStart", request.pageStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.lastActiveTimeStart)) {
            query.put("lastActiveTimeStart", request.lastActiveTimeStart);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("SearchOrgInnerGroupInfo", "exclusive_1.0", "HTTP", "GET", "AK", "/v1.0/exclusive/securities/orgGroupInfos", "json", req, runtime), new SearchOrgInnerGroupInfoResponse());
    }
}
