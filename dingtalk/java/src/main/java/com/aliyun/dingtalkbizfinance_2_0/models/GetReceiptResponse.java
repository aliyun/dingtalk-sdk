// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetReceiptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetReceiptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetReceiptResponse setBody(GetReceiptResponseBody body) {
        this.body = body;
        return this;
    }
    public GetReceiptResponseBody getBody() {
        return this.body;
    }

}
