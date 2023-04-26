// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UserAgreementPageSignResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UserAgreementPageSignResponseBody body;

    public static UserAgreementPageSignResponse build(java.util.Map<String, ?> map) throws Exception {
        UserAgreementPageSignResponse self = new UserAgreementPageSignResponse();
        return TeaModel.build(map, self);
    }

    public UserAgreementPageSignResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserAgreementPageSignResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UserAgreementPageSignResponse setBody(UserAgreementPageSignResponseBody body) {
        this.body = body;
        return this;
    }
    public UserAgreementPageSignResponseBody getBody() {
        return this.body;
    }

}
