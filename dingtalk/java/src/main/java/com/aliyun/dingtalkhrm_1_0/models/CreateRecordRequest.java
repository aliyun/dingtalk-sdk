// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class CreateRecordRequest extends TeaModel {
    @NameInMap("attachmentList")
    public java.util.List<CreateRecordRequestAttachmentList> attachmentList;

    /**
     * <strong>example:</strong>
     * <p>908608088</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("fieldList")
    public java.util.List<CreateRecordRequestFieldList> fieldList;

    @NameInMap("groupList")
    public java.util.List<CreateRecordRequestGroupList> groupList;

    @NameInMap("outerId")
    public String outerId;

    /**
     * <strong>example:</strong>
     * <p>xxx员工劳动合同电子签署</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>xxx有限公司</p>
     */
    @NameInMap("signLastLegalEntityName")
    public String signLastLegalEntityName;

    /**
     * <strong>example:</strong>
     * <p>xxx有限公司</p>
     */
    @NameInMap("signLegalEntityName")
    public String signLegalEntityName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CONTRACT</p>
     */
    @NameInMap("signSource")
    public String signSource;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>48510731071405348944</p>
     */
    @NameInMap("signStartUserId")
    public String signStartUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>660658</p>
     */
    @NameInMap("signUserId")
    public String signUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>9ad11eb3daa24a9692037079e0732f13</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static CreateRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRecordRequest self = new CreateRecordRequest();
        return TeaModel.build(map, self);
    }

    public CreateRecordRequest setAttachmentList(java.util.List<CreateRecordRequestAttachmentList> attachmentList) {
        this.attachmentList = attachmentList;
        return this;
    }
    public java.util.List<CreateRecordRequestAttachmentList> getAttachmentList() {
        return this.attachmentList;
    }

    public CreateRecordRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CreateRecordRequest setFieldList(java.util.List<CreateRecordRequestFieldList> fieldList) {
        this.fieldList = fieldList;
        return this;
    }
    public java.util.List<CreateRecordRequestFieldList> getFieldList() {
        return this.fieldList;
    }

    public CreateRecordRequest setGroupList(java.util.List<CreateRecordRequestGroupList> groupList) {
        this.groupList = groupList;
        return this;
    }
    public java.util.List<CreateRecordRequestGroupList> getGroupList() {
        return this.groupList;
    }

    public CreateRecordRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

    public CreateRecordRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreateRecordRequest setSignLastLegalEntityName(String signLastLegalEntityName) {
        this.signLastLegalEntityName = signLastLegalEntityName;
        return this;
    }
    public String getSignLastLegalEntityName() {
        return this.signLastLegalEntityName;
    }

    public CreateRecordRequest setSignLegalEntityName(String signLegalEntityName) {
        this.signLegalEntityName = signLegalEntityName;
        return this;
    }
    public String getSignLegalEntityName() {
        return this.signLegalEntityName;
    }

    public CreateRecordRequest setSignSource(String signSource) {
        this.signSource = signSource;
        return this;
    }
    public String getSignSource() {
        return this.signSource;
    }

    public CreateRecordRequest setSignStartUserId(String signStartUserId) {
        this.signStartUserId = signStartUserId;
        return this;
    }
    public String getSignStartUserId() {
        return this.signStartUserId;
    }

    public CreateRecordRequest setSignUserId(String signUserId) {
        this.signUserId = signUserId;
        return this;
    }
    public String getSignUserId() {
        return this.signUserId;
    }

    public CreateRecordRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public static class CreateRecordRequestAttachmentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>attachment_profile</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>简历附件</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>DDAttachmentField</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <strong>example:</strong>
         * <p><a href="https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf">https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf</a></p>
         */
        @NameInMap("fieldValue")
        public String fieldValue;

        /**
         * <strong>example:</strong>
         * <p>attachment</p>
         */
        @NameInMap("groupId")
        public String groupId;

        public static CreateRecordRequestAttachmentList build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordRequestAttachmentList self = new CreateRecordRequestAttachmentList();
            return TeaModel.build(map, self);
        }

        public CreateRecordRequestAttachmentList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public CreateRecordRequestAttachmentList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public CreateRecordRequestAttachmentList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateRecordRequestAttachmentList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public CreateRecordRequestAttachmentList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

    }

    public static class CreateRecordRequestFieldList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>contract.contract_type</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>合同类型</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>DDSelectField</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <strong>example:</strong>
         * <p>劳动合同</p>
         */
        @NameInMap("fieldValue")
        public String fieldValue;

        /**
         * <strong>example:</strong>
         * <p>contract</p>
         */
        @NameInMap("groupId")
        public String groupId;

        /**
         * <strong>example:</strong>
         * <p>劳动合同</p>
         */
        @NameInMap("optionId")
        public String optionId;

        /**
         * <strong>example:</strong>
         * <p>[{&quot;label&quot;:&quot;劳动合同&quot;,&quot;value&quot;:&quot;劳动合同&quot;},{&quot;label&quot;:&quot;保密协议&quot;,&quot;value&quot;:&quot;保密协议&quot;}]</p>
         */
        @NameInMap("options")
        public String options;

        @NameInMap("signRequired")
        public Boolean signRequired;

        @NameInMap("userCustomField")
        public Boolean userCustomField;

        public static CreateRecordRequestFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordRequestFieldList self = new CreateRecordRequestFieldList();
            return TeaModel.build(map, self);
        }

        public CreateRecordRequestFieldList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public CreateRecordRequestFieldList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public CreateRecordRequestFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateRecordRequestFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public CreateRecordRequestFieldList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public CreateRecordRequestFieldList setOptionId(String optionId) {
            this.optionId = optionId;
            return this;
        }
        public String getOptionId() {
            return this.optionId;
        }

        public CreateRecordRequestFieldList setOptions(String options) {
            this.options = options;
            return this;
        }
        public String getOptions() {
            return this.options;
        }

        public CreateRecordRequestFieldList setSignRequired(Boolean signRequired) {
            this.signRequired = signRequired;
            return this;
        }
        public Boolean getSignRequired() {
            return this.signRequired;
        }

        public CreateRecordRequestFieldList setUserCustomField(Boolean userCustomField) {
            this.userCustomField = userCustomField;
            return this;
        }
        public Boolean getUserCustomField() {
            return this.userCustomField;
        }

    }

    public static class CreateRecordRequestGroupListFieldList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>contract.contract_type</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>合同类型</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>DDSelectField</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <strong>example:</strong>
         * <p>劳动合同</p>
         */
        @NameInMap("fieldValue")
        public String fieldValue;

        /**
         * <strong>example:</strong>
         * <p>[{&quot;label&quot;:&quot;劳动合同&quot;,&quot;value&quot;:&quot;劳动合同&quot;},{&quot;label&quot;:&quot;培训协议&quot;,&quot;value&quot;:&quot;培训协议&quot;}]</p>
         */
        @NameInMap("options")
        public String options;

        /**
         * <strong>example:</strong>
         * <p>劳动合同</p>
         */
        @NameInMap("optionId")
        public String optionId;

        /**
         * <strong>example:</strong>
         * <p>contract</p>
         */
        @NameInMap("groupId")
        public String groupId;

        public static CreateRecordRequestGroupListFieldList build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordRequestGroupListFieldList self = new CreateRecordRequestGroupListFieldList();
            return TeaModel.build(map, self);
        }

        public CreateRecordRequestGroupListFieldList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public CreateRecordRequestGroupListFieldList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public CreateRecordRequestGroupListFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public CreateRecordRequestGroupListFieldList setFieldValue(String fieldValue) {
            this.fieldValue = fieldValue;
            return this;
        }
        public String getFieldValue() {
            return this.fieldValue;
        }

        public CreateRecordRequestGroupListFieldList setOptions(String options) {
            this.options = options;
            return this;
        }
        public String getOptions() {
            return this.options;
        }

        public CreateRecordRequestGroupListFieldList setOptionId(String optionId) {
            this.optionId = optionId;
            return this;
        }
        public String getOptionId() {
            return this.optionId;
        }

        public CreateRecordRequestGroupListFieldList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

    }

    public static class CreateRecordRequestGroupList extends TeaModel {
        @NameInMap("detailFlag")
        public Boolean detailFlag;

        @NameInMap("fieldList")
        public java.util.List<java.util.List<CreateRecordRequestGroupListFieldList>> fieldList;

        /**
         * <strong>example:</strong>
         * <p>family</p>
         */
        @NameInMap("groupId")
        public String groupId;

        /**
         * <strong>example:</strong>
         * <p>家庭成员</p>
         */
        @NameInMap("groupName")
        public String groupName;

        public static CreateRecordRequestGroupList build(java.util.Map<String, ?> map) throws Exception {
            CreateRecordRequestGroupList self = new CreateRecordRequestGroupList();
            return TeaModel.build(map, self);
        }

        public CreateRecordRequestGroupList setDetailFlag(Boolean detailFlag) {
            this.detailFlag = detailFlag;
            return this;
        }
        public Boolean getDetailFlag() {
            return this.detailFlag;
        }

        public CreateRecordRequestGroupList setFieldList(java.util.List<java.util.List<CreateRecordRequestGroupListFieldList>> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<java.util.List<CreateRecordRequestGroupListFieldList>> getFieldList() {
            return this.fieldList;
        }

        public CreateRecordRequestGroupList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public CreateRecordRequestGroupList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
