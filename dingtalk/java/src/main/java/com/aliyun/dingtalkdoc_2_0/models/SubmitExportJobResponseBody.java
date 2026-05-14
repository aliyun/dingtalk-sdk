// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitExportJobResponseBody extends TeaModel {
    @NameInMap("downloadUrl")
    public String downloadUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    public static SubmitExportJobResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitExportJobResponseBody self = new SubmitExportJobResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitExportJobResponseBody setDownloadUrl(String downloadUrl) {
        this.downloadUrl = downloadUrl;
        return this;
    }
    public String getDownloadUrl() {
        return this.downloadUrl;
    }

    public SubmitExportJobResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
