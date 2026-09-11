// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceBindingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetA1DeviceBindingResponseBody body;

    public static GetA1DeviceBindingResponse build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceBindingResponse self = new GetA1DeviceBindingResponse();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceBindingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetA1DeviceBindingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetA1DeviceBindingResponse setBody(GetA1DeviceBindingResponseBody body) {
        this.body = body;
        return this;
    }
    public GetA1DeviceBindingResponseBody getBody() {
        return this.body;
    }

}
