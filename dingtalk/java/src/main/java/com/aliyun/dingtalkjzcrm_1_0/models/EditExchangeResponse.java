// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditExchangeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditExchangeResponseBody body;

    public static EditExchangeResponse build(java.util.Map<String, ?> map) throws Exception {
        EditExchangeResponse self = new EditExchangeResponse();
        return TeaModel.build(map, self);
    }

    public EditExchangeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditExchangeResponse setBody(EditExchangeResponseBody body) {
        this.body = body;
        return this;
    }
    public EditExchangeResponseBody getBody() {
        return this.body;
    }

}
