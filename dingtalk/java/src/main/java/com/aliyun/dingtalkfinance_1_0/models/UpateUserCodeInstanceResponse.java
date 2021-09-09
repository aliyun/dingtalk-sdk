// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpateUserCodeInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpateUserCodeInstanceResponseBody body;

    public static UpateUserCodeInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpateUserCodeInstanceResponse self = new UpateUserCodeInstanceResponse();
        return TeaModel.build(map, self);
    }

    public UpateUserCodeInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpateUserCodeInstanceResponse setBody(UpateUserCodeInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpateUserCodeInstanceResponseBody getBody() {
        return this.body;
    }

}
