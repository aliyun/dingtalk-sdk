// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoWeekStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryYydTodoWeekStatisticalDataResponseBody body;

    public static QueryYydTodoWeekStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoWeekStatisticalDataResponse self = new QueryYydTodoWeekStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoWeekStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryYydTodoWeekStatisticalDataResponse setBody(QueryYydTodoWeekStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryYydTodoWeekStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
