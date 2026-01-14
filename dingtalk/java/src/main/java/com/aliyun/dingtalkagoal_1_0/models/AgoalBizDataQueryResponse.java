// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalBizDataQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalBizDataQueryResponseBody body;

    public static AgoalBizDataQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalBizDataQueryResponse self = new AgoalBizDataQueryResponse();
        return TeaModel.build(map, self);
    }

    public AgoalBizDataQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalBizDataQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalBizDataQueryResponse setBody(AgoalBizDataQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalBizDataQueryResponseBody getBody() {
        return this.body;
    }

}
