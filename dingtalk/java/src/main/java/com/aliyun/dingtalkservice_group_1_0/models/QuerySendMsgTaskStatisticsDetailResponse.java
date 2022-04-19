// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QuerySendMsgTaskStatisticsDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySendMsgTaskStatisticsDetailResponseBody body;

    public static QuerySendMsgTaskStatisticsDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySendMsgTaskStatisticsDetailResponse self = new QuerySendMsgTaskStatisticsDetailResponse();
        return TeaModel.build(map, self);
    }

    public QuerySendMsgTaskStatisticsDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySendMsgTaskStatisticsDetailResponse setBody(QuerySendMsgTaskStatisticsDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySendMsgTaskStatisticsDetailResponseBody getBody() {
        return this.body;
    }

}
