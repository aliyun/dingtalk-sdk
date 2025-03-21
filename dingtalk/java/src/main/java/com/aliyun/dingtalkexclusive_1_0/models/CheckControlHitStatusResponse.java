// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CheckControlHitStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckControlHitStatusResponseBody body;

    public static CheckControlHitStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckControlHitStatusResponse self = new CheckControlHitStatusResponse();
        return TeaModel.build(map, self);
    }

    public CheckControlHitStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckControlHitStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckControlHitStatusResponse setBody(CheckControlHitStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckControlHitStatusResponseBody getBody() {
        return this.body;
    }

}
