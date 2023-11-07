// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardEndCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CardEndCardResponseBody body;

    public static CardEndCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CardEndCardResponse self = new CardEndCardResponse();
        return TeaModel.build(map, self);
    }

    public CardEndCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardEndCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardEndCardResponse setBody(CardEndCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CardEndCardResponseBody getBody() {
        return this.body;
    }

}
