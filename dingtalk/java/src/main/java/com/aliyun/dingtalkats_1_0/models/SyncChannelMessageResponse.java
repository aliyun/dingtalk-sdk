// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncChannelMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SyncChannelMessageResponseBody body;

    public static SyncChannelMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncChannelMessageResponse self = new SyncChannelMessageResponse();
        return TeaModel.build(map, self);
    }

    public SyncChannelMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncChannelMessageResponse setBody(SyncChannelMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncChannelMessageResponseBody getBody() {
        return this.body;
    }

}
