// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListTodoWorkRecordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListTodoWorkRecordsResponseBody body;

    public static ListTodoWorkRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListTodoWorkRecordsResponse self = new ListTodoWorkRecordsResponse();
        return TeaModel.build(map, self);
    }

    public ListTodoWorkRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListTodoWorkRecordsResponse setBody(ListTodoWorkRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListTodoWorkRecordsResponseBody getBody() {
        return this.body;
    }

}
