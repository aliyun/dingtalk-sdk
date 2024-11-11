// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceDataTransferDoneResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateInvoiceDataTransferDoneResponseBody body;

    public static UpdateInvoiceDataTransferDoneResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceDataTransferDoneResponse self = new UpdateInvoiceDataTransferDoneResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceDataTransferDoneResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInvoiceDataTransferDoneResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInvoiceDataTransferDoneResponse setBody(UpdateInvoiceDataTransferDoneResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInvoiceDataTransferDoneResponseBody getBody() {
        return this.body;
    }

}
