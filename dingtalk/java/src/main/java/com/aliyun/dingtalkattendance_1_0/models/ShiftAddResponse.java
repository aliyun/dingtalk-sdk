// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ShiftAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ShiftAddResponseBody body;

    public static ShiftAddResponse build(java.util.Map<String, ?> map) throws Exception {
        ShiftAddResponse self = new ShiftAddResponse();
        return TeaModel.build(map, self);
    }

    public ShiftAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ShiftAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ShiftAddResponse setBody(ShiftAddResponseBody body) {
        this.body = body;
        return this;
    }
    public ShiftAddResponseBody getBody() {
        return this.body;
    }

}
