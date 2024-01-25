// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSnsAppOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSnsAppOrderResponseBody body;

    public static CreateSnsAppOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSnsAppOrderResponse self = new CreateSnsAppOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreateSnsAppOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSnsAppOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSnsAppOrderResponse setBody(CreateSnsAppOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSnsAppOrderResponseBody getBody() {
        return this.body;
    }

}
