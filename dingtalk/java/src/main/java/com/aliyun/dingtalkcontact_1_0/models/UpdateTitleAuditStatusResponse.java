// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateTitleAuditStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateTitleAuditStatusResponseBody body;

    public static UpdateTitleAuditStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTitleAuditStatusResponse self = new UpdateTitleAuditStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTitleAuditStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTitleAuditStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTitleAuditStatusResponse setBody(UpdateTitleAuditStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTitleAuditStatusResponseBody getBody() {
        return this.body;
    }

}
