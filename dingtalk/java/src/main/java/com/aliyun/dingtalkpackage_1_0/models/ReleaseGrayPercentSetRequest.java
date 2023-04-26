// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentSetRequest extends TeaModel {
    @NameInMap("miniAppId")
    public String miniAppId;

    @NameInMap("value")
    public Double value;

    @NameInMap("version")
    public String version;

    public static ReleaseGrayPercentSetRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentSetRequest self = new ReleaseGrayPercentSetRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentSetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayPercentSetRequest setValue(Double value) {
        this.value = value;
        return this;
    }
    public Double getValue() {
        return this.value;
    }

    public ReleaseGrayPercentSetRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
