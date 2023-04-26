// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewTenantOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RenewTenantOrderResponseBody body;

    public static RenewTenantOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        RenewTenantOrderResponse self = new RenewTenantOrderResponse();
        return TeaModel.build(map, self);
    }

    public RenewTenantOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RenewTenantOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RenewTenantOrderResponse setBody(RenewTenantOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public RenewTenantOrderResponseBody getBody() {
        return this.body;
    }

}
