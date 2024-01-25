// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateMessageCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateMessageCategoryResponseBody body;

    public static CreateMessageCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateMessageCategoryResponse self = new CreateMessageCategoryResponse();
        return TeaModel.build(map, self);
    }

    public CreateMessageCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateMessageCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateMessageCategoryResponse setBody(CreateMessageCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateMessageCategoryResponseBody getBody() {
        return this.body;
    }

}
