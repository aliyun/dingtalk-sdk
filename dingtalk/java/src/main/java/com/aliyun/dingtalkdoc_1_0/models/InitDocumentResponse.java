// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InitDocumentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InitDocumentResponseBody body;

    public static InitDocumentResponse build(java.util.Map<String, ?> map) throws Exception {
        InitDocumentResponse self = new InitDocumentResponse();
        return TeaModel.build(map, self);
    }

    public InitDocumentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InitDocumentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InitDocumentResponse setBody(InitDocumentResponseBody body) {
        this.body = body;
        return this;
    }
    public InitDocumentResponseBody getBody() {
        return this.body;
    }

}
