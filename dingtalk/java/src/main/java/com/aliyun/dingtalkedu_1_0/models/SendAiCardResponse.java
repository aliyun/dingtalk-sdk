// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendAiCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendAiCardResponseBody body;

    public static SendAiCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendAiCardResponse self = new SendAiCardResponse();
        return TeaModel.build(map, self);
    }

    public SendAiCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendAiCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendAiCardResponse setBody(SendAiCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendAiCardResponseBody getBody() {
        return this.body;
    }

}
