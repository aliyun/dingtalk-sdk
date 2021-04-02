// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCityCarApplyResponseBody body;

    public static QueryCityCarApplyResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCityCarApplyResponse self = new QueryCityCarApplyResponse();
        return TeaModel.build(map, self);
    }

    public QueryCityCarApplyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCityCarApplyResponse setBody(QueryCityCarApplyResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCityCarApplyResponseBody getBody() {
        return this.body;
    }

}
