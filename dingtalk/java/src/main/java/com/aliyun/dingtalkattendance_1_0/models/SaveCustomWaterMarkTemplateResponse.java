// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SaveCustomWaterMarkTemplateResponseBody body;

    public static SaveCustomWaterMarkTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveCustomWaterMarkTemplateResponse self = new SaveCustomWaterMarkTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SaveCustomWaterMarkTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveCustomWaterMarkTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveCustomWaterMarkTemplateResponse setBody(SaveCustomWaterMarkTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveCustomWaterMarkTemplateResponseBody getBody() {
        return this.body;
    }

}
