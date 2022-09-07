// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthRequest extends TeaModel {
    // 应用的agentid。
    @NameInMap("agentId")
    public Long agentId;

    // 审批附件ID。
    @NameInMap("fileId")
    public String fileId;

    // 附件ID列表，支持批量授权，最大列表长度：20。
    @NameInMap("fileIdList")
    public java.util.List<String> fileIdList;

    // 实例ID。
    // 
    // 企业内部应用
    // 
    // 可通过获取审批实例ID列表接口获取。
    // 
    // 第三方企业应用
    // 
    // 可以通过推送的审批事件中获取，参考biz_type=22。
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 授权允许预览附件的用户userid。
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
