// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyInvoiceRelationCountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCompanyInvoiceRelationCountResponseBody body;

    public static QueryCompanyInvoiceRelationCountResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyInvoiceRelationCountResponse self = new QueryCompanyInvoiceRelationCountResponse();
        return TeaModel.build(map, self);
    }

    public QueryCompanyInvoiceRelationCountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCompanyInvoiceRelationCountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCompanyInvoiceRelationCountResponse setBody(QueryCompanyInvoiceRelationCountResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCompanyInvoiceRelationCountResponseBody getBody() {
        return this.body;
    }

}
