// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontact_1_0.models.*;
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


    public GetApplyInviteInfoResponse getApplyInviteInfo(GetApplyInviteInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
        return this.getApplyInviteInfoWithOptions(request, headers, runtime);
    }

    public GetApplyInviteInfoResponse getApplyInviteInfoWithOptions(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.inviterUserId)) {
            query.put("inviterUserId", request.inviterUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/invites/infos", "json", req, runtime), new GetApplyInviteInfoResponse());
    }

    public GetBranchAuthDataResponse getBranchAuthData(GetBranchAuthDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
        return this.getBranchAuthDataWithOptions(request, headers, runtime);
    }

    public GetBranchAuthDataResponse getBranchAuthDataWithOptions(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.branchCorpId)) {
            query.put("branchCorpId", request.branchCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.body)) {
            body.put("body", request.body);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/branchAuthDatas/search", "json", req, runtime), new GetBranchAuthDataResponse());
    }

    public GetLatestDingIndexResponse getLatestDingIndex() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
        return this.getLatestDingIndexWithOptions(headers, runtime);
    }

    public GetLatestDingIndexResponse getLatestDingIndexWithOptions(GetLatestDingIndexHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/dingIndexs", "json", req, runtime), new GetLatestDingIndexResponse());
    }

    public GetUserResponse getUser(String unionId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(unionId, headers, runtime);
    }

    public GetUserResponse getUserWithOptions(String unionId, GetUserHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetUser", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + unionId + "", "json", req, runtime), new GetUserResponse());
    }
}
