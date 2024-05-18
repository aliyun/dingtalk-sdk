// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityNameRequest extends TeaModel {
    @NameInMap("dingTenantId")
    public Long dingTenantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("legalEntityName")
    public String legalEntityName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("originLegalEntityName")
    public String originLegalEntityName;

    public static UpdateHrmLegalEntityNameRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityNameRequest self = new UpdateHrmLegalEntityNameRequest();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityNameRequest setDingTenantId(Long dingTenantId) {
        this.dingTenantId = dingTenantId;
        return this;
    }
    public Long getDingTenantId() {
        return this.dingTenantId;
    }

    public UpdateHrmLegalEntityNameRequest setLegalEntityName(String legalEntityName) {
        this.legalEntityName = legalEntityName;
        return this;
    }
    public String getLegalEntityName() {
        return this.legalEntityName;
    }

    public UpdateHrmLegalEntityNameRequest setOriginLegalEntityName(String originLegalEntityName) {
        this.originLegalEntityName = originLegalEntityName;
        return this;
    }
    public String getOriginLegalEntityName() {
        return this.originLegalEntityName;
    }

}
