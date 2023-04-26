// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsDeleteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PediaWordsDeleteResponseBody body;

    public static PediaWordsDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsDeleteResponse self = new PediaWordsDeleteResponse();
        return TeaModel.build(map, self);
    }

    public PediaWordsDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PediaWordsDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PediaWordsDeleteResponse setBody(PediaWordsDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsDeleteResponseBody getBody() {
        return this.body;
    }

}
