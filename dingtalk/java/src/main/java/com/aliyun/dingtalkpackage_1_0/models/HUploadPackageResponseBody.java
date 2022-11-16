// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageResponseBody extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static HUploadPackageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageResponseBody self = new HUploadPackageResponseBody();
        return TeaModel.build(map, self);
    }

    public HUploadPackageResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
