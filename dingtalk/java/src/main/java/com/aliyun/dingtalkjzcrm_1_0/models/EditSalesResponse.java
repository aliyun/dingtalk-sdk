// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditSalesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditSalesResponseBody body;

    public static EditSalesResponse build(java.util.Map<String, ?> map) throws Exception {
        EditSalesResponse self = new EditSalesResponse();
        return TeaModel.build(map, self);
    }

    public EditSalesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditSalesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditSalesResponse setBody(EditSalesResponseBody body) {
        this.body = body;
        return this;
    }
    public EditSalesResponseBody getBody() {
        return this.body;
    }

}
