// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyRequest extends TeaModel {
    // 第三方企业ID
    @NameInMap("corpId")
    public String corpId;

    // 审批时间
    @NameInMap("operateTime")
    public String operateTime;

    // 审批备注
    @NameInMap("remark")
    public String remark;

    // 审批结果：1-同意，2-拒绝
    @NameInMap("status")
    public Long status;

    // 第三方审批单ID
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    // 审批的第三方员工ID
    @NameInMap("userId")
    public String userId;

    // suiteKey
    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // account
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // tokenGrantType
    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    public static ApproveCityCarApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        ApproveCityCarApplyRequest self = new ApproveCityCarApplyRequest();
        return TeaModel.build(map, self);
    }

    public ApproveCityCarApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ApproveCityCarApplyRequest setOperateTime(String operateTime) {
        this.operateTime = operateTime;
        return this;
    }
    public String getOperateTime() {
        return this.operateTime;
    }

    public ApproveCityCarApplyRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public ApproveCityCarApplyRequest setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public ApproveCityCarApplyRequest setThirdPartApplyId(String thirdPartApplyId) {
        this.thirdPartApplyId = thirdPartApplyId;
        return this;
    }
    public String getThirdPartApplyId() {
        return this.thirdPartApplyId;
    }

    public ApproveCityCarApplyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ApproveCityCarApplyRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public ApproveCityCarApplyRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public ApproveCityCarApplyRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

}
