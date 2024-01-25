// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class InteractiveCardCreateInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InteractiveCardCreateInstanceResponseBody body;

    public static InteractiveCardCreateInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        InteractiveCardCreateInstanceResponse self = new InteractiveCardCreateInstanceResponse();
        return TeaModel.build(map, self);
    }

    public InteractiveCardCreateInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InteractiveCardCreateInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InteractiveCardCreateInstanceResponse setBody(InteractiveCardCreateInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public InteractiveCardCreateInstanceResponseBody getBody() {
        return this.body;
    }

}
