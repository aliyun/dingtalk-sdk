// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptDetailForInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryReceiptDetailForInvoiceResponse setBody(QueryReceiptDetailForInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptDetailForInvoiceResponseBody getBody() {
        return this.body;
    }

}
