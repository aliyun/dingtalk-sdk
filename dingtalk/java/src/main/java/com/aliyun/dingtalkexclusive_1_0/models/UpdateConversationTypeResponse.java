// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateConversationTypeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateConversationTypeResponseBody body;

    public static UpdateConversationTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateConversationTypeResponse self = new UpdateConversationTypeResponse();
        return TeaModel.build(map, self);
    }

    public UpdateConversationTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateConversationTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateConversationTypeResponse setBody(UpdateConversationTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateConversationTypeResponseBody getBody() {
        return this.body;
    }

}
