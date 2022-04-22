// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationCreatedNotifyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConversationCreatedNotifyResponseBody body;

    public static ConversationCreatedNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        ConversationCreatedNotifyResponse self = new ConversationCreatedNotifyResponse();
        return TeaModel.build(map, self);
    }

    public ConversationCreatedNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConversationCreatedNotifyResponse setBody(ConversationCreatedNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ConversationCreatedNotifyResponseBody getBody() {
        return this.body;
    }

}
