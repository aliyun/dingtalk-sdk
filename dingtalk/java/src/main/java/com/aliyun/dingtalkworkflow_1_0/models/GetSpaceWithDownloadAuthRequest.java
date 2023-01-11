// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthRequest extends TeaModel {
    /**
     * <p>应用的agentid。</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>审批附件ID。</p>
     */
    @NameInMap("fileId")
    public String fileId;

    /**
     * <p>附件ID列表，支持批量授权，最大列表长度：20。</p>
     */
    @NameInMap("fileIdList")
    public java.util.List<String> fileIdList;

    /**
     * <p>实例ID。</p>
     * <br>
     * <p>企业内部应用</p>
     * <br>
     * <p>可通过获取审批实例ID列表接口获取。</p>
     * <br>
     * <p>第三方企业应用</p>
     * <br>
     * <p>可以通过推送的审批事件中获取，参考biz_type=22。</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>授权允许预览附件的用户userid。</p>
     */
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
