// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditCustomerResponseBody body;

    public static EditCustomerResponse build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerResponse self = new EditCustomerResponse();
        return TeaModel.build(map, self);
    }

    public EditCustomerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditCustomerResponse setBody(EditCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public EditCustomerResponseBody getBody() {
        return this.body;
    }

}
