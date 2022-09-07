// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddApproveDentryAuthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddApproveDentryAuthResponseBody body;

    public static AddApproveDentryAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        AddApproveDentryAuthResponse self = new AddApproveDentryAuthResponse();
        return TeaModel.build(map, self);
    }

    public AddApproveDentryAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddApproveDentryAuthResponse setBody(AddApproveDentryAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public AddApproveDentryAuthResponseBody getBody() {
        return this.body;
    }

}
