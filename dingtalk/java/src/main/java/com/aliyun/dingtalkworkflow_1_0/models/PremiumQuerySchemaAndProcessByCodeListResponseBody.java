// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumQuerySchemaAndProcessByCodeListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PremiumQuerySchemaAndProcessByCodeListResponseBodyResult> result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumQuerySchemaAndProcessByCodeListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumQuerySchemaAndProcessByCodeListResponseBody self = new PremiumQuerySchemaAndProcessByCodeListResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumQuerySchemaAndProcessByCodeListResponseBody setResult(java.util.List<PremiumQuerySchemaAndProcessByCodeListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PremiumQuerySchemaAndProcessByCodeListResponseBodyResult> getResult() {
        return this.result;
    }

    public PremiumQuerySchemaAndProcessByCodeListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumQuerySchemaAndProcessByCodeListResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ding123</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <strong>example:</strong>
         * <p>hrm.xxx</p>
         */
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        /**
         * <strong>example:</strong>
         * <p>1638326995000</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>userId123</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <strong>example:</strong>
         * <p>https//:xxx</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>模板描述1</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <strong>example:</strong>
         * <p>userId123</p>
         */
        @NameInMap("modifierUserId")
        public String modifierUserId;

        /**
         * <strong>example:</strong>
         * <p>1638326995000</p>
         */
        @NameInMap("modifyTime")
        public Long modifyTime;

        /**
         * <strong>example:</strong>
         * <p>示例模板</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>PROC-17428B8C-6C60-470E-xxxx-64F1037AE067</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p>{&quot;name&quot;:&quot;发起人&quot;,&quot;type&quot;:&quot;start&quot;,&quot;nodeId&quot;:&quot;sid-startevent&quot;,&quot;childNode&quot;:{&quot;name&quot;:&quot;审批人&quot;,&quot;prevId&quot;:&quot;sid-startevent&quot;,&quot;type&quot;:&quot;approver&quot;,&quot;nodeId&quot;:&quot;sid-1234_5678&quot;,&quot;properties&quot;:{&quot;activateType&quot;:&quot;ONE_BY_ONE&quot;,&quot;approvalType&quot;:&quot;MANUAL&quot;,&quot;actionerRules&quot;:[{&quot;select&quot;:[&quot;allStaff&quot;],&quot;range&quot;:{&quot;approvals&quot;:[],&quot;labels&quot;:[]},&quot;type&quot;:&quot;target_select&quot;,&quot;key&quot;:&quot;manual_sid-1234_5678_30a8_b373&quot;,&quot;multi&quot;:1}],&quot;agreeAll&quot;:false},&quot;childNode&quot;:{&quot;name&quot;:&quot;抄送人&quot;,&quot;prevId&quot;:&quot;sid-1234_5678&quot;,&quot;type&quot;:&quot;notifier&quot;,&quot;nodeId&quot;:&quot;9955_7e43&quot;,&quot;properties&quot;:{&quot;actionerRules&quot;:[{&quot;select&quot;:[&quot;allStaff&quot;],&quot;range&quot;:{},&quot;type&quot;:&quot;target_select&quot;,&quot;key&quot;:&quot;manual_9955_7e43_0c96_39d8&quot;,&quot;multi&quot;:1}]}}}}</p>
         */
        @NameInMap("processConfig")
        public String processConfig;

        @NameInMap("processId")
        public Long processId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;commentHiddenForProposer&quot;:&quot;&quot;,&quot;commentRequired&quot;:&quot;&quot;,&quot;icon&quot;:&quot;timefades#red&quot;,&quot;commentDescription&quot;:&quot;&quot;,&quot;description&quot;:&quot;支持地址控件&quot;,&quot;title&quot;:&quot;官方OA审批-POP-2025-0109&quot;,&quot;items&quot;:[{&quot;componentName&quot;:&quot;TimeAndLocationField&quot;,&quot;props&quot;:{&quot;label&quot;:[&quot;当前时间&quot;,&quot;当前地点&quot;],&quot;id&quot;:&quot;TimeAndLocationField_1CVHM5TIIWR9C&quot;,&quot;required&quot;:false}},{&quot;componentName&quot;:&quot;TextField&quot;,&quot;props&quot;:{&quot;placeholder&quot;:&quot;请输入&quot;,&quot;label&quot;:&quot;单行输入框&quot;,&quot;id&quot;:&quot;TextField_17EZKEGSOCTC0&quot;,&quot;required&quot;:false}}]}</p>
         */
        @NameInMap("schemaContent")
        public String schemaContent;

        /**
         * <strong>example:</strong>
         * <p>PUBLISHED</p>
         */
        @NameInMap("status")
        public String status;

        public static PremiumQuerySchemaAndProcessByCodeListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumQuerySchemaAndProcessByCodeListResponseBodyResult self = new PremiumQuerySchemaAndProcessByCodeListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setModifierUserId(String modifierUserId) {
            this.modifierUserId = modifierUserId;
            return this;
        }
        public String getModifierUserId() {
            return this.modifierUserId;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setModifyTime(Long modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public Long getModifyTime() {
            return this.modifyTime;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setProcessConfig(String processConfig) {
            this.processConfig = processConfig;
            return this;
        }
        public String getProcessConfig() {
            return this.processConfig;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setSchemaContent(String schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public String getSchemaContent() {
            return this.schemaContent;
        }

        public PremiumQuerySchemaAndProcessByCodeListResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
