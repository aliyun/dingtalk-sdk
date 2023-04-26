// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditOutstockResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EditOutstockResponseBody body;

    public static EditOutstockResponse build(java.util.Map<String, ?> map) throws Exception {
        EditOutstockResponse self = new EditOutstockResponse();
        return TeaModel.build(map, self);
    }

    public EditOutstockResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditOutstockResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditOutstockResponse setBody(EditOutstockResponseBody body) {
        this.body = body;
        return this;
    }
    public EditOutstockResponseBody getBody() {
        return this.body;
    }

}
