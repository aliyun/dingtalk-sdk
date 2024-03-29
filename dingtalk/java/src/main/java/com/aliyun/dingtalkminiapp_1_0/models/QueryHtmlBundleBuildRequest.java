// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class QueryHtmlBundleBuildRequest extends TeaModel {
    @NameInMap("bundleId")
    public String bundleId;

    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("version")
    public String version;

    public static QueryHtmlBundleBuildRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHtmlBundleBuildRequest self = new QueryHtmlBundleBuildRequest();
        return TeaModel.build(map, self);
    }

    public QueryHtmlBundleBuildRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public QueryHtmlBundleBuildRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public QueryHtmlBundleBuildRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
