// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferRequest extends TeaModel {
    @NameInMap("deptIdsAfterTransfer")
    public java.util.List<Long> deptIdsAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>aefadfadaewedad</p>
     */
    @NameInMap("jobIdAfterTransfer")
    public String jobIdAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>123L</p>
     */
    @NameInMap("mainDeptIdAfterTransfer")
    public Long mainDeptIdAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>232312312</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    /**
     * <strong>example:</strong>
     * <p>fasdfaddsadfa</p>
     */
    @NameInMap("positionIdAfterTransfer")
    public String positionIdAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>L1</p>
     */
    @NameInMap("positionLevelAfterTransfer")
    public String positionLevelAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>经理</p>
     */
    @NameInMap("positionNameAfterTransfer")
    public String positionNameAfterTransfer;

    /**
     * <strong>example:</strong>
     * <p>fasdfaddsadfa</p>
     */
    @NameInMap("rankIdAfterTransfer")
    public String rankIdAfterTransfer;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2332</p>
     */
    @NameInMap("userId")
    public String userId;

    public static HrmProcessTransferRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTransferRequest self = new HrmProcessTransferRequest();
        return TeaModel.build(map, self);
    }

    public HrmProcessTransferRequest setDeptIdsAfterTransfer(java.util.List<Long> deptIdsAfterTransfer) {
        this.deptIdsAfterTransfer = deptIdsAfterTransfer;
        return this;
    }
    public java.util.List<Long> getDeptIdsAfterTransfer() {
        return this.deptIdsAfterTransfer;
    }

    public HrmProcessTransferRequest setJobIdAfterTransfer(String jobIdAfterTransfer) {
        this.jobIdAfterTransfer = jobIdAfterTransfer;
        return this;
    }
    public String getJobIdAfterTransfer() {
        return this.jobIdAfterTransfer;
    }

    public HrmProcessTransferRequest setMainDeptIdAfterTransfer(Long mainDeptIdAfterTransfer) {
        this.mainDeptIdAfterTransfer = mainDeptIdAfterTransfer;
        return this;
    }
    public Long getMainDeptIdAfterTransfer() {
        return this.mainDeptIdAfterTransfer;
    }

    public HrmProcessTransferRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

    public HrmProcessTransferRequest setPositionIdAfterTransfer(String positionIdAfterTransfer) {
        this.positionIdAfterTransfer = positionIdAfterTransfer;
        return this;
    }
    public String getPositionIdAfterTransfer() {
        return this.positionIdAfterTransfer;
    }

    public HrmProcessTransferRequest setPositionLevelAfterTransfer(String positionLevelAfterTransfer) {
        this.positionLevelAfterTransfer = positionLevelAfterTransfer;
        return this;
    }
    public String getPositionLevelAfterTransfer() {
        return this.positionLevelAfterTransfer;
    }

    public HrmProcessTransferRequest setPositionNameAfterTransfer(String positionNameAfterTransfer) {
        this.positionNameAfterTransfer = positionNameAfterTransfer;
        return this;
    }
    public String getPositionNameAfterTransfer() {
        return this.positionNameAfterTransfer;
    }

    public HrmProcessTransferRequest setRankIdAfterTransfer(String rankIdAfterTransfer) {
        this.rankIdAfterTransfer = rankIdAfterTransfer;
        return this;
    }
    public String getRankIdAfterTransfer() {
        return this.rankIdAfterTransfer;
    }

    public HrmProcessTransferRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
