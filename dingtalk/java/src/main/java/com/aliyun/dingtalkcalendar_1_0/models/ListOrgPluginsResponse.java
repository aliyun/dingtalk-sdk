// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListOrgPluginsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListOrgPluginsResponseBody body;

    public static ListOrgPluginsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOrgPluginsResponse self = new ListOrgPluginsResponse();
        return TeaModel.build(map, self);
    }

    public ListOrgPluginsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOrgPluginsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListOrgPluginsResponse setBody(ListOrgPluginsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOrgPluginsResponseBody getBody() {
        return this.body;
    }

}
