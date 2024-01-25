// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsSearchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PediaWordsSearchResponseBody body;

    public static PediaWordsSearchResponse build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsSearchResponse self = new PediaWordsSearchResponse();
        return TeaModel.build(map, self);
    }

    public PediaWordsSearchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PediaWordsSearchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PediaWordsSearchResponse setBody(PediaWordsSearchResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsSearchResponseBody getBody() {
        return this.body;
    }

}
