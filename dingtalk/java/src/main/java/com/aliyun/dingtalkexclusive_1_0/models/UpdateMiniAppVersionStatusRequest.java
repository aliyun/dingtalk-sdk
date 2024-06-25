// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateMiniAppVersionStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>500000003</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <strong>example:</strong>
     * <p>0.0.5</p>
     */
    @NameInMap("version")
    public String version;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0-开发版，1-灰度版，2-发布版，3-体验版</p>
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
