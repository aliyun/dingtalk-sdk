// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDeviceDetailResponseBody body;

    public static GetDeviceDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceDetailResponse self = new GetDeviceDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetDeviceDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeviceDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDeviceDetailResponse setBody(GetDeviceDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeviceDetailResponseBody getBody() {
        return this.body;
    }

}
