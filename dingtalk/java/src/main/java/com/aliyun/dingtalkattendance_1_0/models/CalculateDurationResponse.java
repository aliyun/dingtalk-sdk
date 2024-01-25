// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CalculateDurationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CalculateDurationResponseBody body;

    public static CalculateDurationResponse build(java.util.Map<String, ?> map) throws Exception {
        CalculateDurationResponse self = new CalculateDurationResponse();
        return TeaModel.build(map, self);
    }

    public CalculateDurationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CalculateDurationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CalculateDurationResponse setBody(CalculateDurationResponseBody body) {
        this.body = body;
        return this;
    }
    public CalculateDurationResponseBody getBody() {
        return this.body;
    }

}
