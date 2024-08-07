// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAssistantMessageResponseBody body;

    public static ListAssistantMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantMessageResponse self = new ListAssistantMessageResponse();
        return TeaModel.build(map, self);
    }

    public ListAssistantMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAssistantMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAssistantMessageResponse setBody(ListAssistantMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAssistantMessageResponseBody getBody() {
        return this.body;
    }

}
