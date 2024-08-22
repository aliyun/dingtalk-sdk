// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListVisibleAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListVisibleAssistantResponseBody body;

    public static ListVisibleAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        ListVisibleAssistantResponse self = new ListVisibleAssistantResponse();
        return TeaModel.build(map, self);
    }

    public ListVisibleAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListVisibleAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListVisibleAssistantResponse setBody(ListVisibleAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public ListVisibleAssistantResponseBody getBody() {
        return this.body;
    }

}
