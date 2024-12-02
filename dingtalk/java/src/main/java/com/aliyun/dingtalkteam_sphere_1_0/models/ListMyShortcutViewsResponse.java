// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class ListMyShortcutViewsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListMyShortcutViewsResponseBody body;

    public static ListMyShortcutViewsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListMyShortcutViewsResponse self = new ListMyShortcutViewsResponse();
        return TeaModel.build(map, self);
    }

    public ListMyShortcutViewsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListMyShortcutViewsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListMyShortcutViewsResponse setBody(ListMyShortcutViewsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListMyShortcutViewsResponseBody getBody() {
        return this.body;
    }

}
