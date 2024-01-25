// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PushOfficialAccountMessageResponseBody body;

    public static PushOfficialAccountMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PushOfficialAccountMessageResponse self = new PushOfficialAccountMessageResponse();
        return TeaModel.build(map, self);
    }

    public PushOfficialAccountMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushOfficialAccountMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushOfficialAccountMessageResponse setBody(PushOfficialAccountMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushOfficialAccountMessageResponseBody getBody() {
        return this.body;
    }

}
