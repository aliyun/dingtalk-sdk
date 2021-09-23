// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderBuyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ValidateOrderBuyResponseBody body;

    public static ValidateOrderBuyResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderBuyResponse self = new ValidateOrderBuyResponse();
        return TeaModel.build(map, self);
    }

    public ValidateOrderBuyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateOrderBuyResponse setBody(ValidateOrderBuyResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateOrderBuyResponseBody getBody() {
        return this.body;
    }

}
