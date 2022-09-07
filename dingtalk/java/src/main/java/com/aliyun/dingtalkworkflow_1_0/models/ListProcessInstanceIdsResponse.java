// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListProcessInstanceIdsResponseBody body;

    public static ListProcessInstanceIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListProcessInstanceIdsResponse self = new ListProcessInstanceIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListProcessInstanceIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListProcessInstanceIdsResponse setBody(ListProcessInstanceIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListProcessInstanceIdsResponseBody getBody() {
        return this.body;
    }

}
