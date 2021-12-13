// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChatSubAdminUpdateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ChatSubAdminUpdateResponseBody body;

    public static ChatSubAdminUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatSubAdminUpdateResponse self = new ChatSubAdminUpdateResponse();
        return TeaModel.build(map, self);
    }

    public ChatSubAdminUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatSubAdminUpdateResponse setBody(ChatSubAdminUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatSubAdminUpdateResponseBody getBody() {
        return this.body;
    }

}
