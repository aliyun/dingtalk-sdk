// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerPoolResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditCustomerPoolResponseBody body;

    public static EditCustomerPoolResponse build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerPoolResponse self = new EditCustomerPoolResponse();
        return TeaModel.build(map, self);
    }

    public EditCustomerPoolResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditCustomerPoolResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditCustomerPoolResponse setBody(EditCustomerPoolResponseBody body) {
        this.body = body;
        return this;
    }
    public EditCustomerPoolResponseBody getBody() {
        return this.body;
    }

}
