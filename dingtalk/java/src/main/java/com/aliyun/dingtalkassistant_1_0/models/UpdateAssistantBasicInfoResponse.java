// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class UpdateAssistantBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAssistantBasicInfoResponseBody body;

    public static UpdateAssistantBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAssistantBasicInfoResponse self = new UpdateAssistantBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAssistantBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAssistantBasicInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAssistantBasicInfoResponse setBody(UpdateAssistantBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAssistantBasicInfoResponseBody getBody() {
        return this.body;
    }

}
