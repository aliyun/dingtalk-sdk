// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListAuditLogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAuditLogResponseBody body;

    public static ListAuditLogResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAuditLogResponse self = new ListAuditLogResponse();
        return TeaModel.build(map, self);
    }

    public ListAuditLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAuditLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAuditLogResponse setBody(ListAuditLogResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAuditLogResponseBody getBody() {
        return this.body;
    }

}
