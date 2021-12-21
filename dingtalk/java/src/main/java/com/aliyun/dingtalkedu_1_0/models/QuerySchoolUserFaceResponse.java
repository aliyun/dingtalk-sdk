// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySchoolUserFaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QuerySchoolUserFaceResponseBody body;

    public static QuerySchoolUserFaceResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySchoolUserFaceResponse self = new QuerySchoolUserFaceResponse();
        return TeaModel.build(map, self);
    }

    public QuerySchoolUserFaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySchoolUserFaceResponse setBody(QuerySchoolUserFaceResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySchoolUserFaceResponseBody getBody() {
        return this.body;
    }

}
