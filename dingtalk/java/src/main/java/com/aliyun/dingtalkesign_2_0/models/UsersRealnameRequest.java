// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class UsersRealnameRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UsersRealnameRequest build(java.util.Map<String, ?> map) throws Exception {
        UsersRealnameRequest self = new UsersRealnameRequest();
        return TeaModel.build(map, self);
    }

    public UsersRealnameRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public UsersRealnameRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
