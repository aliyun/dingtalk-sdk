// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceIdListRequest extends TeaModel {
    /**
     * <p>应用ID</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>流程审批结果</p>
     */
    @NameInMap("approvedResult")
    public String approvedResult;

    /**
     * <p>createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表</p>
     */
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    /**
     * <p>createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。</p>
     */
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    /**
     * <p>表单ID</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>实例状态</p>
     */
    @NameInMap("instanceStatus")
    public String instanceStatus;

    /**
     * <p>语言</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表</p>
     */
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    /**
     * <p>modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。</p>
     */
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    /**
     * <p>根据流程发起人工号查询</p>
     */
    @NameInMap("originatorId")
    public String originatorId;

    /**
     * <p>根据表单内组件值查询</p>
     */
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    /**
     * <p>应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>任务ID</p>
     */
    @NameInMap("taskId")
    public String taskId;

    /**
     * <p>钉钉的userId</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static GetInstanceIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceIdListRequest self = new GetInstanceIdListRequest();
        return TeaModel.build(map, self);
    }

    public GetInstanceIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstanceIdListRequest setApprovedResult(String approvedResult) {
        this.approvedResult = approvedResult;
        return this;
    }
    public String getApprovedResult() {
        return this.approvedResult;
    }

    public GetInstanceIdListRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetInstanceIdListRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetInstanceIdListRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetInstanceIdListRequest setInstanceStatus(String instanceStatus) {
        this.instanceStatus = instanceStatus;
        return this;
    }
    public String getInstanceStatus() {
        return this.instanceStatus;
    }

    public GetInstanceIdListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstanceIdListRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public GetInstanceIdListRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public GetInstanceIdListRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public GetInstanceIdListRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public GetInstanceIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstanceIdListRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetInstanceIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetInstanceIdListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetInstanceIdListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
