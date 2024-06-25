// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantProcessInstanceForDownloadFileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a17444d1-075b-4a4d-xxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("withCommentAttatchment")
    public Boolean withCommentAttatchment;

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

    public GrantProcessInstanceForDownloadFileRequest setWithCommentAttatchment(Boolean withCommentAttatchment) {
        this.withCommentAttatchment = withCommentAttatchment;
        return this;
    }
    public Boolean getWithCommentAttatchment() {
        return this.withCommentAttatchment;
    }

}
