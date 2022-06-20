// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UniqueQueryUserCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UniqueQueryUserCardResponse setBody(UniqueQueryUserCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UniqueQueryUserCardResponseBody getBody() {
        return this.body;
    }

}
