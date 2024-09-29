// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryUseNewInvoiceAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUseNewInvoiceAppResponseBody body;

    public static QueryUseNewInvoiceAppResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUseNewInvoiceAppResponse self = new QueryUseNewInvoiceAppResponse();
        return TeaModel.build(map, self);
    }

    public QueryUseNewInvoiceAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUseNewInvoiceAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUseNewInvoiceAppResponse setBody(QueryUseNewInvoiceAppResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUseNewInvoiceAppResponseBody getBody() {
        return this.body;
    }

}
