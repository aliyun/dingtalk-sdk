// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditProductionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditProductionResponseBody body;

    public static EditProductionResponse build(java.util.Map<String, ?> map) throws Exception {
        EditProductionResponse self = new EditProductionResponse();
        return TeaModel.build(map, self);
    }

    public EditProductionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditProductionResponse setBody(EditProductionResponseBody body) {
        this.body = body;
        return this;
    }
    public EditProductionResponseBody getBody() {
        return this.body;
    }

}
