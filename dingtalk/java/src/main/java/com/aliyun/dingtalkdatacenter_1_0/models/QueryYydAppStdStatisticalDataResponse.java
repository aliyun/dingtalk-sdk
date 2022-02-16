// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppStdStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydAppStdStatisticalDataResponseBody body;

    public static QueryYydAppStdStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppStdStatisticalDataResponse self = new QueryYydAppStdStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydAppStdStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydAppStdStatisticalDataResponse setBody(QueryYydAppStdStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydAppStdStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
