// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferBeginNotifyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ConversationTransferBeginNotifyResponseBody body;

    public static ConversationTransferBeginNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        ConversationTransferBeginNotifyResponse self = new ConversationTransferBeginNotifyResponse();
        return TeaModel.build(map, self);
    }

    public ConversationTransferBeginNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConversationTransferBeginNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConversationTransferBeginNotifyResponse setBody(ConversationTransferBeginNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ConversationTransferBeginNotifyResponseBody getBody() {
        return this.body;
    }

}
