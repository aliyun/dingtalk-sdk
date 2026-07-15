// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardSubmitCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CardSubmitCardResponseBody body;

    public static CardSubmitCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CardSubmitCardResponse self = new CardSubmitCardResponse();
        return TeaModel.build(map, self);
    }

    public CardSubmitCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardSubmitCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardSubmitCardResponse setBody(CardSubmitCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CardSubmitCardResponseBody getBody() {
        return this.body;
    }

}
