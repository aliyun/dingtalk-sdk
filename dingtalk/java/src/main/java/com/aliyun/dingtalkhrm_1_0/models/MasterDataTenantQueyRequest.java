// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class MasterDataTenantQueyRequest extends TeaModel {
    @NameInMap("entityCode")
    public String entityCode;

    @NameInMap("scopeCode")
    public String scopeCode;

    public static MasterDataTenantQueyRequest build(java.util.Map<String, ?> map) throws Exception {
        MasterDataTenantQueyRequest self = new MasterDataTenantQueyRequest();
        return TeaModel.build(map, self);
    }

    public MasterDataTenantQueyRequest setEntityCode(String entityCode) {
        this.entityCode = entityCode;
        return this;
    }
    public String getEntityCode() {
        return this.entityCode;
    }

    public MasterDataTenantQueyRequest setScopeCode(String scopeCode) {
        this.scopeCode = scopeCode;
        return this;
    }
    public String getScopeCode() {
        return this.scopeCode;
    }

}
