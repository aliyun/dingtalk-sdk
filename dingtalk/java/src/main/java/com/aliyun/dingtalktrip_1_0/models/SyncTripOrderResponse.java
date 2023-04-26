// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SyncTripOrderResponseBody body;

    public static SyncTripOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncTripOrderResponse self = new SyncTripOrderResponse();
        return TeaModel.build(map, self);
    }

    public SyncTripOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncTripOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncTripOrderResponse setBody(SyncTripOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncTripOrderResponseBody getBody() {
        return this.body;
    }

}
