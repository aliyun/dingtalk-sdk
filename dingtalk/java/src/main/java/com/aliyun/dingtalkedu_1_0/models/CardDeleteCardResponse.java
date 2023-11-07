// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardDeleteCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CardDeleteCardResponseBody body;

    public static CardDeleteCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CardDeleteCardResponse self = new CardDeleteCardResponse();
        return TeaModel.build(map, self);
    }

    public CardDeleteCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardDeleteCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardDeleteCardResponse setBody(CardDeleteCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CardDeleteCardResponseBody getBody() {
        return this.body;
    }

}
