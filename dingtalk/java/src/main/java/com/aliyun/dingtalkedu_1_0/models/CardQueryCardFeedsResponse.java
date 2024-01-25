// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardQueryCardFeedsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CardQueryCardFeedsResponseBody body;

    public static CardQueryCardFeedsResponse build(java.util.Map<String, ?> map) throws Exception {
        CardQueryCardFeedsResponse self = new CardQueryCardFeedsResponse();
        return TeaModel.build(map, self);
    }

    public CardQueryCardFeedsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardQueryCardFeedsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardQueryCardFeedsResponse setBody(CardQueryCardFeedsResponseBody body) {
        this.body = body;
        return this;
    }
    public CardQueryCardFeedsResponseBody getBody() {
        return this.body;
    }

}
