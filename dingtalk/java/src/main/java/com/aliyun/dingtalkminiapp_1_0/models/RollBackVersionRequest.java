// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class RollBackVersionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bundleId")
    public String bundleId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("rollbackVersion")
    public String rollbackVersion;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetVersion")
    public String targetVersion;

    public static RollBackVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        RollBackVersionRequest self = new RollBackVersionRequest();
        return TeaModel.build(map, self);
    }

    public RollBackVersionRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public RollBackVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public RollBackVersionRequest setRollbackVersion(String rollbackVersion) {
        this.rollbackVersion = rollbackVersion;
        return this;
    }
    public String getRollbackVersion() {
        return this.rollbackVersion;
    }

    public RollBackVersionRequest setTargetVersion(String targetVersion) {
        this.targetVersion = targetVersion;
        return this;
    }
    public String getTargetVersion() {
        return this.targetVersion;
    }

}
