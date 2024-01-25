// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendMessageTipResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendMessageTipResponseBody body;

    public static SendMessageTipResponse build(java.util.Map<String, ?> map) throws Exception {
        SendMessageTipResponse self = new SendMessageTipResponse();
        return TeaModel.build(map, self);
    }

    public SendMessageTipResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendMessageTipResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendMessageTipResponse setBody(SendMessageTipResponseBody body) {
        this.body = body;
        return this;
    }
    public SendMessageTipResponseBody getBody() {
        return this.body;
    }

}
