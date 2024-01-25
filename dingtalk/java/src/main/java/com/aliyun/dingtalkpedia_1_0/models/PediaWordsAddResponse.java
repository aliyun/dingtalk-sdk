// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PediaWordsAddResponseBody body;

    public static PediaWordsAddResponse build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsAddResponse self = new PediaWordsAddResponse();
        return TeaModel.build(map, self);
    }

    public PediaWordsAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PediaWordsAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PediaWordsAddResponse setBody(PediaWordsAddResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsAddResponseBody getBody() {
        return this.body;
    }

}
