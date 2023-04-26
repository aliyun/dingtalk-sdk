// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetAllCustomerRecyclesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllCustomerRecyclesResponseBody body;

    public static GetAllCustomerRecyclesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllCustomerRecyclesResponse self = new GetAllCustomerRecyclesResponse();
        return TeaModel.build(map, self);
    }

    public GetAllCustomerRecyclesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllCustomerRecyclesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllCustomerRecyclesResponse setBody(GetAllCustomerRecyclesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllCustomerRecyclesResponseBody getBody() {
        return this.body;
    }

}
