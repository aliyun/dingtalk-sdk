// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PediaWordsUpdateResponseBody body;

    public static PediaWordsUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsUpdateResponse self = new PediaWordsUpdateResponse();
        return TeaModel.build(map, self);
    }

    public PediaWordsUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PediaWordsUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PediaWordsUpdateResponse setBody(PediaWordsUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsUpdateResponseBody getBody() {
        return this.body;
    }

}
