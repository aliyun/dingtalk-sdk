// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class MoveOutTempStorageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a1b2c3d4e5f67890a1b2c3d4e5f67890</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static MoveOutTempStorageRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveOutTempStorageRequest self = new MoveOutTempStorageRequest();
        return TeaModel.build(map, self);
    }

    public MoveOutTempStorageRequest setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public MoveOutTempStorageRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
