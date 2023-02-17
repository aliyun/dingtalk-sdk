// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpStatisticDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCorpStatisticDataResponseBody body;

    public static QueryCorpStatisticDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpStatisticDataResponse self = new QueryCorpStatisticDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpStatisticDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpStatisticDataResponse setBody(QueryCorpStatisticDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpStatisticDataResponseBody getBody() {
        return this.body;
    }

}
