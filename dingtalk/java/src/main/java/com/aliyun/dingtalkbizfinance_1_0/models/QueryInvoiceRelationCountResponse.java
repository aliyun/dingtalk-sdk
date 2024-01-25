// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceRelationCountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInvoiceRelationCountResponseBody body;

    public static QueryInvoiceRelationCountResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceRelationCountResponse self = new QueryInvoiceRelationCountResponse();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceRelationCountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInvoiceRelationCountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInvoiceRelationCountResponse setBody(QueryInvoiceRelationCountResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInvoiceRelationCountResponseBody getBody() {
        return this.body;
    }

}
