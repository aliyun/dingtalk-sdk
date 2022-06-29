// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceRelationCountResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryInvoiceRelationCountResponse setBody(QueryInvoiceRelationCountResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInvoiceRelationCountResponseBody getBody() {
        return this.body;
    }

}
