// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class SyncExceedApplyRequest extends TeaModel {
    // 商旅超标审批单id
    @NameInMap("applyId")
    public String applyId;

    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 审批意见
    @NameInMap("remark")
    public String remark;

    // 审批单状态 1同意2拒绝
    @NameInMap("status")
    public Integer status;

    // 第三方流程实例id
    @NameInMap("thirdpartyFlowId")
    public String thirdpartyFlowId;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static SyncExceedApplyRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncExceedApplyRequest self = new SyncExceedApplyRequest();
        return TeaModel.build(map, self);
    }

    public SyncExceedApplyRequest setApplyId(String applyId) {
        this.applyId = applyId;
        return this;
    }
    public String getApplyId() {
        return this.applyId;
    }

    public SyncExceedApplyRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public SyncExceedApplyRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public SyncExceedApplyRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public SyncExceedApplyRequest setThirdpartyFlowId(String thirdpartyFlowId) {
        this.thirdpartyFlowId = thirdpartyFlowId;
        return this;
    }
    public String getThirdpartyFlowId() {
        return this.thirdpartyFlowId;
    }

    public SyncExceedApplyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
