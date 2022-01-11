// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class GetUserSourceListRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("description")
    public String description;

    @NameInMap("openInstanceId")
    public String openInstanceId;

    @NameInMap("orgId")
    public Long orgId;

    @NameInMap("orgName")
    public String orgName;

    @NameInMap("productionType")
    public Integer productionType;

    public static GetUserSourceListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserSourceListRequest self = new GetUserSourceListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserSourceListRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetUserSourceListRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetUserSourceListRequest setOpenInstanceId(String openInstanceId) {
        this.openInstanceId = openInstanceId;
        return this;
    }
    public String getOpenInstanceId() {
        return this.openInstanceId;
    }

    public GetUserSourceListRequest setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public GetUserSourceListRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public GetUserSourceListRequest setProductionType(Integer productionType) {
        this.productionType = productionType;
        return this;
    }
    public Integer getProductionType() {
        return this.productionType;
    }

}
