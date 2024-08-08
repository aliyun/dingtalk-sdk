// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAssistantResponseBody body;

    public static ListAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantResponse self = new ListAssistantResponse();
        return TeaModel.build(map, self);
    }

    public ListAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAssistantResponse setBody(ListAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAssistantResponseBody getBody() {
        return this.body;
    }

}
