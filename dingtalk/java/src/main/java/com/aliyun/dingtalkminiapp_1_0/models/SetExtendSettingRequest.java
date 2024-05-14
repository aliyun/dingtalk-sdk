// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class SetExtendSettingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("buildH5Bundle")
    public Boolean buildH5Bundle;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    public static SetExtendSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        SetExtendSettingRequest self = new SetExtendSettingRequest();
        return TeaModel.build(map, self);
    }

    public SetExtendSettingRequest setBuildH5Bundle(Boolean buildH5Bundle) {
        this.buildH5Bundle = buildH5Bundle;
        return this;
    }
    public Boolean getBuildH5Bundle() {
        return this.buildH5Bundle;
    }

    public SetExtendSettingRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
