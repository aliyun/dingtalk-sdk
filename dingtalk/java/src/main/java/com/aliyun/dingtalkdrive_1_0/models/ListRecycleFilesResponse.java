// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListRecycleFilesResponseBody body;

    public static ListRecycleFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleFilesResponse self = new ListRecycleFilesResponse();
        return TeaModel.build(map, self);
    }

    public ListRecycleFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRecycleFilesResponse setBody(ListRecycleFilesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRecycleFilesResponseBody getBody() {
        return this.body;
    }

}
