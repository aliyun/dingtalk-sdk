// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SearchGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchGroupResponseBody body;

    public static SearchGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchGroupResponse self = new SearchGroupResponse();
        return TeaModel.build(map, self);
    }

    public SearchGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchGroupResponse setBody(SearchGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchGroupResponseBody getBody() {
        return this.body;
    }

}
