// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SearchGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SearchGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchGroupResponse setBody(SearchGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchGroupResponseBody getBody() {
        return this.body;
    }

}
