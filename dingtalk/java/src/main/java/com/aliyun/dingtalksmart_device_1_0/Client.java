// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalksmart_device_1_0.models.*;
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


    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBook(String deviceId, String bookId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDeviceVideoConferenceBookHeaders headers = new QueryDeviceVideoConferenceBookHeaders();
        return this.queryDeviceVideoConferenceBookWithOptions(deviceId, bookId, headers, runtime);
    }

    public QueryDeviceVideoConferenceBookResponse queryDeviceVideoConferenceBookWithOptions(String deviceId, String bookId, QueryDeviceVideoConferenceBookHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryDeviceVideoConferenceBook", "smartDevice_1.0", "HTTP", "GET", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/books/" + bookId + "", "json", req, runtime), new QueryDeviceVideoConferenceBookResponse());
    }

    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembers(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddDeviceVideoConferenceMembersHeaders headers = new AddDeviceVideoConferenceMembersHeaders();
        return this.addDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    public AddDeviceVideoConferenceMembersResponse addDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, AddDeviceVideoConferenceMembersRequest request, AddDeviceVideoConferenceMembersHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("AddDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members", "none", req, runtime), new AddDeviceVideoConferenceMembersResponse());
    }

    public CreateDeviceVideoConferenceResponse createDeviceVideoConference(String deviceId, CreateDeviceVideoConferenceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDeviceVideoConferenceHeaders headers = new CreateDeviceVideoConferenceHeaders();
        return this.createDeviceVideoConferenceWithOptions(deviceId, request, headers, runtime);
    }

    public CreateDeviceVideoConferenceResponse createDeviceVideoConferenceWithOptions(String deviceId, CreateDeviceVideoConferenceRequest request, CreateDeviceVideoConferenceHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CreateDeviceVideoConference", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences", "json", req, runtime), new CreateDeviceVideoConferenceResponse());
    }

    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembers(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        KickDeviceVideoConferenceMembersHeaders headers = new KickDeviceVideoConferenceMembersHeaders();
        return this.kickDeviceVideoConferenceMembersWithOptions(deviceId, conferenceId, request, headers, runtime);
    }

    public KickDeviceVideoConferenceMembersResponse kickDeviceVideoConferenceMembersWithOptions(String deviceId, String conferenceId, KickDeviceVideoConferenceMembersRequest request, KickDeviceVideoConferenceMembersHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("KickDeviceVideoConferenceMembers", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/devices/" + deviceId + "/videoConferences/" + conferenceId + "/members/batchDelete", "none", req, runtime), new KickDeviceVideoConferenceMembersResponse());
    }

    public ExtractFacialFeatureResponse extractFacialFeature(ExtractFacialFeatureRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ExtractFacialFeatureHeaders headers = new ExtractFacialFeatureHeaders();
        return this.extractFacialFeatureWithOptions(request, headers, runtime);
    }

    public ExtractFacialFeatureResponse extractFacialFeatureWithOptions(ExtractFacialFeatureRequest request, ExtractFacialFeatureHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
        return TeaModel.toModel(this.doROARequest("ExtractFacialFeature", "smartDevice_1.0", "HTTP", "POST", "AK", "/v1.0/smartDevice/faceRecognitions/features/extract", "json", req, runtime), new ExtractFacialFeatureResponse());
    }
}
