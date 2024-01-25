// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCrmPersonalCustomerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCrmPersonalCustomerResponseBody body;

    public static AddCrmPersonalCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCrmPersonalCustomerResponse self = new AddCrmPersonalCustomerResponse();
        return TeaModel.build(map, self);
    }

    public AddCrmPersonalCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCrmPersonalCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCrmPersonalCustomerResponse setBody(AddCrmPersonalCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCrmPersonalCustomerResponseBody getBody() {
        return this.body;
    }

}
