// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendCardResponseBody body;

    public static SendCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendCardResponse self = new SendCardResponse();
        return TeaModel.build(map, self);
    }

    public SendCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendCardResponse setBody(SendCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendCardResponseBody getBody() {
        return this.body;
    }

}
