// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationServiceOrderUpgradeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ValidateApplicationServiceOrderUpgradeResponseBody body;

    public static ValidateApplicationServiceOrderUpgradeResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationServiceOrderUpgradeResponse self = new ValidateApplicationServiceOrderUpgradeResponse();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationServiceOrderUpgradeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateApplicationServiceOrderUpgradeResponse setBody(ValidateApplicationServiceOrderUpgradeResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateApplicationServiceOrderUpgradeResponseBody getBody() {
        return this.body;
    }

}
