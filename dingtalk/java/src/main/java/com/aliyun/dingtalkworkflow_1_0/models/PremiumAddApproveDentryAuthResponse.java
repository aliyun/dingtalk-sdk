// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAddApproveDentryAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumAddApproveDentryAuthResponseBody body;

    public static PremiumAddApproveDentryAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumAddApproveDentryAuthResponse self = new PremiumAddApproveDentryAuthResponse();
        return TeaModel.build(map, self);
    }

    public PremiumAddApproveDentryAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumAddApproveDentryAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumAddApproveDentryAuthResponse setBody(PremiumAddApproveDentryAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumAddApproveDentryAuthResponseBody getBody() {
        return this.body;
    }

}
