// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDeviceGroupInfoResponseBody body;

    public static GetDeviceGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceGroupInfoResponse self = new GetDeviceGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetDeviceGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeviceGroupInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDeviceGroupInfoResponse setBody(GetDeviceGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeviceGroupInfoResponseBody getBody() {
        return this.body;
    }

}
