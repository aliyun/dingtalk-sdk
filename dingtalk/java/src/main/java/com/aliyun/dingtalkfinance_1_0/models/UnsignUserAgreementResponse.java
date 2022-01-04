// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UnsignUserAgreementResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UnsignUserAgreementResponse build(java.util.Map<String, ?> map) throws Exception {
        UnsignUserAgreementResponse self = new UnsignUserAgreementResponse();
        return TeaModel.build(map, self);
    }

    public UnsignUserAgreementResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
