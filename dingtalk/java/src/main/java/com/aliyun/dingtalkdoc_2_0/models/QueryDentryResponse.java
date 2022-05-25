// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DentryOpenVOResult body;

    public static QueryDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDentryResponse self = new QueryDentryResponse();
        return TeaModel.build(map, self);
    }

    public QueryDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDentryResponse setBody(DentryOpenVOResult body) {
        this.body = body;
        return this;
    }
    public DentryOpenVOResult getBody() {
        return this.body;
    }

}
