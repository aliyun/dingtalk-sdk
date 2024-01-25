// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpgradeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ValidateOrderUpgradeResponseBody body;

    public static ValidateOrderUpgradeResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderUpgradeResponse self = new ValidateOrderUpgradeResponse();
        return TeaModel.build(map, self);
    }

    public ValidateOrderUpgradeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateOrderUpgradeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateOrderUpgradeResponse setBody(ValidateOrderUpgradeResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateOrderUpgradeResponseBody getBody() {
        return this.body;
    }

}
