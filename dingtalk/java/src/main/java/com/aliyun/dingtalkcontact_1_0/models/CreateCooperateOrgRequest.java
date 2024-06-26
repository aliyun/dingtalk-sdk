// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("industryCode")
    public Long industryCode;

    /**
     * <strong>example:</strong>
     * <p>mediaId</p>
     */
    @NameInMap("logoMediaId")
    public String logoMediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试联盟</p>
     */
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
