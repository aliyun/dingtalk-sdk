// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateMiniAppVersionStatusRequest extends TeaModel {
    /**
     * <p>小程序id</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>版本</p>
     */
    @NameInMap("version")
    public String version;

    /**
     * <p>版本类型</p>
     */
    @NameInMap("versionType")
    public Integer versionType;

    public static UpdateMiniAppVersionStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateMiniAppVersionStatusRequest self = new UpdateMiniAppVersionStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateMiniAppVersionStatusRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public UpdateMiniAppVersionStatusRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public UpdateMiniAppVersionStatusRequest setVersionType(Integer versionType) {
        this.versionType = versionType;
        return this;
    }
    public Integer getVersionType() {
        return this.versionType;
    }

}
