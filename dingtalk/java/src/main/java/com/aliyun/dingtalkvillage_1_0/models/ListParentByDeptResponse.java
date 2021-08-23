// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByDeptResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListParentByDeptResponseBody body;

    public static ListParentByDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        ListParentByDeptResponse self = new ListParentByDeptResponse();
        return TeaModel.build(map, self);
    }

    public ListParentByDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListParentByDeptResponse setBody(ListParentByDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public ListParentByDeptResponseBody getBody() {
        return this.body;
    }

}
