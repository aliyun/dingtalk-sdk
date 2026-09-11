// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class EnsureUserLicenseAccessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnsureUserLicenseAccessResponseBody body;

    public static EnsureUserLicenseAccessResponse build(java.util.Map<String, ?> map) throws Exception {
        EnsureUserLicenseAccessResponse self = new EnsureUserLicenseAccessResponse();
        return TeaModel.build(map, self);
    }

    public EnsureUserLicenseAccessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnsureUserLicenseAccessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnsureUserLicenseAccessResponse setBody(EnsureUserLicenseAccessResponseBody body) {
        this.body = body;
        return this;
    }
    public EnsureUserLicenseAccessResponseBody getBody() {
        return this.body;
    }

}
