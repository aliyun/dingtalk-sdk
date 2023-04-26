// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferRequest extends TeaModel {
    @NameInMap("deptIdsAfterTransfer")
    public java.util.List<Long> deptIdsAfterTransfer;

    @NameInMap("jobIdAfterTransfer")
    public String jobIdAfterTransfer;

    @NameInMap("mainDeptIdAfterTransfer")
    public Long mainDeptIdAfterTransfer;

    @NameInMap("operateUserId")
    public String operateUserId;

    @NameInMap("positionIdAfterTransfer")
    public String positionIdAfterTransfer;

    @NameInMap("positionLevelAfterTransfer")
    public String positionLevelAfterTransfer;

    @NameInMap("positionNameAfterTransfer")
    public String positionNameAfterTransfer;

    @NameInMap("rankIdAfterTransfer")
    public String rankIdAfterTransfer;

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
