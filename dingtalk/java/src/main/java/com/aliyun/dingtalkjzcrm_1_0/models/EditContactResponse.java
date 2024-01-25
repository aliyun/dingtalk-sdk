// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EditContactResponseBody body;

    public static EditContactResponse build(java.util.Map<String, ?> map) throws Exception {
        EditContactResponse self = new EditContactResponse();
        return TeaModel.build(map, self);
    }

    public EditContactResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditContactResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EditContactResponse setBody(EditContactResponseBody body) {
        this.body = body;
        return this;
    }
    public EditContactResponseBody getBody() {
        return this.body;
    }

}
