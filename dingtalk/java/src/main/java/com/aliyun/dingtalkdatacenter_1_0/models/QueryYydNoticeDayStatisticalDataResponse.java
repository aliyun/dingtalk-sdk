// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydNoticeDayStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydNoticeDayStatisticalDataResponseBody body;

    public static QueryYydNoticeDayStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydNoticeDayStatisticalDataResponse self = new QueryYydNoticeDayStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydNoticeDayStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydNoticeDayStatisticalDataResponse setBody(QueryYydNoticeDayStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydNoticeDayStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
