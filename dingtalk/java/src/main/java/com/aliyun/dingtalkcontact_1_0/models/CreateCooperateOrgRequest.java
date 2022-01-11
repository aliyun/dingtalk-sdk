// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgRequest extends TeaModel {
    // 行业code
    @NameInMap("industryCode")
    public Long industryCode;

    // 合作空间的logo
    @NameInMap("logoMediaId")
    public String logoMediaId;

    // 合作空间组织名称
    @NameInMap("orgName")
    public String orgName;

    public static CreateCooperateOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCooperateOrgRequest self = new CreateCooperateOrgRequest();
        return TeaModel.build(map, self);
    }

    public CreateCooperateOrgRequest setIndustryCode(Long industryCode) {
        this.industryCode = industryCode;
        return this;
    }
    public Long getIndustryCode() {
        return this.industryCode;
    }

    public CreateCooperateOrgRequest setLogoMediaId(String logoMediaId) {
        this.logoMediaId = logoMediaId;
        return this;
    }
    public String getLogoMediaId() {
        return this.logoMediaId;
    }

    public CreateCooperateOrgRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

}
