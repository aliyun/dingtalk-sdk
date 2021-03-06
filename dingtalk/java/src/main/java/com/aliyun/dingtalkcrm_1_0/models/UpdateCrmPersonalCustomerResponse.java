// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCrmPersonalCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateCrmPersonalCustomerResponseBody body;

    public static UpdateCrmPersonalCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCrmPersonalCustomerResponse self = new UpdateCrmPersonalCustomerResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCrmPersonalCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCrmPersonalCustomerResponse setBody(UpdateCrmPersonalCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCrmPersonalCustomerResponseBody getBody() {
        return this.body;
    }

}
