// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUserIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListDeptUserIdsResponseBody body;

    public static ListDeptUserIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUserIdsResponse self = new ListDeptUserIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListDeptUserIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDeptUserIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListDeptUserIdsResponse setBody(ListDeptUserIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDeptUserIdsResponseBody getBody() {
        return this.body;
    }

}
