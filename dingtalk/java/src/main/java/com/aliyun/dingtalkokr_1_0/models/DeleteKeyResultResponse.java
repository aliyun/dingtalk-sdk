// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteKeyResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteKeyResultResponseBody body;

    public static DeleteKeyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteKeyResultResponse self = new DeleteKeyResultResponse();
        return TeaModel.build(map, self);
    }

    public DeleteKeyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteKeyResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteKeyResultResponse setBody(DeleteKeyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteKeyResultResponseBody getBody() {
        return this.body;
    }

}
