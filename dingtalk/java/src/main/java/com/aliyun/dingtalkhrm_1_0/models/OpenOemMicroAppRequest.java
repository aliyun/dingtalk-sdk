// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class OpenOemMicroAppRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>12</p>
     */
    @NameInMap("tenantId")
    public Long tenantId;

    public static OpenOemMicroAppRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenOemMicroAppRequest self = new OpenOemMicroAppRequest();
        return TeaModel.build(map, self);
    }

    public OpenOemMicroAppRequest setTenantId(Long tenantId) {
        this.tenantId = tenantId;
        return this;
    }
    public Long getTenantId() {
        return this.tenantId;
    }

}
