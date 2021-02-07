// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    public static CancelCorpAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthRequest self = new CancelCorpAuthRequest();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
