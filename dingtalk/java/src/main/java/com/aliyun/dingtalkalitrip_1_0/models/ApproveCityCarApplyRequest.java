// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyRequest extends TeaModel {
    /**
     * <p>第三方企业ID</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>审批时间</p>
     */
    @NameInMap("operateTime")
    public String operateTime;

    /**
     * <p>审批备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>审批结果：1-同意，2-拒绝</p>
     */
    @NameInMap("status")
    public Long status;

    /**
     * <p>第三方审批单ID</p>
     */
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    /**
     * <p>审批的第三方员工ID</p>
     */
    @NameInMap("userId")
    public String userId;

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

}
