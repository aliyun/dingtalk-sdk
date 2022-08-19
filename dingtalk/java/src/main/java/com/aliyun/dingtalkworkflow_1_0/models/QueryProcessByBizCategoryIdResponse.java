// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessByBizCategoryIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryProcessByBizCategoryIdResponseBody body;

    public static QueryProcessByBizCategoryIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessByBizCategoryIdResponse self = new QueryProcessByBizCategoryIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryProcessByBizCategoryIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryProcessByBizCategoryIdResponse setBody(QueryProcessByBizCategoryIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryProcessByBizCategoryIdResponseBody getBody() {
        return this.body;
    }

}
