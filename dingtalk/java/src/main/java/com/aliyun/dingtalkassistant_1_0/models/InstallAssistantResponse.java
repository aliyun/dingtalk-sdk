// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class InstallAssistantResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InstallAssistantResponseBody body;

    public static InstallAssistantResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallAssistantResponse self = new InstallAssistantResponse();
        return TeaModel.build(map, self);
    }

    public InstallAssistantResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallAssistantResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InstallAssistantResponse setBody(InstallAssistantResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallAssistantResponseBody getBody() {
        return this.body;
    }

}
