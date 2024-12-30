// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceUrlResponseBody body;

    public static UpdateInvoiceUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceUrlResponse self = new UpdateInvoiceUrlResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceUrlResponse setBody(UpdateInvoiceUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceUrlResponseBody getBody() {
        return this.body;
    }

}
