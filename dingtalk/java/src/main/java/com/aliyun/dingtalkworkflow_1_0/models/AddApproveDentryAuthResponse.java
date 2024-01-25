// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddApproveDentryAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public AddApproveDentryAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddApproveDentryAuthResponse setBody(AddApproveDentryAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public AddApproveDentryAuthResponseBody getBody() {
        return this.body;
    }

}
