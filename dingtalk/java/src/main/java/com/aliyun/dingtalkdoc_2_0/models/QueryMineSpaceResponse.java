// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryMineSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SpaceVO body;

    public static QueryMineSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMineSpaceResponse self = new QueryMineSpaceResponse();
        return TeaModel.build(map, self);
    }

    public QueryMineSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMineSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMineSpaceResponse setBody(SpaceVO body) {
        this.body = body;
        return this;
    }
    public SpaceVO getBody() {
        return this.body;
    }

}
