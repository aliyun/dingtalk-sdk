// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CardGetCardResponseBody body;

    public static CardGetCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardResponse self = new CardGetCardResponse();
        return TeaModel.build(map, self);
    }

    public CardGetCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardGetCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardGetCardResponse setBody(CardGetCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CardGetCardResponseBody getBody() {
        return this.body;
    }

}
