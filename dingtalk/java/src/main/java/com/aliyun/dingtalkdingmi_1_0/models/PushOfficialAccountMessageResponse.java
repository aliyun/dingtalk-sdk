// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public PushOfficialAccountMessageResponse setBody(PushOfficialAccountMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PushOfficialAccountMessageResponseBody getBody() {
        return this.body;
    }

}
