// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class OverrideUpdateCustomerDataAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OverrideUpdateCustomerDataAuthResponseBody body;

    public static OverrideUpdateCustomerDataAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        OverrideUpdateCustomerDataAuthResponse self = new OverrideUpdateCustomerDataAuthResponse();
        return TeaModel.build(map, self);
    }

    public OverrideUpdateCustomerDataAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OverrideUpdateCustomerDataAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OverrideUpdateCustomerDataAuthResponse setBody(OverrideUpdateCustomerDataAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public OverrideUpdateCustomerDataAuthResponseBody getBody() {
        return this.body;
    }

}
