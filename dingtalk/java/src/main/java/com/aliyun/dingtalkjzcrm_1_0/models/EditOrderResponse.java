// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditOrderResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditOrderResponseBody body;

    public static EditOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        EditOrderResponse self = new EditOrderResponse();
        return TeaModel.build(map, self);
    }

    public EditOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditOrderResponse setBody(EditOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public EditOrderResponseBody getBody() {
        return this.body;
    }

}
