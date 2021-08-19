// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingSendStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDingSendStatisticalDataResponseBody body;

    public static QueryDingSendStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDingSendStatisticalDataResponse self = new QueryDingSendStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDingSendStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDingSendStatisticalDataResponse setBody(QueryDingSendStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDingSendStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
