// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ResaleOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ResaleOrderResponseBody body;

    public static ResaleOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        ResaleOrderResponse self = new ResaleOrderResponse();
        return TeaModel.build(map, self);
    }

    public ResaleOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ResaleOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ResaleOrderResponse setBody(ResaleOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public ResaleOrderResponseBody getBody() {
        return this.body;
    }

}
