// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RetrieveAssistantBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RetrieveAssistantBasicInfoResponseBody body;

    public static RetrieveAssistantBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        RetrieveAssistantBasicInfoResponse self = new RetrieveAssistantBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public RetrieveAssistantBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RetrieveAssistantBasicInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RetrieveAssistantBasicInfoResponse setBody(RetrieveAssistantBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public RetrieveAssistantBasicInfoResponseBody getBody() {
        return this.body;
    }

}
