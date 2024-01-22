// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class PushVerifyEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PushVerifyEventResponseBody body;

    public static PushVerifyEventResponse build(java.util.Map<String, ?> map) throws Exception {
        PushVerifyEventResponse self = new PushVerifyEventResponse();
        return TeaModel.build(map, self);
    }

    public PushVerifyEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushVerifyEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushVerifyEventResponse setBody(PushVerifyEventResponseBody body) {
        this.body = body;
        return this;
    }
    public PushVerifyEventResponseBody getBody() {
        return this.body;
    }

}
