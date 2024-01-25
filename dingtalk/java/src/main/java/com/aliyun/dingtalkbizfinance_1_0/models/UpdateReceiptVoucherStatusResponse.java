// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateReceiptVoucherStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateReceiptVoucherStatusResponseBody body;

    public static UpdateReceiptVoucherStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateReceiptVoucherStatusResponse self = new UpdateReceiptVoucherStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateReceiptVoucherStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateReceiptVoucherStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateReceiptVoucherStatusResponse setBody(UpdateReceiptVoucherStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateReceiptVoucherStatusResponseBody getBody() {
        return this.body;
    }

}
