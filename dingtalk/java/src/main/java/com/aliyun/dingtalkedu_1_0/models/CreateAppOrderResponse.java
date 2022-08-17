// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAppOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateAppOrderResponse setBody(CreateAppOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAppOrderResponseBody getBody() {
        return this.body;
    }

}
