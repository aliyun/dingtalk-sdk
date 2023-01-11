// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentGetRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>离线包版本号</p>
     */
    @NameInMap("version")
    public String version;

    public static ReleaseGrayPercentGetRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentGetRequest self = new ReleaseGrayPercentGetRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentGetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayPercentGetRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
