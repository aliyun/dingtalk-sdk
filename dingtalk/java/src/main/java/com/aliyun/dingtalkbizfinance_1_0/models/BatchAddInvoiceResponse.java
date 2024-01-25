// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchAddInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchAddInvoiceResponseBody body;

    public static BatchAddInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddInvoiceResponse self = new BatchAddInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchAddInvoiceResponse setBody(BatchAddInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddInvoiceResponseBody getBody() {
        return this.body;
    }

}
