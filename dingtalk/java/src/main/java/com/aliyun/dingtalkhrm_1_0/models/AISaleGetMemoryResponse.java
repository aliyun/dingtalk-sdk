// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleGetMemoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleGetMemoryResponseBody body;

    public static AISaleGetMemoryResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleGetMemoryResponse self = new AISaleGetMemoryResponse();
        return TeaModel.build(map, self);
    }

    public AISaleGetMemoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleGetMemoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleGetMemoryResponse setBody(AISaleGetMemoryResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleGetMemoryResponseBody getBody() {
        return this.body;
    }

}
