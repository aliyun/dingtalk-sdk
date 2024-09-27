// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIQueryDatasetPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAIQueryDatasetPermissionResponseBody body;

    public static ChatAIQueryDatasetPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAIQueryDatasetPermissionResponse self = new ChatAIQueryDatasetPermissionResponse();
        return TeaModel.build(map, self);
    }

    public ChatAIQueryDatasetPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAIQueryDatasetPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAIQueryDatasetPermissionResponse setBody(ChatAIQueryDatasetPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAIQueryDatasetPermissionResponseBody getBody() {
        return this.body;
    }

}
