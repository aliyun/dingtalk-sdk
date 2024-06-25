// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RollbackMiniAppVersionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5000000003</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <strong>example:</strong>
     * <p>0.0.5</p>
     */
    @NameInMap("rollbackVersion")
    public String rollbackVersion;

    /**
     * <strong>example:</strong>
     * <p>0.0.4</p>
     */
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
