// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateBatchTradeOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateBatchTradeOrderResponseBody body;

    public static CreateBatchTradeOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateBatchTradeOrderResponse self = new CreateBatchTradeOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreateBatchTradeOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateBatchTradeOrderResponse setBody(CreateBatchTradeOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBatchTradeOrderResponseBody getBody() {
        return this.body;
    }

}
