// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RefundCommodityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public RefundCommodityResponse setBody(RefundCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public RefundCommodityResponseBody getBody() {
        return this.body;
    }

}
