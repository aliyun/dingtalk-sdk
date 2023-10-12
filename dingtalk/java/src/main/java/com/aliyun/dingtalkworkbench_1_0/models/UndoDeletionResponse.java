// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class UndoDeletionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UndoDeletionResponseBody body;

    public static UndoDeletionResponse build(java.util.Map<String, ?> map) throws Exception {
        UndoDeletionResponse self = new UndoDeletionResponse();
        return TeaModel.build(map, self);
    }

    public UndoDeletionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UndoDeletionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UndoDeletionResponse setBody(UndoDeletionResponseBody body) {
        this.body = body;
        return this;
    }
    public UndoDeletionResponseBody getBody() {
        return this.body;
    }

}
