// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BeginConsumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BeginConsumeResponseBody body;

    public static BeginConsumeResponse build(java.util.Map<String, ?> map) throws Exception {
        BeginConsumeResponse self = new BeginConsumeResponse();
        return TeaModel.build(map, self);
    }

    public BeginConsumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BeginConsumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BeginConsumeResponse setBody(BeginConsumeResponseBody body) {
        this.body = body;
        return this;
    }
    public BeginConsumeResponseBody getBody() {
        return this.body;
    }

}
