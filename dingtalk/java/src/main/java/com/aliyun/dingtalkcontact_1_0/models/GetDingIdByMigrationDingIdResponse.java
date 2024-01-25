// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetDingIdByMigrationDingIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDingIdByMigrationDingIdResponseBody body;

    public static GetDingIdByMigrationDingIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDingIdByMigrationDingIdResponse self = new GetDingIdByMigrationDingIdResponse();
        return TeaModel.build(map, self);
    }

    public GetDingIdByMigrationDingIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDingIdByMigrationDingIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDingIdByMigrationDingIdResponse setBody(GetDingIdByMigrationDingIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDingIdByMigrationDingIdResponseBody getBody() {
        return this.body;
    }

}
