// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptIdsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSubDeptIdsResponseBody body;

    public static ListSubDeptIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptIdsResponse self = new ListSubDeptIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListSubDeptIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSubDeptIdsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSubDeptIdsResponse setBody(ListSubDeptIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubDeptIdsResponseBody getBody() {
        return this.body;
    }

}
