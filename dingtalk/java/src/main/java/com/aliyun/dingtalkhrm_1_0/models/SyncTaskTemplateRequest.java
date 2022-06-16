// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncTaskTemplateRequest extends TeaModel {
    // 任务模板描述
    @NameInMap("des")
    public String des;

    // 扩展信息，json串
    @NameInMap("ext")
    public String ext;

    // 模版名称
    @NameInMap("name")
    public String name;

    // 任务模版创建人staffId
    @NameInMap("optUserId")
    public String optUserId;

    // isv对应的任务模版唯一键
    @NameInMap("outerId")
    public String outerId;

    // 圈人规则
    @NameInMap("taskScopeVO")
    public SyncTaskTemplateRequestTaskScopeVO taskScopeVO;

    // 任务模版类型：TRAIN_TASK、PERFORMANCE_TASK
    @NameInMap("taskType")
    public String taskType;

    @NameInMap("solutionType")
    public String solutionType;

    public static SyncTaskTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTaskTemplateRequest self = new SyncTaskTemplateRequest();
        return TeaModel.build(map, self);
    }

    public SyncTaskTemplateRequest setDes(String des) {
        this.des = des;
        return this;
    }
    public String getDes() {
        return this.des;
    }

    public SyncTaskTemplateRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public SyncTaskTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SyncTaskTemplateRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public SyncTaskTemplateRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public SyncTaskTemplateRequest setTaskScopeVO(SyncTaskTemplateRequestTaskScopeVO taskScopeVO) {
        this.taskScopeVO = taskScopeVO;
        return this;
    }
    public SyncTaskTemplateRequestTaskScopeVO getTaskScopeVO() {
        return this.taskScopeVO;
    }

    public SyncTaskTemplateRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public SyncTaskTemplateRequest setSolutionType(String solutionType) {
        this.solutionType = solutionType;
        return this;
    }
    public String getSolutionType() {
        return this.solutionType;
    }

    public static class SyncTaskTemplateRequestTaskScopeVO extends TeaModel {
        // 按照部门圈人
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        // 按照职位圈人
        @NameInMap("positionIds")
        public java.util.List<String> positionIds;

        // 按照角色圈人
        @NameInMap("roleIds")
        public java.util.List<String> roleIds;

        // 按照员工userId圈人
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static SyncTaskTemplateRequestTaskScopeVO build(java.util.Map<String, ?> map) throws Exception {
            SyncTaskTemplateRequestTaskScopeVO self = new SyncTaskTemplateRequestTaskScopeVO();
            return TeaModel.build(map, self);
        }

        public SyncTaskTemplateRequestTaskScopeVO setDeptIds(java.util.List<Long> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<Long> getDeptIds() {
            return this.deptIds;
        }

        public SyncTaskTemplateRequestTaskScopeVO setPositionIds(java.util.List<String> positionIds) {
            this.positionIds = positionIds;
            return this;
        }
        public java.util.List<String> getPositionIds() {
            return this.positionIds;
        }

        public SyncTaskTemplateRequestTaskScopeVO setRoleIds(java.util.List<String> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<String> getRoleIds() {
            return this.roleIds;
        }

        public SyncTaskTemplateRequestTaskScopeVO setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
