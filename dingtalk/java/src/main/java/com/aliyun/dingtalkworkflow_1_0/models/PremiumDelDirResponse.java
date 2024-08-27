// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDelDirResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumDelDirResponseBody body;

    public static PremiumDelDirResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumDelDirResponse self = new PremiumDelDirResponse();
        return TeaModel.build(map, self);
    }

    public PremiumDelDirResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumDelDirResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumDelDirResponse setBody(PremiumDelDirResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumDelDirResponseBody getBody() {
        return this.body;
    }

}
