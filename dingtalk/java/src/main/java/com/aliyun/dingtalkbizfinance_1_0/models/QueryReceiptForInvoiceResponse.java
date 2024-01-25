// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryReceiptForInvoiceResponseBody body;

    public static QueryReceiptForInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptForInvoiceResponse self = new QueryReceiptForInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public QueryReceiptForInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReceiptForInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryReceiptForInvoiceResponse setBody(QueryReceiptForInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptForInvoiceResponseBody getBody() {
        return this.body;
    }

}
