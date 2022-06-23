// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ModifyWaterMarkTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ModifyWaterMarkTemplateResponseBody body;

    public static ModifyWaterMarkTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        ModifyWaterMarkTemplateResponse self = new ModifyWaterMarkTemplateResponse();
        return TeaModel.build(map, self);
    }

    public ModifyWaterMarkTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ModifyWaterMarkTemplateResponse setBody(ModifyWaterMarkTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public ModifyWaterMarkTemplateResponseBody getBody() {
        return this.body;
    }

}
