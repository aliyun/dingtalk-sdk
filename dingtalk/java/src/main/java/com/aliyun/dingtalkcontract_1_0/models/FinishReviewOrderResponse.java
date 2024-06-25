// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class FinishReviewOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FinishReviewOrderResponseBody body;

    public static FinishReviewOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        FinishReviewOrderResponse self = new FinishReviewOrderResponse();
        return TeaModel.build(map, self);
    }

    public FinishReviewOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FinishReviewOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FinishReviewOrderResponse setBody(FinishReviewOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public FinishReviewOrderResponseBody getBody() {
        return this.body;
    }

}
