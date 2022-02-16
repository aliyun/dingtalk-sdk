// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalStdStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTotalStdStatisticalDataResponseBody body;

    public static QueryYydTotalStdStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalStdStatisticalDataResponse self = new QueryYydTotalStdStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalStdStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTotalStdStatisticalDataResponse setBody(QueryYydTotalStdStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTotalStdStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
