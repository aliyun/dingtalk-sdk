// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationUnionIdByUnionIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetMigrationUnionIdByUnionIdResponse setBody(GetMigrationUnionIdByUnionIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMigrationUnionIdByUnionIdResponseBody getBody() {
        return this.body;
    }

}
