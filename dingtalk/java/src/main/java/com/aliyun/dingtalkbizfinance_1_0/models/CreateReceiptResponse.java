// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateReceiptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateReceiptResponseBody body;

    public static CreateReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateReceiptResponse self = new CreateReceiptResponse();
        return TeaModel.build(map, self);
    }

    public CreateReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateReceiptResponse setBody(CreateReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateReceiptResponseBody getBody() {
        return this.body;
    }

}
