// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class SignEnterpriseAccountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SignEnterpriseAccountResponseBody body;

    public static SignEnterpriseAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        SignEnterpriseAccountResponse self = new SignEnterpriseAccountResponse();
        return TeaModel.build(map, self);
    }

    public SignEnterpriseAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SignEnterpriseAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SignEnterpriseAccountResponse setBody(SignEnterpriseAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public SignEnterpriseAccountResponseBody getBody() {
        return this.body;
    }

}
