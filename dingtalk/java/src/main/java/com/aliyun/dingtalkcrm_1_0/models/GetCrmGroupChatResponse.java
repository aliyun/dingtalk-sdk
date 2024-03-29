// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCrmGroupChatResponseBody body;

    public static GetCrmGroupChatResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatResponse self = new GetCrmGroupChatResponse();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCrmGroupChatResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCrmGroupChatResponse setBody(GetCrmGroupChatResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCrmGroupChatResponseBody getBody() {
        return this.body;
    }

}
