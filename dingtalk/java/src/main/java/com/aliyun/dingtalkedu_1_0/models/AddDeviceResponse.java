// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddDeviceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddDeviceResponseBody body;

    public static AddDeviceResponse build(java.util.Map<String, ?> map) throws Exception {
        AddDeviceResponse self = new AddDeviceResponse();
        return TeaModel.build(map, self);
    }

    public AddDeviceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddDeviceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddDeviceResponse setBody(AddDeviceResponseBody body) {
        this.body = body;
        return this;
    }
    public AddDeviceResponseBody getBody() {
        return this.body;
    }

}
