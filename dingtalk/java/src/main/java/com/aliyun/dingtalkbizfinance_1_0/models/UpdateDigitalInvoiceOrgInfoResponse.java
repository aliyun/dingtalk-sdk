// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateDigitalInvoiceOrgInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDigitalInvoiceOrgInfoResponseBody body;

    public static UpdateDigitalInvoiceOrgInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateDigitalInvoiceOrgInfoResponse self = new UpdateDigitalInvoiceOrgInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateDigitalInvoiceOrgInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateDigitalInvoiceOrgInfoResponse setBody(UpdateDigitalInvoiceOrgInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateDigitalInvoiceOrgInfoResponseBody getBody() {
        return this.body;
    }

}
