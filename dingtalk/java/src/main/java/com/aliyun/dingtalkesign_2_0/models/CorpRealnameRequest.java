// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CorpRealnameRequest extends TeaModel {
    @NameInMap("redirectUrl")
    public String redirectUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CorpRealnameRequest build(java.util.Map<String, ?> map) throws Exception {
        CorpRealnameRequest self = new CorpRealnameRequest();
        return TeaModel.build(map, self);
    }

    public CorpRealnameRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public CorpRealnameRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
