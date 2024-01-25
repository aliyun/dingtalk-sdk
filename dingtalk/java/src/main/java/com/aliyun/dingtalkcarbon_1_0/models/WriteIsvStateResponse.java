// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteIsvStateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WriteIsvStateResponseBody body;

    public static WriteIsvStateResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteIsvStateResponse self = new WriteIsvStateResponse();
        return TeaModel.build(map, self);
    }

    public WriteIsvStateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteIsvStateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WriteIsvStateResponse setBody(WriteIsvStateResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteIsvStateResponseBody getBody() {
        return this.body;
    }

}
