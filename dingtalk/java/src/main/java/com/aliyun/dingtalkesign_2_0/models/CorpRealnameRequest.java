// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CorpRealnameRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("userId")
    public String userId;

    @NameInMap("redirectUrl")
    public String redirectUrl;

    public static CorpRealnameRequest build(java.util.Map<String, ?> map) throws Exception {
        CorpRealnameRequest self = new CorpRealnameRequest();
        return TeaModel.build(map, self);
    }

    public CorpRealnameRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CorpRealnameRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CorpRealnameRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

}
