// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoByCursorPageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchOrgInnerGroupInfoByCursorPageResponseBody body;

    public static SearchOrgInnerGroupInfoByCursorPageResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoByCursorPageResponse self = new SearchOrgInnerGroupInfoByCursorPageResponse();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoByCursorPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchOrgInnerGroupInfoByCursorPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchOrgInnerGroupInfoByCursorPageResponse setBody(SearchOrgInnerGroupInfoByCursorPageResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchOrgInnerGroupInfoByCursorPageResponseBody getBody() {
        return this.body;
    }

}
