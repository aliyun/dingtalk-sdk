// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListSpaceSectionsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListSpaceSectionsResponse setBody(ListSpaceSectionsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSpaceSectionsResponseBody getBody() {
        return this.body;
    }

}
