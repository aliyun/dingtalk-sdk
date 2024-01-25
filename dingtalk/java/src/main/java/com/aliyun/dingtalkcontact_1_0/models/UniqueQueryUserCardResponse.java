// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UniqueQueryUserCardResponseBody body;

    public static UniqueQueryUserCardResponse build(java.util.Map<String, ?> map) throws Exception {
        UniqueQueryUserCardResponse self = new UniqueQueryUserCardResponse();
        return TeaModel.build(map, self);
    }

    public UniqueQueryUserCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UniqueQueryUserCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UniqueQueryUserCardResponse setBody(UniqueQueryUserCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UniqueQueryUserCardResponseBody getBody() {
        return this.body;
    }

}
