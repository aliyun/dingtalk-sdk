// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTimerCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTimerCardResponseBody body;

    public static CreateTimerCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTimerCardResponse self = new CreateTimerCardResponse();
        return TeaModel.build(map, self);
    }

    public CreateTimerCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTimerCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTimerCardResponse setBody(CreateTimerCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTimerCardResponseBody getBody() {
        return this.body;
    }

}
