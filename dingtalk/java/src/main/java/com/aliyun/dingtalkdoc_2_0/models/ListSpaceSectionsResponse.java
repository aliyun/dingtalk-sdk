// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListSpaceSectionsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSpaceSectionsResponseBody body;

    public static ListSpaceSectionsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSpaceSectionsResponse self = new ListSpaceSectionsResponse();
        return TeaModel.build(map, self);
    }

    public ListSpaceSectionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSpaceSectionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSpaceSectionsResponse setBody(ListSpaceSectionsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSpaceSectionsResponseBody getBody() {
        return this.body;
    }

}
