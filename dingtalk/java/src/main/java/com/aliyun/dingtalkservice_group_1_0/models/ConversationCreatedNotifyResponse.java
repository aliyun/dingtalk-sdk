// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationCreatedNotifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ConversationCreatedNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConversationCreatedNotifyResponse setBody(ConversationCreatedNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ConversationCreatedNotifyResponseBody getBody() {
        return this.body;
    }

}
