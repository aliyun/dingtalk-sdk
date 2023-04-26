// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("fileId")
    public String fileId;

    @NameInMap("fileIdList")
    public java.util.List<String> fileIdList;

    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("userId")
    public String userId;

    public static GetSpaceWithDownloadAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceWithDownloadAuthRequest self = new GetSpaceWithDownloadAuthRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceWithDownloadAuthRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetSpaceWithDownloadAuthRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public GetSpaceWithDownloadAuthRequest setFileIdList(java.util.List<String> fileIdList) {
        this.fileIdList = fileIdList;
        return this;
    }
    public java.util.List<String> getFileIdList() {
        return this.fileIdList;
    }

    public GetSpaceWithDownloadAuthRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public GetSpaceWithDownloadAuthRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
