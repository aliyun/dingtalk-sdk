// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduAssetSpacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryEduAssetSpacesResponseBody body;

    public static QueryEduAssetSpacesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryEduAssetSpacesResponse self = new QueryEduAssetSpacesResponse();
        return TeaModel.build(map, self);
    }

    public QueryEduAssetSpacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryEduAssetSpacesResponse setBody(QueryEduAssetSpacesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryEduAssetSpacesResponseBody getBody() {
        return this.body;
    }

}
