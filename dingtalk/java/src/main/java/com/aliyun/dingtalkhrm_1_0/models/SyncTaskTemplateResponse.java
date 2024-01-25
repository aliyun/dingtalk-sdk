// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncTaskTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncTaskTemplateResponseBody body;

    public static SyncTaskTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncTaskTemplateResponse self = new SyncTaskTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SyncTaskTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncTaskTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncTaskTemplateResponse setBody(SyncTaskTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncTaskTemplateResponseBody getBody() {
        return this.body;
    }

}
