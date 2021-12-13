// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdiot_1_0.models.*;
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
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceName)) {
            body.put("deviceName", request.deviceName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickName)) {
            body.put("nickName", request.nickName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceStatus)) {
            body.put("deviceStatus", request.deviceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceType)) {
            body.put("deviceType", request.deviceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deviceTypeName)) {
            body.put("deviceTypeName", request.deviceTypeName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productType)) {
            body.put("productType", request.productType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.liveUrl)) {
            body.put("liveUrl", request.liveUrl);
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
        return TeaModel.toModel(this.doROARequest("RegisterDevice", "diot_1.0", "HTTP", "POST", "AK", "/v1.0/diot/devices/register", "json", req, runtime), new RegisterDeviceResponse());
    }
}
