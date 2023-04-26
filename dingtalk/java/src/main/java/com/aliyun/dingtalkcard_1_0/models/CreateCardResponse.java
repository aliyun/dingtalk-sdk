// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateCardResponseBody body;

    public static CreateCardResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCardResponse self = new CreateCardResponse();
        return TeaModel.build(map, self);
    }

    public CreateCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCardResponse setBody(CreateCardResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCardResponseBody getBody() {
        return this.body;
    }

}
