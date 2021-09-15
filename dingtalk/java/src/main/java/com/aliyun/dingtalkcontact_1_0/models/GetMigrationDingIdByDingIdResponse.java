// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetMigrationDingIdByDingIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMigrationDingIdByDingIdResponseBody body;

    public static GetMigrationDingIdByDingIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMigrationDingIdByDingIdResponse self = new GetMigrationDingIdByDingIdResponse();
        return TeaModel.build(map, self);
    }

    public GetMigrationDingIdByDingIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMigrationDingIdByDingIdResponse setBody(GetMigrationDingIdByDingIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMigrationDingIdByDingIdResponseBody getBody() {
        return this.body;
    }

}
