// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetA1DeviceDetailResponseBody body;

    public static GetA1DeviceDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceDetailResponse self = new GetA1DeviceDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetA1DeviceDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetA1DeviceDetailResponse setBody(GetA1DeviceDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetA1DeviceDetailResponseBody getBody() {
        return this.body;
    }

}
