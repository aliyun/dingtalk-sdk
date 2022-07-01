// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryMineSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SpaceOpenVOResult body;

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

    public QueryMineSpaceResponse setBody(SpaceOpenVOResult body) {
        this.body = body;
        return this;
    }
    public SpaceOpenVOResult getBody() {
        return this.body;
    }

}
