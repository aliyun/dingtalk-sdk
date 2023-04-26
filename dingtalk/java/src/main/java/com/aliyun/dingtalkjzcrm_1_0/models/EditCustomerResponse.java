// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

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

    public EditCustomerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditCustomerResponse setBody(EditCustomerResponseBody body) {
        this.body = body;
        return this;
    }
    public EditCustomerResponseBody getBody() {
        return this.body;
    }

}
