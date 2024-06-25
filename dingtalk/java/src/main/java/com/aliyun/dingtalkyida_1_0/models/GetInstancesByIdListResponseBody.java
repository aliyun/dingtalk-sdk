// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdListResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("email")
        public String email;

        @NameInMap("name")
        public GetInstancesByIdListResponseBodyResultActionExecutorName name;

        @NameInMap("userId")
        public String userId;

        public static GetInstancesByIdListResponseBodyResultActionExecutor build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultActionExecutor self = new GetInstancesByIdListResponseBodyResultActionExecutor();
            return TeaModel.build(map, self);
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

        public GetInstancesByIdListResponseBodyResultActionExecutor setName(GetInstancesByIdListResponseBodyResultActionExecutorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultActionExecutorName getName() {
            return this.name;
        }

        public GetInstancesByIdListResponseBodyResultActionExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetInstancesByIdListResponseBodyResultOriginatorName extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>开发部</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("email")
        public String email;

        @NameInMap("name")
        public GetInstancesByIdListResponseBodyResultOriginatorName name;

        @NameInMap("userId")
        public String userId;

        public static GetInstancesByIdListResponseBodyResultOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdListResponseBodyResultOriginator self = new GetInstancesByIdListResponseBodyResultOriginator();
            return TeaModel.build(map, self);
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

        public GetInstancesByIdListResponseBodyResultOriginator setName(GetInstancesByIdListResponseBodyResultOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultOriginatorName getName() {
            return this.name;
        }

        public GetInstancesByIdListResponseBodyResultOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetInstancesByIdListResponseBodyResult extends TeaModel {
        @NameInMap("actionExecutor")
        public java.util.List<GetInstancesByIdListResponseBodyResultActionExecutor> actionExecutor;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("approvedResult")
        public String approvedResult;

        /**
         * <strong>example:</strong>
         * <p>{&quot;numberField_jcr0069o&quot;:1,&quot;multiSelectField_jcr0069s&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;employeeField_jcr0069x&quot;:[&quot;xxxx&quot;],&quot;departmentField_jcr0069z&quot;:&quot;信息xxx平台&quot;,&quot;cascadeDate_jcr0069u&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:[{&quot;departmentField_jcr006ad&quot;:&quot;信息xxx&quot;,&quot;cascadeDate_jcr006aa&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;selectField_jcr006a6&quot;:&quot;选项三&quot;,&quot;citySelectField_jcr006ac&quot;:[&quot;天津&quot;,&quot;天津市&quot;,&quot;河东区&quot;],&quot;radioField_jcr006a5&quot;:&quot;选项二&quot;,&quot;employeeField_jcr006ab&quot;:[&quot;yyyyy&quot;,&quot;xxxxxx&quot;],&quot;dateField_jcr006a9&quot;:1517328000000,&quot;textField_jcr006a2&quot;:&quot;明细下单行&quot;,&quot;textareaField_jcr006a3&quot;:&quot;明细下多行&quot;,&quot;cascadeSelectField_jcr006ae&quot;:[&quot;product&quot;,&quot;product_a&quot;],&quot;numberField_jcr006a4&quot;:2,&quot;checkboxField_jcr006a7&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;],&quot;multiSelectField_jcr006a8&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;]}],&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;citySelectField_jcr0069y&quot;:[&quot;北京&quot;,&quot;北京市&quot;,&quot;东城区&quot;],&quot;checkboxField_jcr0069r&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;dateField_jcr0069t&quot;:1516636800000}</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <strong>example:</strong>
         * <p>FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <strong>example:</strong>
         * <p>RUNNING</p>
         */
        @NameInMap("instanceStatus")
        public String instanceStatus;

        @NameInMap("originator")
        public GetInstancesByIdListResponseBodyResultOriginator originator;

        /**
         * <strong>example:</strong>
         * <p>TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>xxxx 发起的流程</p>
         */
        @NameInMap("title")
        public String title;

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

        public GetInstancesByIdListResponseBodyResult setApprovedResult(String approvedResult) {
            this.approvedResult = approvedResult;
            return this;
        }
        public String getApprovedResult() {
            return this.approvedResult;
        }

        public GetInstancesByIdListResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public GetInstancesByIdListResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetInstancesByIdListResponseBodyResult setInstanceStatus(String instanceStatus) {
            this.instanceStatus = instanceStatus;
            return this;
        }
        public String getInstanceStatus() {
            return this.instanceStatus;
        }

        public GetInstancesByIdListResponseBodyResult setOriginator(GetInstancesByIdListResponseBodyResultOriginator originator) {
            this.originator = originator;
            return this;
        }
        public GetInstancesByIdListResponseBodyResultOriginator getOriginator() {
            return this.originator;
        }

        public GetInstancesByIdListResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetInstancesByIdListResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetInstancesByIdListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
