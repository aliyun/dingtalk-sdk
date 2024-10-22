// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SalaryThirdDataIntegrationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SalaryThirdDataIntegrationResponseBody body;

    public static SalaryThirdDataIntegrationResponse build(java.util.Map<String, ?> map) throws Exception {
        SalaryThirdDataIntegrationResponse self = new SalaryThirdDataIntegrationResponse();
        return TeaModel.build(map, self);
    }

    public SalaryThirdDataIntegrationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SalaryThirdDataIntegrationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SalaryThirdDataIntegrationResponse setBody(SalaryThirdDataIntegrationResponseBody body) {
        this.body = body;
        return this;
    }
    public SalaryThirdDataIntegrationResponseBody getBody() {
        return this.body;
    }

}
