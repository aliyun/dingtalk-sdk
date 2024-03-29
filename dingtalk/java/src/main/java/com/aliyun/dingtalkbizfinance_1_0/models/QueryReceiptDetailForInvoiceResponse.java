// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptDetailForInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryReceiptDetailForInvoiceResponseBody body;

    public static QueryReceiptDetailForInvoiceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptDetailForInvoiceResponse self = new QueryReceiptDetailForInvoiceResponse();
        return TeaModel.build(map, self);
    }

    public QueryReceiptDetailForInvoiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReceiptDetailForInvoiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryReceiptDetailForInvoiceResponse setBody(QueryReceiptDetailForInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptDetailForInvoiceResponseBody getBody() {
        return this.body;
    }

}
