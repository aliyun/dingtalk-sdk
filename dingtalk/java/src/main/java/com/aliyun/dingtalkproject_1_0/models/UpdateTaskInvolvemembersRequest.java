// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskInvolvemembersRequest extends TeaModel {
    /**
     * <p>新增参与者列表。</p>
     */
    @NameInMap("addInvolvers")
    public java.util.List<String> addInvolvers;

    /**
     * <p>移除参与者列表。</p>
     */
    @NameInMap("delInvolvers")
    public java.util.List<String> delInvolvers;

    /**
     * <p>更新任务参与者列表。</p>
     */
    @NameInMap("involveMembers")
    public java.util.List<String> involveMembers;

    public static UpdateTaskInvolvemembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskInvolvemembersRequest self = new UpdateTaskInvolvemembersRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskInvolvemembersRequest setAddInvolvers(java.util.List<String> addInvolvers) {
        this.addInvolvers = addInvolvers;
        return this;
    }
    public java.util.List<String> getAddInvolvers() {
        return this.addInvolvers;
    }

    public UpdateTaskInvolvemembersRequest setDelInvolvers(java.util.List<String> delInvolvers) {
        this.delInvolvers = delInvolvers;
        return this;
    }
    public java.util.List<String> getDelInvolvers() {
        return this.delInvolvers;
    }

    public UpdateTaskInvolvemembersRequest setInvolveMembers(java.util.List<String> involveMembers) {
        this.involveMembers = involveMembers;
        return this;
    }
    public java.util.List<String> getInvolveMembers() {
        return this.involveMembers;
    }

}
