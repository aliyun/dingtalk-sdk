// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMaxVersionRequest extends TeaModel {
    // bundleId
    @NameInMap("bundleId")
    public String bundleId;

    // miniAppId
    @NameInMap("miniAppId")
    public String miniAppId;

    // version
    @NameInMap("version")
    public String version;

    public static GetMaxVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMaxVersionRequest self = new GetMaxVersionRequest();
        return TeaModel.build(map, self);
    }

    public GetMaxVersionRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public GetMaxVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public GetMaxVersionRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
