// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgRecordDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>pushkxQ2b2DTDAb0qkTjNdKLmwiEiE</p>
     */
    @NameInMap("task_id")
    public String taskId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>jYdrJoCmTo0iE</p>
     */
    @NameInMap("unionid")
    public String unionid;

    public static GetMsgRecordDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMsgRecordDetailRequest self = new GetMsgRecordDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetMsgRecordDetailRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetMsgRecordDetailRequest setUnionid(String unionid) {
        this.unionid = unionid;
        return this;
    }
    public String getUnionid() {
        return this.unionid;
    }

}
