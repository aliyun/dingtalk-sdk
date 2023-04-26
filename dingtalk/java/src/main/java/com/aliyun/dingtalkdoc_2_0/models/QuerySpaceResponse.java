// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QuerySpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SpaceVO body;

    public static QuerySpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySpaceResponse self = new QuerySpaceResponse();
        return TeaModel.build(map, self);
    }

    public QuerySpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySpaceResponse setBody(SpaceVO body) {
        this.body = body;
        return this;
    }
    public SpaceVO getBody() {
        return this.body;
    }

}
