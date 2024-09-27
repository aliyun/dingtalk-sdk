// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIAddDatasetPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChatAIAddDatasetPermissionResponseBody body;

    public static ChatAIAddDatasetPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        ChatAIAddDatasetPermissionResponse self = new ChatAIAddDatasetPermissionResponse();
        return TeaModel.build(map, self);
    }

    public ChatAIAddDatasetPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChatAIAddDatasetPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChatAIAddDatasetPermissionResponse setBody(ChatAIAddDatasetPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public ChatAIAddDatasetPermissionResponseBody getBody() {
        return this.body;
    }

}
