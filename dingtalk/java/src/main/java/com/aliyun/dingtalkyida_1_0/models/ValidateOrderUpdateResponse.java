// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ValidateOrderUpdateResponseBody body;

    public static ValidateOrderUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderUpdateResponse self = new ValidateOrderUpdateResponse();
        return TeaModel.build(map, self);
    }

    public ValidateOrderUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ValidateOrderUpdateResponse setBody(ValidateOrderUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateOrderUpdateResponseBody getBody() {
        return this.body;
    }

}
