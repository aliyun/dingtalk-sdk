// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgRequest extends TeaModel {
    // 合作空间组织名称
    @NameInMap("orgName")
    public String orgName;

    // 合作空间的logo
    @NameInMap("logoMediaId")
    public String logoMediaId;

    // 行业code
    @NameInMap("industryCode")
    public Long industryCode;

    public static CreateCooperateOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCooperateOrgRequest self = new CreateCooperateOrgRequest();
        return TeaModel.build(map, self);
    }

    public CreateCooperateOrgRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public CreateCooperateOrgRequest setLogoMediaId(String logoMediaId) {
        this.logoMediaId = logoMediaId;
        return this;
    }
    public String getLogoMediaId() {
        return this.logoMediaId;
    }

    public CreateCooperateOrgRequest setIndustryCode(Long industryCode) {
        this.industryCode = industryCode;
        return this;
    }
    public Long getIndustryCode() {
        return this.industryCode;
    }

}
