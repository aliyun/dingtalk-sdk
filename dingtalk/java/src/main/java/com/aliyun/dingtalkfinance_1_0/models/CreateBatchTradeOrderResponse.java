// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateBatchTradeOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateBatchTradeOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateBatchTradeOrderResponse setBody(CreateBatchTradeOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBatchTradeOrderResponseBody getBody() {
        return this.body;
    }

}
