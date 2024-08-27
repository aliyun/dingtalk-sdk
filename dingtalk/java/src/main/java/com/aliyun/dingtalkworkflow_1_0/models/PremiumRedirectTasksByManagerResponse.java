// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRedirectTasksByManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumRedirectTasksByManagerResponseBody body;

    public static PremiumRedirectTasksByManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumRedirectTasksByManagerResponse self = new PremiumRedirectTasksByManagerResponse();
        return TeaModel.build(map, self);
    }

    public PremiumRedirectTasksByManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumRedirectTasksByManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumRedirectTasksByManagerResponse setBody(PremiumRedirectTasksByManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumRedirectTasksByManagerResponseBody getBody() {
        return this.body;
    }

}
