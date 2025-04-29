// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PushClassGroupCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PushClassGroupCardResponseBody body;

    public static PushClassGroupCardResponse build(java.util.Map<String, ?> map) throws Exception {
        PushClassGroupCardResponse self = new PushClassGroupCardResponse();
        return TeaModel.build(map, self);
    }

    public PushClassGroupCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushClassGroupCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushClassGroupCardResponse setBody(PushClassGroupCardResponseBody body) {
        this.body = body;
        return this;
    }
    public PushClassGroupCardResponseBody getBody() {
        return this.body;
    }

}
