// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupLiveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupLiveStatisticalDataResponseBody body;

    public static QueryGroupLiveStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupLiveStatisticalDataResponse self = new QueryGroupLiveStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupLiveStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupLiveStatisticalDataResponse setBody(QueryGroupLiveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupLiveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
