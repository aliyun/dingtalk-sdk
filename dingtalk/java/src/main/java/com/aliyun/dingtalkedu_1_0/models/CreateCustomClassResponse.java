// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomClassResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateCustomClassResponseBody body;

    public static CreateCustomClassResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomClassResponse self = new CreateCustomClassResponse();
        return TeaModel.build(map, self);
    }

    public CreateCustomClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCustomClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCustomClassResponse setBody(CreateCustomClassResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCustomClassResponseBody getBody() {
        return this.body;
    }

}
