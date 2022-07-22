// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVoucherStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInvoiceVoucherStatusResponseBody body;

    public static UpdateInvoiceVoucherStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVoucherStatusResponse self = new UpdateInvoiceVoucherStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVoucherStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceVoucherStatusResponse setBody(UpdateInvoiceVoucherStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceVoucherStatusResponseBody getBody() {
        return this.body;
    }

}
