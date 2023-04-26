// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AutoOpenDingTalkConnectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AutoOpenDingTalkConnectResponseBody body;

    public static AutoOpenDingTalkConnectResponse build(java.util.Map<String, ?> map) throws Exception {
        AutoOpenDingTalkConnectResponse self = new AutoOpenDingTalkConnectResponse();
        return TeaModel.build(map, self);
    }

    public AutoOpenDingTalkConnectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AutoOpenDingTalkConnectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AutoOpenDingTalkConnectResponse setBody(AutoOpenDingTalkConnectResponseBody body) {
        this.body = body;
        return this;
    }
    public AutoOpenDingTalkConnectResponseBody getBody() {
        return this.body;
    }

}
