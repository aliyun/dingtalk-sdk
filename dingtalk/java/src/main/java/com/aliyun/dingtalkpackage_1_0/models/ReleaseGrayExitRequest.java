// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayExitRequest extends TeaModel {
    // 离线包ID
    @NameInMap("miniAppId")
    public String miniAppId;

    // 退出灰度的版本号
    @NameInMap("version")
    public String version;

    public static ReleaseGrayExitRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayExitRequest self = new ReleaseGrayExitRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayExitRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayExitRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
