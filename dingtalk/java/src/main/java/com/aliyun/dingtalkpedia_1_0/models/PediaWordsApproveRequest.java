// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsApproveRequest extends TeaModel {
    /**
     * <p>拒绝的原因，可选</p>
     */
    @NameInMap("approveReason")
    public String approveReason;

    /**
     * <p>审核的结果，1通过0代表拒绝</p>
     */
    @NameInMap("approveStatus")
    public String approveStatus;

    /**
     * <p>当前内部群是否高亮</p>
     */
    @NameInMap("imHighLight")
    public Boolean imHighLight;

    /**
     * <p>服务群是否高亮</p>
     */
    @NameInMap("simHighLight")
    public Boolean simHighLight;

    /**
     * <p>操作人的组织员工编号，开放平台员工信息接口获取userId</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>当前审核的词条的主键编号</p>
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
