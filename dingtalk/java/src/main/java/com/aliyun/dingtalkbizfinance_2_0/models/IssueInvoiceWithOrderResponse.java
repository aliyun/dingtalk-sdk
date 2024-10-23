// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class IssueInvoiceWithOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IssueInvoiceWithOrderResponseBody body;

    public static IssueInvoiceWithOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        IssueInvoiceWithOrderResponse self = new IssueInvoiceWithOrderResponse();
        return TeaModel.build(map, self);
    }

    public IssueInvoiceWithOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IssueInvoiceWithOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IssueInvoiceWithOrderResponse setBody(IssueInvoiceWithOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public IssueInvoiceWithOrderResponseBody getBody() {
        return this.body;
    }

}
