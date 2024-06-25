// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsApproveRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>拒绝</p>
     */
    @NameInMap("approveReason")
    public String approveReason;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("approveStatus")
    public String approveStatus;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("imHighLight")
    public Boolean imHighLight;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("simHighLight")
    public Boolean simHighLight;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>232432</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1213132</p>
     */
    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsApproveRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsApproveRequest self = new PediaWordsApproveRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsApproveRequest setApproveReason(String approveReason) {
        this.approveReason = approveReason;
        return this;
    }
    public String getApproveReason() {
        return this.approveReason;
    }

    public PediaWordsApproveRequest setApproveStatus(String approveStatus) {
        this.approveStatus = approveStatus;
        return this;
    }
    public String getApproveStatus() {
        return this.approveStatus;
    }

    public PediaWordsApproveRequest setImHighLight(Boolean imHighLight) {
        this.imHighLight = imHighLight;
        return this;
    }
    public Boolean getImHighLight() {
        return this.imHighLight;
    }

    public PediaWordsApproveRequest setSimHighLight(Boolean simHighLight) {
        this.simHighLight = simHighLight;
        return this;
    }
    public Boolean getSimHighLight() {
        return this.simHighLight;
    }

    public PediaWordsApproveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsApproveRequest setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
