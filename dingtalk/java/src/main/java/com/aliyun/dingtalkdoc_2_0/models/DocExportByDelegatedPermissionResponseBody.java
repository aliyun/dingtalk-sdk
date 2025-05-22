// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocExportByDelegatedPermissionResponseBody extends TeaModel {
    @NameInMap("taskId")
    public Long taskId;

    public static DocExportByDelegatedPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocExportByDelegatedPermissionResponseBody self = new DocExportByDelegatedPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public DocExportByDelegatedPermissionResponseBody setTaskId(Long taskId) {
        this.taskId = taskId;
        return this;
    }
    public Long getTaskId() {
        return this.taskId;
    }

}
