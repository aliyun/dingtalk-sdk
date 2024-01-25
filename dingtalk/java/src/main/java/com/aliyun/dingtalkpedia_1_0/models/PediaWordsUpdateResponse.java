// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
