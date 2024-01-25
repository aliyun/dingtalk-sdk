// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ModifyWaterMarkTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ModifyWaterMarkTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ModifyWaterMarkTemplateResponse setBody(ModifyWaterMarkTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public ModifyWaterMarkTemplateResponseBody getBody() {
        return this.body;
    }

}
