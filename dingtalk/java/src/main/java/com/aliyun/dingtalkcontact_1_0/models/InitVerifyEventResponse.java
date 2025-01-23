// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class InitVerifyEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InitVerifyEventResponseBody body;

    public static InitVerifyEventResponse build(java.util.Map<String, ?> map) throws Exception {
        InitVerifyEventResponse self = new InitVerifyEventResponse();
        return TeaModel.build(map, self);
    }

    public InitVerifyEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitVerifyEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitVerifyEventResponse setBody(InitVerifyEventResponseBody body) {
        this.body = body;
        return this;
    }
    public InitVerifyEventResponseBody getBody() {
        return this.body;
    }

}
