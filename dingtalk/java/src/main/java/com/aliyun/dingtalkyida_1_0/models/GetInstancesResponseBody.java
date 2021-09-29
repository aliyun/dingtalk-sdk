// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesResponseBody extends TeaModel {
    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // data
    @NameInMap("data")
    public java.util.List<GetInstancesResponseBodyData> data;

    public static GetInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesResponseBody self = new GetInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstancesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public GetInstancesResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetInstancesResponseBody setData(java.util.List<GetInstancesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetInstancesResponseBodyData> getData() {
        return this.data;
    }

    public static class GetInstancesResponseBodyDataActionExecutorName extends TeaModel {
        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // type
        @NameInMap("type")
        public String type;

        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        public static GetInstancesResponseBodyDataActionExecutorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataActionExecutorName self = new GetInstancesResponseBodyDataActionExecutorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataActionExecutorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstancesResponseBodyDataActionExecutorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetInstancesResponseBodyDataActionExecutorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

    }

    public static class GetInstancesResponseBodyDataActionExecutor extends TeaModel {
        // name
        @NameInMap("name")
        public GetInstancesResponseBodyDataActionExecutorName name;

        // deptName
        @NameInMap("deptName")
        public String deptName;

        // userId
        @NameInMap("userId")
        public String userId;

        // email
        @NameInMap("email")
        public String email;

        public static GetInstancesResponseBodyDataActionExecutor build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataActionExecutor self = new GetInstancesResponseBodyDataActionExecutor();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataActionExecutor setName(GetInstancesResponseBodyDataActionExecutorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesResponseBodyDataActionExecutorName getName() {
            return this.name;
        }

        public GetInstancesResponseBodyDataActionExecutor setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstancesResponseBodyDataActionExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstancesResponseBodyDataActionExecutor setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

    public static class GetInstancesResponseBodyDataOriginatorName extends TeaModel {
        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // type
        @NameInMap("type")
        public String type;

        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        public static GetInstancesResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataOriginatorName self = new GetInstancesResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstancesResponseBodyDataOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetInstancesResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

    }

    public static class GetInstancesResponseBodyDataOriginator extends TeaModel {
        // name
        @NameInMap("name")
        public GetInstancesResponseBodyDataOriginatorName name;

        // deptName
        @NameInMap("deptName")
        public String deptName;

        // userId
        @NameInMap("userId")
        public String userId;

        // email
        @NameInMap("email")
        public String email;

        public static GetInstancesResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataOriginator self = new GetInstancesResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataOriginator setName(GetInstancesResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesResponseBodyDataOriginatorName getName() {
            return this.name;
        }

        public GetInstancesResponseBodyDataOriginator setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstancesResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstancesResponseBodyDataOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

    public static class GetInstancesResponseBodyData extends TeaModel {
        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // actioners
        @NameInMap("actionExecutor")
        public java.util.List<GetInstancesResponseBodyDataActionExecutor> actionExecutor;

        // approvedResult
        @NameInMap("approvedResult")
        public String approvedResult;

        // formUuid
        @NameInMap("formUuid")
        public String formUuid;

        // data
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        // processCode
        @NameInMap("processCode")
        public String processCode;

        // 修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // originator
        @NameInMap("originator")
        public GetInstancesResponseBodyDataOriginator originator;

        // title
        @NameInMap("title")
        public String title;

        // instanceStatus
        @NameInMap("instanceStatus")
        public String instanceStatus;

        // version
        @NameInMap("version")
        public Long version;

        public static GetInstancesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyData self = new GetInstancesResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetInstancesResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetInstancesResponseBodyData setActionExecutor(java.util.List<GetInstancesResponseBodyDataActionExecutor> actionExecutor) {
            this.actionExecutor = actionExecutor;
            return this;
        }
        public java.util.List<GetInstancesResponseBodyDataActionExecutor> getActionExecutor() {
            return this.actionExecutor;
        }

        public GetInstancesResponseBodyData setApprovedResult(String approvedResult) {
            this.approvedResult = approvedResult;
            return this;
        }
        public String getApprovedResult() {
            return this.approvedResult;
        }

        public GetInstancesResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetInstancesResponseBodyData setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public GetInstancesResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetInstancesResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetInstancesResponseBodyData setOriginator(GetInstancesResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public GetInstancesResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public GetInstancesResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetInstancesResponseBodyData setInstanceStatus(String instanceStatus) {
            this.instanceStatus = instanceStatus;
            return this;
        }
        public String getInstanceStatus() {
            return this.instanceStatus;
        }

        public GetInstancesResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
