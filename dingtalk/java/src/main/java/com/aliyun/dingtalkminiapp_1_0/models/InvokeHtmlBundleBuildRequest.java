// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class InvokeHtmlBundleBuildRequest extends TeaModel {
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
    @NameInMap("version")
    public String version;

    public static InvokeHtmlBundleBuildRequest build(java.util.Map<String, ?> map) throws Exception {
        InvokeHtmlBundleBuildRequest self = new InvokeHtmlBundleBuildRequest();
        return TeaModel.build(map, self);
    }

    public InvokeHtmlBundleBuildRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public InvokeHtmlBundleBuildRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public InvokeHtmlBundleBuildRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
