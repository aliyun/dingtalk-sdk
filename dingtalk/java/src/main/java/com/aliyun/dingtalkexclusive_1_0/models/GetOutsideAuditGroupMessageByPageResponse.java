// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutsideAuditGroupMessageByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetOutsideAuditGroupMessageByPageResponseBody body;

    public static GetOutsideAuditGroupMessageByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOutsideAuditGroupMessageByPageResponse self = new GetOutsideAuditGroupMessageByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetOutsideAuditGroupMessageByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOutsideAuditGroupMessageByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOutsideAuditGroupMessageByPageResponse setBody(GetOutsideAuditGroupMessageByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOutsideAuditGroupMessageByPageResponseBody getBody() {
        return this.body;
    }

}
