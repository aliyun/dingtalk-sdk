// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListSubDeptIdsResponse setBody(ListSubDeptIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSubDeptIdsResponseBody getBody() {
        return this.body;
    }

}
