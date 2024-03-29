// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAppOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAppOrderResponseBody body;

    public static CreateAppOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAppOrderResponse self = new CreateAppOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreateAppOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAppOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAppOrderResponse setBody(CreateAppOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAppOrderResponseBody getBody() {
        return this.body;
    }

}
