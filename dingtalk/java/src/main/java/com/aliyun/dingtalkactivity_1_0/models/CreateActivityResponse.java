// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class CreateActivityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateActivityResponseBody body;

    public static CreateActivityResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateActivityResponse self = new CreateActivityResponse();
        return TeaModel.build(map, self);
    }

    public CreateActivityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateActivityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateActivityResponse setBody(CreateActivityResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateActivityResponseBody getBody() {
        return this.body;
    }

}
