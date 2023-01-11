// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayOrgSetRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>灰度企业corpId列表</p>
     */
    @NameInMap("value")
    public java.util.List<String> value;

    /**
     * <p>离线包版本号</p>
     */
    @NameInMap("version")
    public String version;

    public static ReleaseGrayOrgSetRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayOrgSetRequest self = new ReleaseGrayOrgSetRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayOrgSetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayOrgSetRequest setValue(java.util.List<String> value) {
        this.value = value;
        return this;
    }
    public java.util.List<String> getValue() {
        return this.value;
    }

    public ReleaseGrayOrgSetRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
