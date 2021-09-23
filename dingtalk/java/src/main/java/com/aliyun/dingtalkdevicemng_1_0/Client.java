// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdevicemng_1_0.models.*;
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


    public RegisterDeviceResponse registerDevice(RegisterDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
        return this.registerDeviceWithOptions(request, headers, runtime);
    }

    public RegisterDeviceResponse registerDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceKey)) {
            body.put("deviceKey", request.deviceKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            body.put("deviceName", request.deviceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            body.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managers)) {
            body.put("managers", request.managers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.collaborators)) {
            body.put("collaborators", request.collaborators);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("RegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/devices", "json", req, runtime), new RegisterDeviceResponse());
    }

    public BatchRegisterDeviceResponse batchRegisterDevice(BatchRegisterDeviceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
        return this.batchRegisterDeviceWithOptions(request, headers, runtime);
    }

    public BatchRegisterDeviceResponse batchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deviceList)) {
            body.put("deviceList", request.deviceList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("BatchRegisterDevice", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/devices/batch", "json", req, runtime), new BatchRegisterDeviceResponse());
    }

    public CreateDepartmentResponse createDepartment(CreateDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
        return this.createDepartmentWithOptions(request, headers, runtime);
    }

    public CreateDepartmentResponse createDepartmentWithOptions(CreateDepartmentRequest request, CreateDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentName)) {
            body.put("departmentName", request.departmentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentType)) {
            body.put("departmentType", request.departmentType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.systemUrl)) {
            body.put("systemUrl", request.systemUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authType)) {
            body.put("authType", request.authType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authInfo)) {
            body.put("authInfo", request.authInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizExt)) {
            body.put("bizExt", request.bizExt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("CreateDepartment", "devicemng_1.0", "HTTP", "POST", "AK", "/v1.0/devicemng/departments", "json", req, runtime), new CreateDepartmentResponse());
    }
}
