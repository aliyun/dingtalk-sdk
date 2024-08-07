// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListAssistantRunResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAssistantRunResponseBody body;

    public static ListAssistantRunResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAssistantRunResponse self = new ListAssistantRunResponse();
        return TeaModel.build(map, self);
    }

    public ListAssistantRunResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAssistantRunResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAssistantRunResponse setBody(ListAssistantRunResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAssistantRunResponseBody getBody() {
        return this.body;
    }

}
