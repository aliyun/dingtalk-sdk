// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceIdListRequest extends TeaModel {
    // 表单ID
    @NameInMap("formUuid")
    public String formUuid;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    // 语言
    @NameInMap("language")
    public String language;

    // 根据表单内组件值查询
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 实例状态
    @NameInMap("instanceStatus")
    public String instanceStatus;

    // 流程审批结果
    @NameInMap("approvedResult")
    public String approvedResult;

    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 根据流程发起人工号查询
    @NameInMap("originatorId")
    public String originatorId;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    // 任务ID
    @NameInMap("taskId")
    public String taskId;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static GetInstanceIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceIdListRequest self = new GetInstanceIdListRequest();
        return TeaModel.build(map, self);
    }

    public GetInstanceIdListRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetInstanceIdListRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public GetInstanceIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstanceIdListRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public GetInstanceIdListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstanceIdListRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public GetInstanceIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetInstanceIdListRequest setInstanceStatus(String instanceStatus) {
        this.instanceStatus = instanceStatus;
        return this;
    }
    public String getInstanceStatus() {
        return this.instanceStatus;
    }

    public GetInstanceIdListRequest setApprovedResult(String approvedResult) {
        this.approvedResult = approvedResult;
        return this;
    }
    public String getApprovedResult() {
        return this.approvedResult;
    }

    public GetInstanceIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstanceIdListRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public GetInstanceIdListRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetInstanceIdListRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetInstanceIdListRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetInstanceIdListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetInstanceIdListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
