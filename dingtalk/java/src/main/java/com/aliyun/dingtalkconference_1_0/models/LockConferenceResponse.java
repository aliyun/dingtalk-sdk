// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class LockConferenceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LockConferenceResponseBody body;

    public static LockConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        LockConferenceResponse self = new LockConferenceResponse();
        return TeaModel.build(map, self);
    }

    public LockConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LockConferenceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LockConferenceResponse setBody(LockConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public LockConferenceResponseBody getBody() {
        return this.body;
    }

}
