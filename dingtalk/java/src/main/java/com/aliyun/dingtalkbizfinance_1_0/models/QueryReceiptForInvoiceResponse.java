// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptForInvoiceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryReceiptForInvoiceResponse setBody(QueryReceiptForInvoiceResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptForInvoiceResponseBody getBody() {
        return this.body;
    }

}
