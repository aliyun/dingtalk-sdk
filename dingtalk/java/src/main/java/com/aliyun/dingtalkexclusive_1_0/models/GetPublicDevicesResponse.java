// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublicDevicesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPublicDevicesResponseBody body;

    public static GetPublicDevicesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPublicDevicesResponse self = new GetPublicDevicesResponse();
        return TeaModel.build(map, self);
    }

    public GetPublicDevicesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPublicDevicesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPublicDevicesResponse setBody(GetPublicDevicesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPublicDevicesResponseBody getBody() {
        return this.body;
    }

}
