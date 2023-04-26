// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetCorpConsoleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCorpConsoleResponseBody body;

    public static GetCorpConsoleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCorpConsoleResponse self = new GetCorpConsoleResponse();
        return TeaModel.build(map, self);
    }

    public GetCorpConsoleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCorpConsoleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCorpConsoleResponse setBody(GetCorpConsoleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCorpConsoleResponseBody getBody() {
        return this.body;
    }

}
