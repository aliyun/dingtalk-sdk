// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class CreateVersionAcrossBundleRequest extends TeaModel {
    /**
     * <p>bundleId</p>
     */
    @NameInMap("bundleId")
    public String bundleId;

    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>sourceBundleId</p>
     */
    @NameInMap("sourceBundleId")
    public String sourceBundleId;

    /**
     * <p>sourceVersion</p>
     */
    @NameInMap("sourceVersion")
    public String sourceVersion;

    /**
     * <p>version</p>
     */
    @NameInMap("version")
    public String version;

    public static CreateVersionAcrossBundleRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateVersionAcrossBundleRequest self = new CreateVersionAcrossBundleRequest();
        return TeaModel.build(map, self);
    }

    public CreateVersionAcrossBundleRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public CreateVersionAcrossBundleRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public CreateVersionAcrossBundleRequest setSourceBundleId(String sourceBundleId) {
        this.sourceBundleId = sourceBundleId;
        return this;
    }
    public String getSourceBundleId() {
        return this.sourceBundleId;
    }

    public CreateVersionAcrossBundleRequest setSourceVersion(String sourceVersion) {
        this.sourceVersion = sourceVersion;
        return this;
    }
    public String getSourceVersion() {
        return this.sourceVersion;
    }

    public CreateVersionAcrossBundleRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
