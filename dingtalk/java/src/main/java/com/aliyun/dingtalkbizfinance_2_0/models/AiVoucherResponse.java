// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AiVoucherResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiVoucherResponseBody body;

    public static AiVoucherResponse build(java.util.Map<String, ?> map) throws Exception {
        AiVoucherResponse self = new AiVoucherResponse();
        return TeaModel.build(map, self);
    }

    public AiVoucherResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiVoucherResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiVoucherResponse setBody(AiVoucherResponseBody body) {
        this.body = body;
        return this;
    }
    public AiVoucherResponseBody getBody() {
        return this.body;
    }

}
