// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class GetAssistantActionInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAssistantActionInfoResponseBody body;

    public static GetAssistantActionInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAssistantActionInfoResponse self = new GetAssistantActionInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetAssistantActionInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAssistantActionInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAssistantActionInfoResponse setBody(GetAssistantActionInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAssistantActionInfoResponseBody getBody() {
        return this.body;
    }

}
