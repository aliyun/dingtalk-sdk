// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CorpConsoleRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    public static CorpConsoleRequest build(java.util.Map<String, ?> map) throws Exception {
        CorpConsoleRequest self = new CorpConsoleRequest();
        return TeaModel.build(map, self);
    }

    public CorpConsoleRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

}
