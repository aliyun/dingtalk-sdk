// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public WikiWordsDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WikiWordsDetailResponse setBody(WikiWordsDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public WikiWordsDetailResponseBody getBody() {
        return this.body;
    }

}
