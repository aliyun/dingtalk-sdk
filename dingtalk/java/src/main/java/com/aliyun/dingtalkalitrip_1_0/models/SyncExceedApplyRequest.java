// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class SyncExceedApplyRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyId")
    public String applyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("thirdpartyFlowId")
    public String thirdpartyFlowId;

    /**
     * <p>This parameter is required.</p>
     */
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
