// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRequest extends TeaModel {
    @NameInMap("city")
    public String city;

    @NameInMap("industry")
    public String industry;

    @NameInMap("industryCode")
    public Integer industryCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15800000000</p>
     */
    @NameInMap("mobileNum")
    public String mobileNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试组织</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("province")
    public String province;

    public static AddOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRequest self = new AddOrgRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgRequest setCity(String city) {
        this.city = city;
        return this;
    }
    public String getCity() {
        return this.city;
    }

    public AddOrgRequest setIndustry(String industry) {
        this.industry = industry;
        return this;
    }
    public String getIndustry() {
        return this.industry;
    }

    public AddOrgRequest setIndustryCode(Integer industryCode) {
        this.industryCode = industryCode;
        return this;
    }
    public Integer getIndustryCode() {
        return this.industryCode;
    }

    public AddOrgRequest setMobileNum(String mobileNum) {
        this.mobileNum = mobileNum;
        return this;
    }
    public String getMobileNum() {
        return this.mobileNum;
    }

    public AddOrgRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddOrgRequest setProvince(String province) {
        this.province = province;
        return this;
    }
    public String getProvince() {
        return this.province;
    }

}
