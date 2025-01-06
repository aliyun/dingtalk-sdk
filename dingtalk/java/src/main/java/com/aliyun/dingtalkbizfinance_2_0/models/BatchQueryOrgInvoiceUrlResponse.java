// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryOrgInvoiceUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryOrgInvoiceUrlResponseBody body;

    public static BatchQueryOrgInvoiceUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOrgInvoiceUrlResponse self = new BatchQueryOrgInvoiceUrlResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryOrgInvoiceUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryOrgInvoiceUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryOrgInvoiceUrlResponse setBody(BatchQueryOrgInvoiceUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryOrgInvoiceUrlResponseBody getBody() {
        return this.body;
    }

}
