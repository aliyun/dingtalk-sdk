// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgHonorsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOrgHonorsResponseBody body;

    public static QueryOrgHonorsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgHonorsResponse self = new QueryOrgHonorsResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrgHonorsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrgHonorsResponse setBody(QueryOrgHonorsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrgHonorsResponseBody getBody() {
        return this.body;
    }

}
