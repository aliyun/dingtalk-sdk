// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateCardWithDelegateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCardWithDelegateResponseBody body;

    public static CreateCardWithDelegateResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCardWithDelegateResponse self = new CreateCardWithDelegateResponse();
        return TeaModel.build(map, self);
    }

    public CreateCardWithDelegateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCardWithDelegateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCardWithDelegateResponse setBody(CreateCardWithDelegateResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCardWithDelegateResponseBody getBody() {
        return this.body;
    }

}
