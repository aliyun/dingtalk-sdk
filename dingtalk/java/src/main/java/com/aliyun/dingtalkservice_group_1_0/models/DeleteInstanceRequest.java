// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class DeleteInstanceRequest extends TeaModel {
    /**
     * <p>表单CODE</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>开放数据实例ID</p>
     */
    @NameInMap("openDataInstanceId")
    public String openDataInstanceId;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>操作人unionid</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static DeleteInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteInstanceRequest self = new DeleteInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteInstanceRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public DeleteInstanceRequest setOpenDataInstanceId(String openDataInstanceId) {
        this.openDataInstanceId = openDataInstanceId;
        return this;
    }
    public String getOpenDataInstanceId() {
        return this.openDataInstanceId;
    }

    public DeleteInstanceRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public DeleteInstanceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
