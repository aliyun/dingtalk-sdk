// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceTransferDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInvoiceTransferDataResponseBody body;

    public static QueryInvoiceTransferDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceTransferDataResponse self = new QueryInvoiceTransferDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceTransferDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInvoiceTransferDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInvoiceTransferDataResponse setBody(QueryInvoiceTransferDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInvoiceTransferDataResponseBody getBody() {
        return this.body;
    }

}
