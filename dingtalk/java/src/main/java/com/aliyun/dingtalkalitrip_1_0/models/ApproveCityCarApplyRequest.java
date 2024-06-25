// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class ApproveCityCarApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>corpx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>2021-03-18 20:26:56</p>
     */
    @NameInMap("operateTime")
    public String operateTime;

    /**
     * <strong>example:</strong>
     * <p>同意</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Long status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>apply1</p>
     */
    @NameInMap("thirdPartApplyId")
    public String thirdPartApplyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user1</p>
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
