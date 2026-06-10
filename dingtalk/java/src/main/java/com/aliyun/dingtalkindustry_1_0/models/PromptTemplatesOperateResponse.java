// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PromptTemplatesOperateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PromptTemplatesOperateResponseBody body;

    public static PromptTemplatesOperateResponse build(java.util.Map<String, ?> map) throws Exception {
        PromptTemplatesOperateResponse self = new PromptTemplatesOperateResponse();
        return TeaModel.build(map, self);
    }

    public PromptTemplatesOperateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PromptTemplatesOperateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PromptTemplatesOperateResponse setBody(PromptTemplatesOperateResponseBody body) {
        this.body = body;
        return this;
    }
    public PromptTemplatesOperateResponseBody getBody() {
        return this.body;
    }

}
