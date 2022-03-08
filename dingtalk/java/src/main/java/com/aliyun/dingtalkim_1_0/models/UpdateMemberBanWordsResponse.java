// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateMemberBanWordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateMemberBanWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMemberBanWordsResponse self = new UpdateMemberBanWordsResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMemberBanWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
