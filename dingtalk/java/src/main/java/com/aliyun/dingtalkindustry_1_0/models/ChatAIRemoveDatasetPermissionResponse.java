// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIRemoveDatasetPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAIRemoveDatasetPermissionResponseBody body;

    public static ChatAIRemoveDatasetPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAIRemoveDatasetPermissionResponse self = new ChatAIRemoveDatasetPermissionResponse();
        return TeaModel.build(map, self);
    }

    public ChatAIRemoveDatasetPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAIRemoveDatasetPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAIRemoveDatasetPermissionResponse setBody(ChatAIRemoveDatasetPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAIRemoveDatasetPermissionResponseBody getBody() {
        return this.body;
    }

}
