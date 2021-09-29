// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdListResponseBody extends TeaModel {
    // 流程实例列表
    @NameInMap("result")
    public java.util.List<GetInstancesByIdListResponseBodyResult> result;

    public static GetInstancesByIdListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdListResponseBody self = new GetInstancesByIdListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdListResponseBody setResult(java.util.List<GetInstancesByIdListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetInstancesByIdListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetInstancesByIdListResponseBodyResultActionExecutorName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // 国际化
        @NameInMap("type")
        public String type;

        public static GetInstancesByIdListResponseBodyResultActionExecutorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultActionExecutorName self = new GetInstancesByIdListResponseBodyResultActionExecutorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdListResponseBodyResultActionExecutorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetInstancesByIdListResponseBodyResultActionExecutor extends TeaModel {
        // 用户工号
        @NameInMap("userId")
        public String userId;

        // 用户名
        @NameInMap("name")
        public GetInstancesByIdListResponseBodyResultActionExecutorName name;

        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 邮箱
        @NameInMap("email")
        public String email;

        public static GetInstancesByIdListResponseBodyResultActionExecutor build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultActionExecutor self = new GetInstancesByIdListResponseBodyResultActionExecutor();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdListResponseBodyResultActionExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutor setName(GetInstancesByIdListResponseBodyResultActionExecutorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultActionExecutorName getName() {
            return this.name;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutor setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutor setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

    public static class GetInstancesByIdListResponseBodyResultOriginatorName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // 国际化
        @NameInMap("type")
        public String type;

        public static GetInstancesByIdListResponseBodyResultOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultOriginatorName self = new GetInstancesByIdListResponseBodyResultOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdListResponseBodyResultOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public GetInstancesByIdListResponseBodyResultOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstancesByIdListResponseBodyResultOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetInstancesByIdListResponseBodyResultOriginator extends TeaModel {
        // 用户工号
        @NameInMap("userId")
        public String userId;

        // 用户名
        @NameInMap("name")
        public GetInstancesByIdListResponseBodyResultOriginatorName name;

        // 部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 邮箱
        @NameInMap("email")
        public String email;

        public static GetInstancesByIdListResponseBodyResultOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultOriginator self = new GetInstancesByIdListResponseBodyResultOriginator();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdListResponseBodyResultOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstancesByIdListResponseBodyResultOriginator setName(GetInstancesByIdListResponseBodyResultOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultOriginatorName getName() {
            return this.name;
        }

        public GetInstancesByIdListResponseBodyResultOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetInstancesByIdListResponseBodyResultOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

    public static class GetInstancesByIdListResponseBodyResult extends TeaModel {
        // 流程实例当前任务执行人列表
        @NameInMap("actionExecutor")
        public java.util.List<GetInstancesByIdListResponseBodyResultActionExecutor> actionExecutor;

        // 实例ID
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 流程表单ID
        @NameInMap("formUuid")
        public String formUuid;

        // 流程Code
        @NameInMap("processCode")
        public String processCode;

        // 实例标题
        @NameInMap("title")
        public String title;

        // 实例状态
        @NameInMap("instanceStatus")
        public String instanceStatus;

        // 流程结束时的审批结论
        @NameInMap("approvedResult")
        public String approvedResult;

        // 发起人信息
        @NameInMap("originator")
        public GetInstancesByIdListResponseBodyResultOriginator originator;

        // 表单数据
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static GetInstancesByIdListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResult self = new GetInstancesByIdListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdListResponseBodyResult setActionExecutor(java.util.List<GetInstancesByIdListResponseBodyResultActionExecutor> actionExecutor) {
            this.actionExecutor = actionExecutor;
            return this;
        }
        public java.util.List<GetInstancesByIdListResponseBodyResultActionExecutor> getActionExecutor() {
            return this.actionExecutor;
        }

        public GetInstancesByIdListResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetInstancesByIdListResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetInstancesByIdListResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetInstancesByIdListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetInstancesByIdListResponseBodyResult setInstanceStatus(String instanceStatus) {
            this.instanceStatus = instanceStatus;
            return this;
        }
        public String getInstanceStatus() {
            return this.instanceStatus;
        }

        public GetInstancesByIdListResponseBodyResult setApprovedResult(String approvedResult) {
            this.approvedResult = approvedResult;
            return this;
        }
        public String getApprovedResult() {
            return this.approvedResult;
        }

        public GetInstancesByIdListResponseBodyResult setOriginator(GetInstancesByIdListResponseBodyResultOriginator originator) {
            this.originator = originator;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultOriginator getOriginator() {
            return this.originator;
        }

        public GetInstancesByIdListResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
