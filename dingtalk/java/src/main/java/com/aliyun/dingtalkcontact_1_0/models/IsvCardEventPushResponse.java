// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsvCardEventPushResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IsvCardEventPushResponseBody body;

    public static IsvCardEventPushResponse build(java.util.Map<String, ?> map) throws Exception {
        IsvCardEventPushResponse self = new IsvCardEventPushResponse();
        return TeaModel.build(map, self);
    }

    public IsvCardEventPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsvCardEventPushResponse setBody(IsvCardEventPushResponseBody body) {
        this.body = body;
        return this;
    }
    public IsvCardEventPushResponseBody getBody() {
        return this.body;
    }

}
