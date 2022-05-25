// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QuerySpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SpaceOpenVOResult body;

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

    public QuerySpaceResponse setBody(SpaceOpenVOResult body) {
        this.body = body;
        return this;
    }
    public SpaceOpenVOResult getBody() {
        return this.body;
    }

}
