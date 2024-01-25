// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class CreateKeyResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateKeyResultResponseBody body;

    public static CreateKeyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateKeyResultResponse self = new CreateKeyResultResponse();
        return TeaModel.build(map, self);
    }

    public CreateKeyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateKeyResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateKeyResultResponse setBody(CreateKeyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateKeyResultResponseBody getBody() {
        return this.body;
    }

}
