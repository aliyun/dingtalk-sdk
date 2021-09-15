// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CheckOpportunityResultRequest extends TeaModel {
    // corpId
    @NameInMap("corpId")
    public String corpId;

    // belongToPhoneNum
    @NameInMap("belongToPhoneNum")
    public String belongToPhoneNum;

    // contactPhoneNum
    @NameInMap("contactPhoneNum")
    public String contactPhoneNum;

    // deptId
    @NameInMap("deptId")
    public Long deptId;

    // marketCode
    @NameInMap("marketCode")
    public String marketCode;

    public static CheckOpportunityResultRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckOpportunityResultRequest self = new CheckOpportunityResultRequest();
        return TeaModel.build(map, self);
    }

    public CheckOpportunityResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CheckOpportunityResultRequest setBelongToPhoneNum(String belongToPhoneNum) {
        this.belongToPhoneNum = belongToPhoneNum;
        return this;
    }
    public String getBelongToPhoneNum() {
        return this.belongToPhoneNum;
    }

    public CheckOpportunityResultRequest setContactPhoneNum(String contactPhoneNum) {
        this.contactPhoneNum = contactPhoneNum;
        return this;
    }
    public String getContactPhoneNum() {
        return this.contactPhoneNum;
    }

    public CheckOpportunityResultRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CheckOpportunityResultRequest setMarketCode(String marketCode) {
        this.marketCode = marketCode;
        return this;
    }
    public String getMarketCode() {
        return this.marketCode;
    }

}
