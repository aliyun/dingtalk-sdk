// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RollbackMiniAppVersionRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("rollbackVersion")
    public String rollbackVersion;

    @NameInMap("targetVersion")
    public String targetVersion;

    public static RollbackMiniAppVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        RollbackMiniAppVersionRequest self = new RollbackMiniAppVersionRequest();
        return TeaModel.build(map, self);
    }

    public RollbackMiniAppVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public RollbackMiniAppVersionRequest setRollbackVersion(String rollbackVersion) {
        this.rollbackVersion = rollbackVersion;
        return this;
    }
    public String getRollbackVersion() {
        return this.rollbackVersion;
    }

    public RollbackMiniAppVersionRequest setTargetVersion(String targetVersion) {
        this.targetVersion = targetVersion;
        return this;
    }
    public String getTargetVersion() {
        return this.targetVersion;
    }

}
