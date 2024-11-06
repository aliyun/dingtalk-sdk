// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGrantProcessInstanceForDownloadFileRequest extends TeaModel {
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

    public static PremiumGrantProcessInstanceForDownloadFileRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGrantProcessInstanceForDownloadFileRequest self = new PremiumGrantProcessInstanceForDownloadFileRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGrantProcessInstanceForDownloadFileRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public PremiumGrantProcessInstanceForDownloadFileRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumGrantProcessInstanceForDownloadFileRequest setWithCommentAttatchment(Boolean withCommentAttatchment) {
        this.withCommentAttatchment = withCommentAttatchment;
        return this;
    }
    public Boolean getWithCommentAttatchment() {
        return this.withCommentAttatchment;
    }

}
