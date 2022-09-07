// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantProcessInstanceForDownloadFileRequest extends TeaModel {
    // 文件id，调用获取审批实例详情接口获取。
    @NameInMap("fileId")
    public String fileId;

    // 实例ID。
    // 
    // 调用获取审批实例详情接口获取。
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GrantProcessInstanceForDownloadFileRequest build(java.util.Map<String, ?> map) throws Exception {
        GrantProcessInstanceForDownloadFileRequest self = new GrantProcessInstanceForDownloadFileRequest();
        return TeaModel.build(map, self);
    }

    public GrantProcessInstanceForDownloadFileRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GrantProcessInstanceForDownloadFileRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
