// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListFormRemarksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListFormRemarksResponseBody body;

    public static ListFormRemarksResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFormRemarksResponse self = new ListFormRemarksResponse();
        return TeaModel.build(map, self);
    }

    public ListFormRemarksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFormRemarksResponse setBody(ListFormRemarksResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFormRemarksResponseBody getBody() {
        return this.body;
    }

}
