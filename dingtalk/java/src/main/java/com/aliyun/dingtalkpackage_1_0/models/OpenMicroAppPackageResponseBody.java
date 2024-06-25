// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class OpenMicroAppPackageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5000000000000000</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    public static OpenMicroAppPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenMicroAppPackageResponseBody self = new OpenMicroAppPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenMicroAppPackageResponseBody setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
