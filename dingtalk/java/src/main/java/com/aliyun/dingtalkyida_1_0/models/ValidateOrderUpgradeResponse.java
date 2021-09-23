// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpgradeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ValidateOrderUpgradeResponse setBody(ValidateOrderUpgradeResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateOrderUpgradeResponseBody getBody() {
        return this.body;
    }

}
