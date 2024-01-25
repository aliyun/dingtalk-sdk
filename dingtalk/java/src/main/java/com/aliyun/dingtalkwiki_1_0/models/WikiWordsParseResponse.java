// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_1_0.models;

import com.aliyun.tea.*;

public class WikiWordsParseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WikiWordsParseResponseBody body;

    public static WikiWordsParseResponse build(java.util.Map<String, ?> map) throws Exception {
        WikiWordsParseResponse self = new WikiWordsParseResponse();
        return TeaModel.build(map, self);
    }

    public WikiWordsParseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WikiWordsParseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WikiWordsParseResponse setBody(WikiWordsParseResponseBody body) {
        this.body = body;
        return this;
    }
    public WikiWordsParseResponseBody getBody() {
        return this.body;
    }

}
