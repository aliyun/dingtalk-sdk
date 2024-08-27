// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetFileTemplateListResponseBody extends TeaModel {
    @NameInMap("result")
    public GetFileTemplateListResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetFileTemplateListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileTemplateListResponseBody self = new GetFileTemplateListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileTemplateListResponseBody setResult(GetFileTemplateListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFileTemplateListResponseBodyResult getResult() {
        return this.result;
    }

    public GetFileTemplateListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFileTemplateListResponseBodyResultDataAttachmentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>简历附件</p>
         */
        @NameInMap("desc")
        public String desc;

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
         * <p>attachment</p>
         */
        @NameInMap("groupId")
        public String groupId;

        @NameInMap("signRequired")
        public Boolean signRequired;

        @NameInMap("userCustomField")
        public Boolean userCustomField;

        public static GetFileTemplateListResponseBodyResultDataAttachmentList build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResultDataAttachmentList self = new GetFileTemplateListResponseBodyResultDataAttachmentList();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setSignRequired(Boolean signRequired) {
            this.signRequired = signRequired;
            return this;
        }
        public Boolean getSignRequired() {
            return this.signRequired;
        }

        public GetFileTemplateListResponseBodyResultDataAttachmentList setUserCustomField(Boolean userCustomField) {
            this.userCustomField = userCustomField;
            return this;
        }
        public Boolean getUserCustomField() {
            return this.userCustomField;
        }

    }

    public static class GetFileTemplateListResponseBodyResultDataFieldList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>真实姓名字段</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>esign_name</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>真实姓名</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>TextField</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <strong>example:</strong>
         * <p>baseInfo</p>
         */
        @NameInMap("groupId")
        public String groupId;

        @NameInMap("signRequired")
        public Boolean signRequired;

        @NameInMap("userCustomField")
        public Boolean userCustomField;

        public static GetFileTemplateListResponseBodyResultDataFieldList build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResultDataFieldList self = new GetFileTemplateListResponseBodyResultDataFieldList();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setSignRequired(Boolean signRequired) {
            this.signRequired = signRequired;
            return this;
        }
        public Boolean getSignRequired() {
            return this.signRequired;
        }

        public GetFileTemplateListResponseBodyResultDataFieldList setUserCustomField(Boolean userCustomField) {
            this.userCustomField = userCustomField;
            return this;
        }
        public Boolean getUserCustomField() {
            return this.userCustomField;
        }

    }

    public static class GetFileTemplateListResponseBodyResultDataGroupListFieldList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>家庭成员明细分组</p>
         */
        @NameInMap("desc")
        public String desc;

        /**
         * <strong>example:</strong>
         * <p>family.member_name</p>
         */
        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>成员姓名</p>
         */
        @NameInMap("fieldName")
        public String fieldName;

        /**
         * <strong>example:</strong>
         * <p>TextField</p>
         */
        @NameInMap("fieldType")
        public String fieldType;

        /**
         * <strong>example:</strong>
         * <p>family</p>
         */
        @NameInMap("groupId")
        public String groupId;

        @NameInMap("signRequired")
        public Boolean signRequired;

        @NameInMap("userCustomField")
        public Boolean userCustomField;

        public static GetFileTemplateListResponseBodyResultDataGroupListFieldList build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResultDataGroupListFieldList self = new GetFileTemplateListResponseBodyResultDataGroupListFieldList();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setFieldName(String fieldName) {
            this.fieldName = fieldName;
            return this;
        }
        public String getFieldName() {
            return this.fieldName;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setFieldType(String fieldType) {
            this.fieldType = fieldType;
            return this;
        }
        public String getFieldType() {
            return this.fieldType;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setSignRequired(Boolean signRequired) {
            this.signRequired = signRequired;
            return this;
        }
        public Boolean getSignRequired() {
            return this.signRequired;
        }

        public GetFileTemplateListResponseBodyResultDataGroupListFieldList setUserCustomField(Boolean userCustomField) {
            this.userCustomField = userCustomField;
            return this;
        }
        public Boolean getUserCustomField() {
            return this.userCustomField;
        }

    }

    public static class GetFileTemplateListResponseBodyResultDataGroupList extends TeaModel {
        @NameInMap("detailFlag")
        public Boolean detailFlag;

        @NameInMap("fieldList")
        public java.util.List<GetFileTemplateListResponseBodyResultDataGroupListFieldList> fieldList;

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

        public static GetFileTemplateListResponseBodyResultDataGroupList build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResultDataGroupList self = new GetFileTemplateListResponseBodyResultDataGroupList();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResultDataGroupList setDetailFlag(Boolean detailFlag) {
            this.detailFlag = detailFlag;
            return this;
        }
        public Boolean getDetailFlag() {
            return this.detailFlag;
        }

        public GetFileTemplateListResponseBodyResultDataGroupList setFieldList(java.util.List<GetFileTemplateListResponseBodyResultDataGroupListFieldList> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<GetFileTemplateListResponseBodyResultDataGroupListFieldList> getFieldList() {
            return this.fieldList;
        }

        public GetFileTemplateListResponseBodyResultDataGroupList setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public GetFileTemplateListResponseBodyResultDataGroupList setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

    public static class GetFileTemplateListResponseBodyResultData extends TeaModel {
        @NameInMap("attachmentList")
        public java.util.List<GetFileTemplateListResponseBodyResultDataAttachmentList> attachmentList;

        /**
         * <strong>example:</strong>
         * <p>ding57935b18bfd13e9735c2f4657eb6378f</p>
         */
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("fieldList")
        public java.util.List<GetFileTemplateListResponseBodyResultDataFieldList> fieldList;

        @NameInMap("groupList")
        public java.util.List<GetFileTemplateListResponseBodyResultDataGroupList> groupList;

        /**
         * <strong>example:</strong>
         * <p>f3ed5402e3024febaed773b3ac19feb3</p>
         */
        @NameInMap("templateId")
        public String templateId;

        @NameInMap("templateInstName")
        public String templateInstName;

        /**
         * <strong>example:</strong>
         * <p>劳动合同模板</p>
         */
        @NameInMap("templateName")
        public String templateName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("templateSignStatus")
        public Integer templateSignStatus;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("templateStatus")
        public Integer templateStatus;

        /**
         * <strong>example:</strong>
         * <p>CONTRACT</p>
         */
        @NameInMap("templateType")
        public String templateType;

        /**
         * <strong>example:</strong>
         * <p>合同模板</p>
         */
        @NameInMap("templateTypeName")
        public String templateTypeName;

        /**
         * <strong>example:</strong>
         * <p>24</p>
         */
        @NameInMap("tenantId")
        public Long tenantId;

        public static GetFileTemplateListResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResultData self = new GetFileTemplateListResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResultData setAttachmentList(java.util.List<GetFileTemplateListResponseBodyResultDataAttachmentList> attachmentList) {
            this.attachmentList = attachmentList;
            return this;
        }
        public java.util.List<GetFileTemplateListResponseBodyResultDataAttachmentList> getAttachmentList() {
            return this.attachmentList;
        }

        public GetFileTemplateListResponseBodyResultData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetFileTemplateListResponseBodyResultData setFieldList(java.util.List<GetFileTemplateListResponseBodyResultDataFieldList> fieldList) {
            this.fieldList = fieldList;
            return this;
        }
        public java.util.List<GetFileTemplateListResponseBodyResultDataFieldList> getFieldList() {
            return this.fieldList;
        }

        public GetFileTemplateListResponseBodyResultData setGroupList(java.util.List<GetFileTemplateListResponseBodyResultDataGroupList> groupList) {
            this.groupList = groupList;
            return this;
        }
        public java.util.List<GetFileTemplateListResponseBodyResultDataGroupList> getGroupList() {
            return this.groupList;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateInstName(String templateInstName) {
            this.templateInstName = templateInstName;
            return this;
        }
        public String getTemplateInstName() {
            return this.templateInstName;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateSignStatus(Integer templateSignStatus) {
            this.templateSignStatus = templateSignStatus;
            return this;
        }
        public Integer getTemplateSignStatus() {
            return this.templateSignStatus;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateStatus(Integer templateStatus) {
            this.templateStatus = templateStatus;
            return this;
        }
        public Integer getTemplateStatus() {
            return this.templateStatus;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateType(String templateType) {
            this.templateType = templateType;
            return this;
        }
        public String getTemplateType() {
            return this.templateType;
        }

        public GetFileTemplateListResponseBodyResultData setTemplateTypeName(String templateTypeName) {
            this.templateTypeName = templateTypeName;
            return this;
        }
        public String getTemplateTypeName() {
            return this.templateTypeName;
        }

        public GetFileTemplateListResponseBodyResultData setTenantId(Long tenantId) {
            this.tenantId = tenantId;
            return this;
        }
        public Long getTenantId() {
            return this.tenantId;
        }

    }

    public static class GetFileTemplateListResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<GetFileTemplateListResponseBodyResultData> data;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public Long nextToken;

        public static GetFileTemplateListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFileTemplateListResponseBodyResult self = new GetFileTemplateListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFileTemplateListResponseBodyResult setData(java.util.List<GetFileTemplateListResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<GetFileTemplateListResponseBodyResultData> getData() {
            return this.data;
        }

        public GetFileTemplateListResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetFileTemplateListResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
