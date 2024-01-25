// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CallbackRegiesterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CallbackRegiesterResponseBody body;

    public static CallbackRegiesterResponse build(java.util.Map<String, ?> map) throws Exception {
        CallbackRegiesterResponse self = new CallbackRegiesterResponse();
        return TeaModel.build(map, self);
    }

    public CallbackRegiesterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CallbackRegiesterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CallbackRegiesterResponse setBody(CallbackRegiesterResponseBody body) {
        this.body = body;
        return this;
    }
    public CallbackRegiesterResponseBody getBody() {
        return this.body;
    }

}
