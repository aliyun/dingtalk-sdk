// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUnionIdByMigrationUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUnionIdByMigrationUnionIdResponseBody body;

    public static GetUnionIdByMigrationUnionIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUnionIdByMigrationUnionIdResponse self = new GetUnionIdByMigrationUnionIdResponse();
        return TeaModel.build(map, self);
    }

    public GetUnionIdByMigrationUnionIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUnionIdByMigrationUnionIdResponse setBody(GetUnionIdByMigrationUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUnionIdByMigrationUnionIdResponseBody getBody() {
        return this.body;
    }

}
