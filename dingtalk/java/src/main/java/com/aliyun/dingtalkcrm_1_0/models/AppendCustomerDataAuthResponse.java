// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AppendCustomerDataAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppendCustomerDataAuthResponseBody body;

    public static AppendCustomerDataAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        AppendCustomerDataAuthResponse self = new AppendCustomerDataAuthResponse();
        return TeaModel.build(map, self);
    }

    public AppendCustomerDataAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppendCustomerDataAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppendCustomerDataAuthResponse setBody(AppendCustomerDataAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public AppendCustomerDataAuthResponseBody getBody() {
        return this.body;
    }

}
