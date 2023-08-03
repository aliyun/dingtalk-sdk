// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CrossOrgMigrateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CrossOrgMigrateResponseBody body;

    public static CrossOrgMigrateResponse build(java.util.Map<String, ?> map) throws Exception {
        CrossOrgMigrateResponse self = new CrossOrgMigrateResponse();
        return TeaModel.build(map, self);
    }

    public CrossOrgMigrateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CrossOrgMigrateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CrossOrgMigrateResponse setBody(CrossOrgMigrateResponseBody body) {
        this.body = body;
        return this;
    }
    public CrossOrgMigrateResponseBody getBody() {
        return this.body;
    }

}
