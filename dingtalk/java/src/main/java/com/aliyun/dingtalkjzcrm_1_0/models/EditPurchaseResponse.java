// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditPurchaseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditPurchaseResponseBody body;

    public static EditPurchaseResponse build(java.util.Map<String, ?> map) throws Exception {
        EditPurchaseResponse self = new EditPurchaseResponse();
        return TeaModel.build(map, self);
    }

    public EditPurchaseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditPurchaseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditPurchaseResponse setBody(EditPurchaseResponseBody body) {
        this.body = body;
        return this;
    }
    public EditPurchaseResponseBody getBody() {
        return this.body;
    }

}
