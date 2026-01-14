// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class AddRecordPermissionResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    /**
     * <strong>example:</strong>
     * <p>76327xxxxxxx353936325f35</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    public static AddRecordPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRecordPermissionResponseBody self = new AddRecordPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRecordPermissionResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public AddRecordPermissionResponseBody setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

}
