// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardUpdateCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CardUpdateCardResponseBody body;

    public static CardUpdateCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CardUpdateCardResponse self = new CardUpdateCardResponse();
        return TeaModel.build(map, self);
    }

    public CardUpdateCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardUpdateCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardUpdateCardResponse setBody(CardUpdateCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CardUpdateCardResponseBody getBody() {
        return this.body;
    }

}
