// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<GetInstancesResponseBodyData> data;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesResponseBody self = new GetInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstancesResponseBody setData(java.util.List<GetInstancesResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetInstancesResponseBodyData> getData() {
        return this.data;
    }

    public GetInstancesResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetInstancesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetInstancesResponseBodyDataActionExecutorName extends TeaModel {
        /**
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <p>type</p>
         */
        @NameInMap("type")
        public String type;

        public static GetInstancesResponseBodyDataActionExecutorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataActionExecutorName self = new GetInstancesResponseBodyDataActionExecutorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataActionExecutorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
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

    }

    public static class GetInstancesResponseBodyDataActionExecutor extends TeaModel {
        /**
         * <p>deptName</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>email</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>name</p>
         */
        @NameInMap("name")
        public GetInstancesResponseBodyDataActionExecutorName name;

        /**
         * <p>userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetInstancesResponseBodyDataActionExecutor build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataActionExecutor self = new GetInstancesResponseBodyDataActionExecutor();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataActionExecutor setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstancesResponseBodyDataActionExecutor setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetInstancesResponseBodyDataActionExecutor setName(GetInstancesResponseBodyDataActionExecutorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesResponseBodyDataActionExecutorName getName() {
            return this.name;
        }

        public GetInstancesResponseBodyDataActionExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetInstancesResponseBodyDataOriginatorName extends TeaModel {
        /**
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <p>type</p>
         */
        @NameInMap("type")
        public String type;

        public static GetInstancesResponseBodyDataOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataOriginatorName self = new GetInstancesResponseBodyDataOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
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

    }

    public static class GetInstancesResponseBodyDataOriginator extends TeaModel {
        /**
         * <p>deptName</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>email</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>name</p>
         */
        @NameInMap("name")
        public GetInstancesResponseBodyDataOriginatorName name;

        /**
         * <p>userId</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetInstancesResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyDataOriginator self = new GetInstancesResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public GetInstancesResponseBodyDataOriginator setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetInstancesResponseBodyDataOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetInstancesResponseBodyDataOriginator setName(GetInstancesResponseBodyDataOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesResponseBodyDataOriginatorName getName() {
            return this.name;
        }

        public GetInstancesResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetInstancesResponseBodyData extends TeaModel {
        /**
         * <p>actioners</p>
         */
        @NameInMap("actionExecutor")
        public java.util.List<GetInstancesResponseBodyDataActionExecutor> actionExecutor;

        /**
         * <p>approvedResult</p>
         */
        @NameInMap("approvedResult")
        public String approvedResult;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <p>data</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>formUuid</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>instanceStatus</p>
         */
        @NameInMap("instanceStatus")
        public String instanceStatus;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <p>originator</p>
         */
        @NameInMap("originator")
        public GetInstancesResponseBodyDataOriginator originator;

        /**
         * <p>processCode</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>processInstanceId</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>version</p>
         */
        @NameInMap("version")
        public Long version;

        public static GetInstancesResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesResponseBodyData self = new GetInstancesResponseBodyData();
            return TeaModel.build(map, self);
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

        public GetInstancesResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetInstancesResponseBodyData setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public GetInstancesResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetInstancesResponseBodyData setInstanceStatus(String instanceStatus) {
            this.instanceStatus = instanceStatus;
            return this;
        }
        public String getInstanceStatus() {
            return this.instanceStatus;
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

        public GetInstancesResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetInstancesResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetInstancesResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
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
