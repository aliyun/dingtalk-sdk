// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendDingMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
