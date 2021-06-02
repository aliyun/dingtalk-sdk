// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditContactResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public EditContactResponse setBody(EditContactResponseBody body) {
        this.body = body;
        return this;
    }
    public EditContactResponseBody getBody() {
        return this.body;
    }

}
