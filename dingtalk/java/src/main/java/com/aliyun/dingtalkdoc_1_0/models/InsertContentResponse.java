// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InsertContentResponseBody body;

    public static InsertContentResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertContentResponse self = new InsertContentResponse();
        return TeaModel.build(map, self);
    }

    public InsertContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InsertContentResponse setBody(InsertContentResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertContentResponseBody getBody() {
        return this.body;
    }

}
