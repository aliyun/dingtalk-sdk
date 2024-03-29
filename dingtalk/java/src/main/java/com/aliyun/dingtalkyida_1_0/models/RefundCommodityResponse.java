// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RefundCommodityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RefundCommodityResponseBody body;

    public static RefundCommodityResponse build(java.util.Map<String, ?> map) throws Exception {
        RefundCommodityResponse self = new RefundCommodityResponse();
        return TeaModel.build(map, self);
    }

    public RefundCommodityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RefundCommodityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RefundCommodityResponse setBody(RefundCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public RefundCommodityResponseBody getBody() {
        return this.body;
    }

}
