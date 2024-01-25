// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatMultiResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCrmGroupChatMultiResponseBody body;

    public static GetCrmGroupChatMultiResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatMultiResponse self = new GetCrmGroupChatMultiResponse();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatMultiResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCrmGroupChatMultiResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCrmGroupChatMultiResponse setBody(GetCrmGroupChatMultiResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCrmGroupChatMultiResponseBody getBody() {
        return this.body;
    }

}
