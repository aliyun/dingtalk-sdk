// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendDingMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendDingMessageResponseBody body;

    public static SendDingMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendDingMessageResponse self = new SendDingMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendDingMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendDingMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendDingMessageResponse setBody(SendDingMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendDingMessageResponseBody getBody() {
        return this.body;
    }

}
