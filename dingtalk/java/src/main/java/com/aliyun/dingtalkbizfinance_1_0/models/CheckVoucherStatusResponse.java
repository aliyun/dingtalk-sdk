// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CheckVoucherStatusResponseBody body;

    public static CheckVoucherStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckVoucherStatusResponse self = new CheckVoucherStatusResponse();
        return TeaModel.build(map, self);
    }

    public CheckVoucherStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckVoucherStatusResponse setBody(CheckVoucherStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckVoucherStatusResponseBody getBody() {
        return this.body;
    }

}
