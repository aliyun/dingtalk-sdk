// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutForMigrateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateShortcutForMigrateResponseBody body;

    public static CreateShortcutForMigrateResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutForMigrateResponse self = new CreateShortcutForMigrateResponse();
        return TeaModel.build(map, self);
    }

    public CreateShortcutForMigrateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateShortcutForMigrateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateShortcutForMigrateResponse setBody(CreateShortcutForMigrateResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateShortcutForMigrateResponseBody getBody() {
        return this.body;
    }

}
