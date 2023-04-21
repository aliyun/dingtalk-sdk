// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsAddResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public PediaWordsAddResponse setBody(PediaWordsAddResponseBody body) {
        this.body = body;
        return this;
    }
    public PediaWordsAddResponseBody getBody() {
        return this.body;
    }

}
