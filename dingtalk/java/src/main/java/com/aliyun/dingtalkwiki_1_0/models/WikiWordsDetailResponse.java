// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WikiWordsDetailResponseBody body;

    public static WikiWordsDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsDetailResponse self = new WikiWordsDetailResponse();
        return TeaModel.build(map, self);
    }

    public WikiWordsDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WikiWordsDetailResponse setBody(WikiWordsDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public WikiWordsDetailResponseBody getBody() {
        return this.body;
    }

}
