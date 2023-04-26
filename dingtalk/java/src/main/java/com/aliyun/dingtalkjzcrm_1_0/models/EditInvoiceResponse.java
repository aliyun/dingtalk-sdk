// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditInvoiceResponseBody body;

    public static EditInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        EditInvoiceResponse self = new EditInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public EditInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditInvoiceResponse setBody(EditInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public EditInvoiceResponseBody getBody() {
        return this.body;
    }

}
