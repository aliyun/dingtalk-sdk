// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class ReplyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReplyResponseBody body;

    public static ReplyResponse build(java.util.Map<String, ?> map) throws Exception {
        ReplyResponse self = new ReplyResponse();
        return TeaModel.build(map, self);
    }

    public ReplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReplyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReplyResponse setBody(ReplyResponseBody body) {
        this.body = body;
        return this;
    }
    public ReplyResponseBody getBody() {
        return this.body;
    }

}
