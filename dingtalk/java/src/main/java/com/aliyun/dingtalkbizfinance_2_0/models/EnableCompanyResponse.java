// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableCompanyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EnableCompanyResponseBody body;

    public static EnableCompanyResponse build(java.util.Map<String, ?> map) throws Exception {
        EnableCompanyResponse self = new EnableCompanyResponse();
        return TeaModel.build(map, self);
    }

    public EnableCompanyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EnableCompanyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EnableCompanyResponse setBody(EnableCompanyResponseBody body) {
        this.body = body;
        return this;
    }
    public EnableCompanyResponseBody getBody() {
        return this.body;
    }

}
