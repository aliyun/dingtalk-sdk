// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class UpdateVersionStatusRequest extends TeaModel {
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

    @NameInMap("version")
    public String version;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("versionType")
    public Integer versionType;

    public static UpdateVersionStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateVersionStatusRequest self = new UpdateVersionStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateVersionStatusRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public UpdateVersionStatusRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public UpdateVersionStatusRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public UpdateVersionStatusRequest setVersionType(Integer versionType) {
        this.versionType = versionType;
        return this;
    }
    public Integer getVersionType() {
        return this.versionType;
    }

}
