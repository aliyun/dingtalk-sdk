// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RemoveApaasAppRequest extends TeaModel {
    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("bizAppId")
    public String bizAppId;

    public static RemoveApaasAppRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveApaasAppRequest self = new RemoveApaasAppRequest();
        return TeaModel.build(map, self);
    }

    public RemoveApaasAppRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RemoveApaasAppRequest setBizAppId(String bizAppId) {
        this.bizAppId = bizAppId;
        return this;
    }
    public String getBizAppId() {
        return this.bizAppId;
    }

}
