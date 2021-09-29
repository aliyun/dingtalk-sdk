// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceByIdResponseBody extends TeaModel {
    // 创建时间
    @NameInMap("createTimeGMT")
    public String createTimeGMT;

    // processInstanceId
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // actionExecutor
    @NameInMap("actionExecutor")
    public java.util.List<GetInstanceByIdResponseBodyActionExecutor> actionExecutor;

    // approvedResult
    @NameInMap("approvedResult")
    public String approvedResult;

    // formUuid
    @NameInMap("formUuid")
    public String formUuid;

    // data
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    // 修改时间
    @NameInMap("modifiedTimeGMT")
    public String modifiedTimeGMT;

    // processCode
    @NameInMap("processCode")
    public String processCode;

    // originator
    @NameInMap("originator")
    public GetInstanceByIdResponseBodyOriginator originator;

    // title
    @NameInMap("title")
    public String title;

    // instanceStatus
    @NameInMap("instanceStatus")
    public String instanceStatus;

    // version
    @NameInMap("version")
    public Long version;

    public static GetInstanceByIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceByIdResponseBody self = new GetInstanceByIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstanceByIdResponseBody setCreateTimeGMT(String createTimeGMT) {
        this.createTimeGMT = createTimeGMT;
        return this;
    }
    public String getCreateTimeGMT() {
        return this.createTimeGMT;
    }

    public GetInstanceByIdResponseBody setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public GetInstanceByIdResponseBody setActionExecutor(java.util.List<GetInstanceByIdResponseBodyActionExecutor> actionExecutor) {
        this.actionExecutor = actionExecutor;
        return this;
    }
    public java.util.List<GetInstanceByIdResponseBodyActionExecutor> getActionExecutor() {
        return this.actionExecutor;
    }

    public GetInstanceByIdResponseBody setApprovedResult(String approvedResult) {
        this.approvedResult = approvedResult;
        return this;
    }
    public String getApprovedResult() {
        return this.approvedResult;
    }

    public GetInstanceByIdResponseBody setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetInstanceByIdResponseBody setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public GetInstanceByIdResponseBody setModifiedTimeGMT(String modifiedTimeGMT) {
        this.modifiedTimeGMT = modifiedTimeGMT;
        return this;
    }
    public String getModifiedTimeGMT() {
        return this.modifiedTimeGMT;
    }

    public GetInstanceByIdResponseBody setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public GetInstanceByIdResponseBody setOriginator(GetInstanceByIdResponseBodyOriginator originator) {
        this.originator = originator;
        return this;
    }
    public GetInstanceByIdResponseBodyOriginator getOriginator() {
        return this.originator;
    }

    public GetInstanceByIdResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetInstanceByIdResponseBody setInstanceStatus(String instanceStatus) {
        this.instanceStatus = instanceStatus;
        return this;
    }
    public String getInstanceStatus() {
        return this.instanceStatus;
    }

    public GetInstanceByIdResponseBody setVersion(Long version) {
        this.version = version;
        return this;
    }
    public Long getVersion() {
        return this.version;
    }

    public static class GetInstanceByIdResponseBodyActionExecutorName extends TeaModel {
        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // type
        @NameInMap("type")
        public String type;

        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        public static GetInstanceByIdResponseBodyActionExecutorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstanceByIdResponseBodyActionExecutorName self = new GetInstanceByIdResponseBodyActionExecutorName();
            return TeaModel.build(map, self);
        }

        public GetInstanceByIdResponseBodyActionExecutorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstanceByIdResponseBodyActionExecutorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetInstanceByIdResponseBodyActionExecutorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

    }

    public static class GetInstanceByIdResponseBodyActionExecutor extends TeaModel {
        // name
        @NameInMap("name")
        public GetInstanceByIdResponseBodyActionExecutorName name;

        // deptName
        @NameInMap("deptName")
        public String deptName;

        // userId
        @NameInMap("userId")
        public String userId;

        // email
        @NameInMap("email")
        public String email;

        public static GetInstanceByIdResponseBodyActionExecutor build(java.util.Map<String, ?> map) throws Exception {
            GetInstanceByIdResponseBodyActionExecutor self = new GetInstanceByIdResponseBodyActionExecutor();
            return TeaModel.build(map, self);
        }

        public GetInstanceByIdResponseBodyActionExecutor setName(GetInstanceByIdResponseBodyActionExecutorName name) {
            this.name = name;
            return this;
        }
        public GetInstanceByIdResponseBodyActionExecutorName getName() {
            return this.name;
        }

        public GetInstanceByIdResponseBodyActionExecutor setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstanceByIdResponseBodyActionExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstanceByIdResponseBodyActionExecutor setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

    public static class GetInstanceByIdResponseBodyOriginatorName extends TeaModel {
        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        // type
        @NameInMap("type")
        public String type;

        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        public static GetInstanceByIdResponseBodyOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstanceByIdResponseBodyOriginatorName self = new GetInstanceByIdResponseBodyOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetInstanceByIdResponseBodyOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetInstanceByIdResponseBodyOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetInstanceByIdResponseBodyOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

    }

    public static class GetInstanceByIdResponseBodyOriginator extends TeaModel {
        // name
        @NameInMap("name")
        public GetInstanceByIdResponseBodyOriginatorName name;

        // deptName
        @NameInMap("deptName")
        public String deptName;

        // userId
        @NameInMap("userId")
        public String userId;

        // email
        @NameInMap("email")
        public String email;

        public static GetInstanceByIdResponseBodyOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetInstanceByIdResponseBodyOriginator self = new GetInstanceByIdResponseBodyOriginator();
            return TeaModel.build(map, self);
        }

        public GetInstanceByIdResponseBodyOriginator setName(GetInstanceByIdResponseBodyOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetInstanceByIdResponseBodyOriginatorName getName() {
            return this.name;
        }

        public GetInstanceByIdResponseBodyOriginator setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstanceByIdResponseBodyOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetInstanceByIdResponseBodyOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

    }

}
