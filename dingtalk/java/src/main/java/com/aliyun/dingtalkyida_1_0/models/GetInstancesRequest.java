// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesRequest extends TeaModel {
    // 应用编码
    @NameInMap("appType")
    public String appType;

    // 审批结果。可选值为：agree, disagree。 分别表示：同意， 拒绝。
    @NameInMap("approvedResult")
    public String approvedResult;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表, 字符串格式，且为yyyy-MM-DD格式
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。字符串格式，且为yyyy-MM-DD格式。 和createFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)创建的数据。
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    // 表单ID
    @NameInMap("formUuid")
    public String formUuid;

    // 实例状态, 可选值为：RUNNING,TERMINATED,COMPLETED,ERROR。 分别代表：运行中，已终止，已完成，异常。
    @NameInMap("instanceStatus")
    public String instanceStatus;

    // 语言。可选值：zh_CN/en_US 默认：zh_CN
    @NameInMap("language")
    public String language;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式。 和modifiedFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)被修改的数据。
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    // 根据数据提交人工号查询
    @NameInMap("originatorId")
    public String originatorId;

    // 根据表单内组件值查询
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    // 应用秘钥。在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 任务ID。一般用不到。
    @NameInMap("taskId")
    public String taskId;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static GetInstancesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesRequest self = new GetInstancesRequest();
        return TeaModel.build(map, self);
    }

    public GetInstancesRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstancesRequest setApprovedResult(String approvedResult) {
        this.approvedResult = approvedResult;
        return this;
    }
    public String getApprovedResult() {
        return this.approvedResult;
    }

    public GetInstancesRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetInstancesRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetInstancesRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetInstancesRequest setInstanceStatus(String instanceStatus) {
        this.instanceStatus = instanceStatus;
        return this;
    }
    public String getInstanceStatus() {
        return this.instanceStatus;
    }

    public GetInstancesRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstancesRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public GetInstancesRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public GetInstancesRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public GetInstancesRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public GetInstancesRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstancesRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetInstancesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetInstancesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetInstancesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
