// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayDeployRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("version")
    public String version;

    public static ReleaseGrayDeployRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayDeployRequest self = new ReleaseGrayDeployRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayDeployRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayDeployRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
