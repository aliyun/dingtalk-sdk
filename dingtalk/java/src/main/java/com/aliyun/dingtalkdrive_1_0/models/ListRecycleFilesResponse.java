// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleFilesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ListRecycleFilesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListRecycleFilesResponse setBody(ListRecycleFilesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRecycleFilesResponseBody getBody() {
        return this.body;
    }

}
