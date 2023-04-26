// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCustomerResponseBody body;

    public static GetCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerResponse self = new GetCustomerResponse();
        return TeaModel.build(map, self);
    }

    public GetCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCustomerResponse setBody(GetCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCustomerResponseBody getBody() {
        return this.body;
    }

}
