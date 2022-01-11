// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetAuthUrlRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    public static GetAuthUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAuthUrlRequest self = new GetAuthUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetAuthUrlRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

}
