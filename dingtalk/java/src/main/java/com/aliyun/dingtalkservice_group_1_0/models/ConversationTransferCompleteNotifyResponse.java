// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferCompleteNotifyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConversationTransferCompleteNotifyResponseBody body;

    public static ConversationTransferCompleteNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        ConversationTransferCompleteNotifyResponse self = new ConversationTransferCompleteNotifyResponse();
        return TeaModel.build(map, self);
    }

    public ConversationTransferCompleteNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConversationTransferCompleteNotifyResponse setBody(ConversationTransferCompleteNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ConversationTransferCompleteNotifyResponseBody getBody() {
        return this.body;
    }

}