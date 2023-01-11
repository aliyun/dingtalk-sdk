// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageStatusRequest extends TeaModel {
    /**
     * <p>离线包ID</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>上传任务ID</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static HUploadPackageStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageStatusRequest self = new HUploadPackageStatusRequest();
        return TeaModel.build(map, self);
    }

    public HUploadPackageStatusRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public HUploadPackageStatusRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
