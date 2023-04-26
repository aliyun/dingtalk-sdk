// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateShortcutsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateShortcutsResponseBody body;

    public static UpdateShortcutsResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateShortcutsResponse self = new UpdateShortcutsResponse();
        return TeaModel.build(map, self);
    }

    public UpdateShortcutsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateShortcutsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateShortcutsResponse setBody(UpdateShortcutsResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateShortcutsResponseBody getBody() {
        return this.body;
    }

}
