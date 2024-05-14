// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUserRealnameUrlRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetUserRealnameUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserRealnameUrlRequest self = new GetUserRealnameUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetUserRealnameUrlRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public GetUserRealnameUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
