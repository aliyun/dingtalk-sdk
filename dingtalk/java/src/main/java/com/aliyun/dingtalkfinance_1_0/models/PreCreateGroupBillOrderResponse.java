// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class PreCreateGroupBillOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PreCreateGroupBillOrderResponseBody body;

    public static PreCreateGroupBillOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        PreCreateGroupBillOrderResponse self = new PreCreateGroupBillOrderResponse();
        return TeaModel.build(map, self);
    }

    public PreCreateGroupBillOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreCreateGroupBillOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreCreateGroupBillOrderResponse setBody(PreCreateGroupBillOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public PreCreateGroupBillOrderResponseBody getBody() {
        return this.body;
    }

}
