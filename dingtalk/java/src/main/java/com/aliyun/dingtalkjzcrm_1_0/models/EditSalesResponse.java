// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditSalesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public EditSalesResponse setBody(EditSalesResponseBody body) {
        this.body = body;
        return this;
    }
    public EditSalesResponseBody getBody() {
        return this.body;
    }

}
