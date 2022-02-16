// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryIndustryTagListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryIndustryTagListResponseBody body;

    public static QueryIndustryTagListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryIndustryTagListResponse self = new QueryIndustryTagListResponse();
        return TeaModel.build(map, self);
    }

    public QueryIndustryTagListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryIndustryTagListResponse setBody(QueryIndustryTagListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryIndustryTagListResponseBody getBody() {
        return this.body;
    }

}
