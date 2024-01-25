// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateUserCodeInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateUserCodeInstanceResponseBody body;

    public static CreateUserCodeInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateUserCodeInstanceResponse self = new CreateUserCodeInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CreateUserCodeInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateUserCodeInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateUserCodeInstanceResponse setBody(CreateUserCodeInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateUserCodeInstanceResponseBody getBody() {
        return this.body;
    }

}
