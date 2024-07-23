// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class ListMailFoldersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListMailFoldersResponseBody body;

    public static ListMailFoldersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMailFoldersResponse self = new ListMailFoldersResponse();
        return TeaModel.build(map, self);
    }

    public ListMailFoldersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMailFoldersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMailFoldersResponse setBody(ListMailFoldersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMailFoldersResponseBody getBody() {
        return this.body;
    }

}
