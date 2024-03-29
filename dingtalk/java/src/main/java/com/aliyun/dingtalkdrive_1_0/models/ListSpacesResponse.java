// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ListSpacesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSpacesResponseBody body;

    public static ListSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSpacesResponse self = new ListSpacesResponse();
        return TeaModel.build(map, self);
    }

    public ListSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSpacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSpacesResponse setBody(ListSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSpacesResponseBody getBody() {
        return this.body;
    }

}
