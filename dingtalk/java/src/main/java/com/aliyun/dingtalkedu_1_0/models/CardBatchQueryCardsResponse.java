// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardBatchQueryCardsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CardBatchQueryCardsResponseBody body;

    public static CardBatchQueryCardsResponse build(java.util.Map<String, ?> map) throws Exception {
        CardBatchQueryCardsResponse self = new CardBatchQueryCardsResponse();
        return TeaModel.build(map, self);
    }

    public CardBatchQueryCardsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardBatchQueryCardsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardBatchQueryCardsResponse setBody(CardBatchQueryCardsResponseBody body) {
        this.body = body;
        return this;
    }
    public CardBatchQueryCardsResponseBody getBody() {
        return this.body;
    }

}
