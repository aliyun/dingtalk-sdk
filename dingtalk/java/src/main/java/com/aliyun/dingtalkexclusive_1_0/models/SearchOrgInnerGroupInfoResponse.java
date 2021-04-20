// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SearchOrgInnerGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchOrgInnerGroupInfoResponseBody body;

    public static SearchOrgInnerGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchOrgInnerGroupInfoResponse self = new SearchOrgInnerGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public SearchOrgInnerGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchOrgInnerGroupInfoResponse setBody(SearchOrgInnerGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchOrgInnerGroupInfoResponseBody getBody() {
        return this.body;
    }

}
