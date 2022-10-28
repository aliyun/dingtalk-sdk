// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateSnsAppOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateSnsAppOrderResponse setBody(CreateSnsAppOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSnsAppOrderResponseBody getBody() {
        return this.body;
    }

}
