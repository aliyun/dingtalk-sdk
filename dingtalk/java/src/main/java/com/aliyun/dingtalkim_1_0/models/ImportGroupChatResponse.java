// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ImportGroupChatResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ImportGroupChatResponseBody body;

    public static ImportGroupChatResponse build(java.util.Map<String, ?> map) throws Exception {
        ImportGroupChatResponse self = new ImportGroupChatResponse();
        return TeaModel.build(map, self);
    }

    public ImportGroupChatResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ImportGroupChatResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ImportGroupChatResponse setBody(ImportGroupChatResponseBody body) {
        this.body = body;
        return this;
    }
    public ImportGroupChatResponseBody getBody() {
        return this.body;
    }

}
