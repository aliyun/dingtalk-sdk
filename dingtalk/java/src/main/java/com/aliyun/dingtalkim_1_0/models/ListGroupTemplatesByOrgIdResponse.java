// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListGroupTemplatesByOrgIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListGroupTemplatesByOrgIdResponseBody body;

    public static ListGroupTemplatesByOrgIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ListGroupTemplatesByOrgIdResponse self = new ListGroupTemplatesByOrgIdResponse();
        return TeaModel.build(map, self);
    }

    public ListGroupTemplatesByOrgIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListGroupTemplatesByOrgIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListGroupTemplatesByOrgIdResponse setBody(ListGroupTemplatesByOrgIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListGroupTemplatesByOrgIdResponseBody getBody() {
        return this.body;
    }

}
