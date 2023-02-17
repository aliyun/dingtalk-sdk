// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpUserStatisticResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCorpUserStatisticResponseBody body;

    public static QueryCorpUserStatisticResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpUserStatisticResponse self = new QueryCorpUserStatisticResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpUserStatisticResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpUserStatisticResponse setBody(QueryCorpUserStatisticResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpUserStatisticResponseBody getBody() {
        return this.body;
    }

}
