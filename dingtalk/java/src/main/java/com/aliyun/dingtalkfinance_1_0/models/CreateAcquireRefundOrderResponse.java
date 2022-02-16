// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateAcquireRefundOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateAcquireRefundOrderResponseBody body;

    public static CreateAcquireRefundOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAcquireRefundOrderResponse self = new CreateAcquireRefundOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreateAcquireRefundOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAcquireRefundOrderResponse setBody(CreateAcquireRefundOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAcquireRefundOrderResponseBody getBody() {
        return this.body;
    }

}
