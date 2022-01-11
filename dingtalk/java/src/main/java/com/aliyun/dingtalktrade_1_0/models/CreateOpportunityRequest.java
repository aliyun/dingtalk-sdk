// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateOpportunityRequest extends TeaModel {
    // 归属人电话号码
    @NameInMap("belongToPhoneNum")
    public String belongToPhoneNum;

    // 联系人电话
    @NameInMap("contactPhoneNum")
    public String contactPhoneNum;

    // 企业CorpId
    @NameInMap("corpId")
    public String corpId;

    // 部门Id
    @NameInMap("deptId")
    public Long deptId;

    // 商品码
    @NameInMap("marketCode")
    public String marketCode;

    public static CreateOpportunityRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOpportunityRequest self = new CreateOpportunityRequest();
        return TeaModel.build(map, self);
    }

    public CreateOpportunityRequest setBelongToPhoneNum(String belongToPhoneNum) {
        this.belongToPhoneNum = belongToPhoneNum;
        return this;
    }
    public String getBelongToPhoneNum() {
        return this.belongToPhoneNum;
    }

    public CreateOpportunityRequest setContactPhoneNum(String contactPhoneNum) {
        this.contactPhoneNum = contactPhoneNum;
        return this;
    }
    public String getContactPhoneNum() {
        return this.contactPhoneNum;
    }

    public CreateOpportunityRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateOpportunityRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CreateOpportunityRequest setMarketCode(String marketCode) {
        this.marketCode = marketCode;
        return this;
    }
    public String getMarketCode() {
        return this.marketCode;
    }

}
