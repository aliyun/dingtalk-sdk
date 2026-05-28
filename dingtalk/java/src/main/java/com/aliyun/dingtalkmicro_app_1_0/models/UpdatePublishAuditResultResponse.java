// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdatePublishAuditResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdatePublishAuditResultResponseBody body;

    public static UpdatePublishAuditResultResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePublishAuditResultResponse self = new UpdatePublishAuditResultResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePublishAuditResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePublishAuditResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePublishAuditResultResponse setBody(UpdatePublishAuditResultResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePublishAuditResultResponseBody getBody() {
        return this.body;
    }

}
