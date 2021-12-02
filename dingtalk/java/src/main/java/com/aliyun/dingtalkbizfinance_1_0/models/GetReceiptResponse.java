// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetReceiptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetReceiptResponseBody body;

    public static GetReceiptResponse build(java.util.Map<String, ?> map) throws Exception {
        GetReceiptResponse self = new GetReceiptResponse();
        return TeaModel.build(map, self);
    }

    public GetReceiptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetReceiptResponse setBody(GetReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public GetReceiptResponseBody getBody() {
        return this.body;
    }

}
