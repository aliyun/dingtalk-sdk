// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CloseConversationResponseBody body;

    public static CloseConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseConversationResponse self = new CloseConversationResponse();
        return TeaModel.build(map, self);
    }

    public CloseConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseConversationResponse setBody(CloseConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseConversationResponseBody getBody() {
        return this.body;
    }

}
