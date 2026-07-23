// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class PurchaseMixViewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PurchaseMixViewResponseBody body;

    public static PurchaseMixViewResponse build(java.util.Map<String, ?> map) throws Exception {
        PurchaseMixViewResponse self = new PurchaseMixViewResponse();
        return TeaModel.build(map, self);
    }

    public PurchaseMixViewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PurchaseMixViewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PurchaseMixViewResponse setBody(PurchaseMixViewResponseBody body) {
        this.body = body;
        return this;
    }
    public PurchaseMixViewResponseBody getBody() {
        return this.body;
    }

}
