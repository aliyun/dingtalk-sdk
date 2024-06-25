// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class CreatePackageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1663748308644pjpF</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static CreatePackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreatePackageResponseBody self = new CreatePackageResponseBody();
        return TeaModel.build(map, self);
    }

    public CreatePackageResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
