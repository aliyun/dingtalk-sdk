// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SyncTaskTemplateRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("delete")
    public Boolean delete;

    /**
     * <strong>example:</strong>
     * <p>培训、薪酬任务模版</p>
     */
    @NameInMap("des")
    public String des;

    /**
     * <strong>example:</strong>
     * <p>{&quot;key&quot;:value}</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>培训模版</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23234</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>232332</p>
     */
    @NameInMap("outerId")
    public String outerId;

    @NameInMap("taskScopeVO")
    public SyncTaskTemplateRequestTaskScopeVO taskScopeVO;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PERFORMANCE_TASK、TRAIN_TASK</p>
     */
    @NameInMap("taskType")
    public String taskType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>onboarding</p>
     */
    @NameInMap("solutionType")
    public String solutionType;

    public static SyncTaskTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTaskTemplateRequest self = new SyncTaskTemplateRequest();
        return TeaModel.build(map, self);
    }

    public SyncTaskTemplateRequest setDelete(Boolean delete) {
        this.delete = delete;
        return this;
    }
    public Boolean getDelete() {
        return this.delete;
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
        @NameInMap("deptIds")
        public java.util.List<Long> deptIds;

        @NameInMap("positionIds")
        public java.util.List<String> positionIds;

        @NameInMap("roleIds")
        public java.util.List<String> roleIds;

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
