// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetInvoiceByPageResponseBody body;

    public static GetInvoiceByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageResponse self = new GetInvoiceByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInvoiceByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInvoiceByPageResponse setBody(GetInvoiceByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInvoiceByPageResponseBody getBody() {
        return this.body;
    }

}
