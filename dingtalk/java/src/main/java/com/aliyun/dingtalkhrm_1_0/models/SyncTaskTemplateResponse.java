// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncTaskTemplateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SyncTaskTemplateResponse setBody(SyncTaskTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncTaskTemplateResponseBody getBody() {
        return this.body;
    }

}
