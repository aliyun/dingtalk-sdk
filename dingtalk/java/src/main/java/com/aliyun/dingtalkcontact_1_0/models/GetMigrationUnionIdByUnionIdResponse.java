// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationUnionIdByUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMigrationUnionIdByUnionIdResponseBody body;

    public static GetMigrationUnionIdByUnionIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationUnionIdByUnionIdResponse self = new GetMigrationUnionIdByUnionIdResponse();
        return TeaModel.build(map, self);
    }

    public GetMigrationUnionIdByUnionIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMigrationUnionIdByUnionIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMigrationUnionIdByUnionIdResponse setBody(GetMigrationUnionIdByUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMigrationUnionIdByUnionIdResponseBody getBody() {
        return this.body;
    }

}
