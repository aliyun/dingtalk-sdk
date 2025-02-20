// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelReviewOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelReviewOrderResponseBody body;

    public static CancelReviewOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelReviewOrderResponse self = new CancelReviewOrderResponse();
        return TeaModel.build(map, self);
    }

    public CancelReviewOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelReviewOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelReviewOrderResponse setBody(CancelReviewOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelReviewOrderResponseBody getBody() {
        return this.body;
    }

}
