// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpConsoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CorpConsoleResponseBody body;

    public static CorpConsoleResponse build(java.util.Map<String, ?> map) throws Exception {
        CorpConsoleResponse self = new CorpConsoleResponse();
        return TeaModel.build(map, self);
    }

    public CorpConsoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CorpConsoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CorpConsoleResponse setBody(CorpConsoleResponseBody body) {
        this.body = body;
        return this;
    }
    public CorpConsoleResponseBody getBody() {
        return this.body;
    }

}
