// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

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

    public ValidateOrderUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ValidateOrderUpdateResponse setBody(ValidateOrderUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public ValidateOrderUpdateResponseBody getBody() {
        return this.body;
    }

}
