// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RemoveTenantResourceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveTenantResourceResponseBody body;

    public static RemoveTenantResourceResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveTenantResourceResponse self = new RemoveTenantResourceResponse();
        return TeaModel.build(map, self);
    }

    public RemoveTenantResourceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveTenantResourceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveTenantResourceResponse setBody(RemoveTenantResourceResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveTenantResourceResponseBody getBody() {
        return this.body;
    }

}
