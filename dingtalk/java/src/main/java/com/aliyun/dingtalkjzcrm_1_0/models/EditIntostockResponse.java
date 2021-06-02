// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditIntostockResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditIntostockResponseBody body;

    public static EditIntostockResponse build(java.util.Map<String, ?> map) throws Exception {
        EditIntostockResponse self = new EditIntostockResponse();
        return TeaModel.build(map, self);
    }

    public EditIntostockResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditIntostockResponse setBody(EditIntostockResponseBody body) {
        this.body = body;
        return this;
    }
    public EditIntostockResponseBody getBody() {
        return this.body;
    }

}
