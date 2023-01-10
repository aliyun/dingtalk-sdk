// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetEnableResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SetEnableResponseBody body;

    public static SetEnableResponse build(java.util.Map<String, ?> map) throws Exception {
        SetEnableResponse self = new SetEnableResponse();
        return TeaModel.build(map, self);
    }

    public SetEnableResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetEnableResponse setBody(SetEnableResponseBody body) {
        this.body = body;
        return this;
    }
    public SetEnableResponseBody getBody() {
        return this.body;
    }

}
