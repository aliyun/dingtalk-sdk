// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByOpenCidsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupInfoByOpenCidsResponseBody body;

    public static QueryGroupInfoByOpenCidsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByOpenCidsResponse self = new QueryGroupInfoByOpenCidsResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByOpenCidsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupInfoByOpenCidsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupInfoByOpenCidsResponse setBody(QueryGroupInfoByOpenCidsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupInfoByOpenCidsResponseBody getBody() {
        return this.body;
    }

}
