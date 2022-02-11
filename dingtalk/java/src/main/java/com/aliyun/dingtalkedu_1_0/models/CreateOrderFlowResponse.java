// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderFlowResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateOrderFlowResponseBody body;

    public static CreateOrderFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateOrderFlowResponse self = new CreateOrderFlowResponse();
        return TeaModel.build(map, self);
    }

    public CreateOrderFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateOrderFlowResponse setBody(CreateOrderFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateOrderFlowResponseBody getBody() {
        return this.body;
    }

}
