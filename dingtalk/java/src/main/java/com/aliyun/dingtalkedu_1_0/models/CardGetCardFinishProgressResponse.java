// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CardGetCardFinishProgressResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CardGetCardFinishProgressResponseBody body;

    public static CardGetCardFinishProgressResponse build(java.util.Map<String, ?> map) throws Exception {
        CardGetCardFinishProgressResponse self = new CardGetCardFinishProgressResponse();
        return TeaModel.build(map, self);
    }

    public CardGetCardFinishProgressResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CardGetCardFinishProgressResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CardGetCardFinishProgressResponse setBody(CardGetCardFinishProgressResponseBody body) {
        this.body = body;
        return this;
    }
    public CardGetCardFinishProgressResponseBody getBody() {
        return this.body;
    }

}
