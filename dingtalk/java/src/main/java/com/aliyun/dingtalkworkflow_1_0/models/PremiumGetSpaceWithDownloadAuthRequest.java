// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetSpaceWithDownloadAuthRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>8345000</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111</p>
     */
    @NameInMap("fileId")
    public String fileId;

    @NameInMap("fileIdList")
    public java.util.List<String> fileIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a17444d1-075b-4a4d-xxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("withCommentAttatchment")
    public Boolean withCommentAttatchment;

    public static PremiumGetSpaceWithDownloadAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetSpaceWithDownloadAuthRequest self = new PremiumGetSpaceWithDownloadAuthRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetSpaceWithDownloadAuthRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public PremiumGetSpaceWithDownloadAuthRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public PremiumGetSpaceWithDownloadAuthRequest setFileIdList(java.util.List<String> fileIdList) {
        this.fileIdList = fileIdList;
        return this;
    }
    public java.util.List<String> getFileIdList() {
        return this.fileIdList;
    }

    public PremiumGetSpaceWithDownloadAuthRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumGetSpaceWithDownloadAuthRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PremiumGetSpaceWithDownloadAuthRequest setWithCommentAttatchment(Boolean withCommentAttatchment) {
        this.withCommentAttatchment = withCommentAttatchment;
        return this;
    }
    public Boolean getWithCommentAttatchment() {
        return this.withCommentAttatchment;
    }

}
