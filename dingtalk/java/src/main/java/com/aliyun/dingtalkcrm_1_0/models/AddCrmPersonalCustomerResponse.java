// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCrmPersonalCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddCrmPersonalCustomerResponse setBody(AddCrmPersonalCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCrmPersonalCustomerResponseBody getBody() {
        return this.body;
    }

}
