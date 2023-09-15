// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SendIsvCardMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendIsvCardMessageResponseBody body;

    public static SendIsvCardMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendIsvCardMessageResponse self = new SendIsvCardMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendIsvCardMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendIsvCardMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendIsvCardMessageResponse setBody(SendIsvCardMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendIsvCardMessageResponseBody getBody() {
        return this.body;
    }

}
