// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class SendResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendResponseBody body;

    public static SendResponse build(java.util.Map<String, ?> map) throws Exception {
        SendResponse self = new SendResponse();
        return TeaModel.build(map, self);
    }

    public SendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendResponse setBody(SendResponseBody body) {
        this.body = body;
        return this;
    }
    public SendResponseBody getBody() {
        return this.body;
    }

}
