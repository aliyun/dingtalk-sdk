// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTransferRequest extends TeaModel {
    // 员工调岗后的部门id列表
    @NameInMap("deptIdsAfterTransfer")
    public java.util.List<Long> deptIdsAfterTransfer;

    // 员工调岗后的职务id
    @NameInMap("jobIdAfterTransfer")
    public String jobIdAfterTransfer;

    // 员工调岗后的人事主部门id
    @NameInMap("mainDeptIdAfterTransfer")
    public Long mainDeptIdAfterTransfer;

    // 操作人
    @NameInMap("operateUserId")
    public String operateUserId;

    // 员工调岗后的职位id，参数同时有职位名称以及id，以id为准
    @NameInMap("positionIdAfterTransfer")
    public String positionIdAfterTransfer;

    // 员工调岗后的职级名称，长度不超过64，参数同时有职级名称以及id，以id为准
    @NameInMap("positionLevelAfterTransfer")
    public String positionLevelAfterTransfer;

    // 员工调岗后的职位名称，长度不超过124，参数同时有职位名称以及id，以id为准
    @NameInMap("positionNameAfterTransfer")
    public String positionNameAfterTransfer;

    // 员工调岗后的职级id，参数同时有职级名称以及id，以id为准
    @NameInMap("rankIdAfterTransfer")
    public String rankIdAfterTransfer;

    // 被调岗员工userId
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
