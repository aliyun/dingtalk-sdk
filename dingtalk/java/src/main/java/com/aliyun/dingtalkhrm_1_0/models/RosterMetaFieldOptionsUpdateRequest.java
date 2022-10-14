// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaFieldOptionsUpdateRequest extends TeaModel {
    @NameInMap("appAgentId")
    public Long appAgentId;

    @NameInMap("body")
    public RosterMetaFieldOptionsUpdateRequestBody body;

    public static RosterMetaFieldOptionsUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaFieldOptionsUpdateRequest self = new RosterMetaFieldOptionsUpdateRequest();
        return TeaModel.build(map, self);
    }

    public RosterMetaFieldOptionsUpdateRequest setAppAgentId(Long appAgentId) {
        this.appAgentId = appAgentId;
        return this;
    }
    public Long getAppAgentId() {
        return this.appAgentId;
    }

    public RosterMetaFieldOptionsUpdateRequest setBody(RosterMetaFieldOptionsUpdateRequestBody body) {
        this.body = body;
        return this;
    }
    public RosterMetaFieldOptionsUpdateRequestBody getBody() {
        return this.body;
    }

    public static class RosterMetaFieldOptionsUpdateRequestBody extends TeaModel {
        // 字段fieldCode
        @NameInMap("fieldCode")
        public String fieldCode;

        // 花名册分组id
        @NameInMap("groupId")
        public String groupId;

        // 需要修改的选项值
        @NameInMap("labels")
        public java.util.List<String> labels;

        // 修改类型，OPTIONS_ADD选项添加，OPTIONS_DELETE选项删除
        @NameInMap("modifyType")
        public String modifyType;

        public static RosterMetaFieldOptionsUpdateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            RosterMetaFieldOptionsUpdateRequestBody self = new RosterMetaFieldOptionsUpdateRequestBody();
            return TeaModel.build(map, self);
        }

        public RosterMetaFieldOptionsUpdateRequestBody setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public RosterMetaFieldOptionsUpdateRequestBody setGroupId(String groupId) {
            this.groupId = groupId;
            return this;
        }
        public String getGroupId() {
            return this.groupId;
        }

        public RosterMetaFieldOptionsUpdateRequestBody setLabels(java.util.List<String> labels) {
            this.labels = labels;
            return this;
        }
        public java.util.List<String> getLabels() {
            return this.labels;
        }

        public RosterMetaFieldOptionsUpdateRequestBody setModifyType(String modifyType) {
            this.modifyType = modifyType;
            return this;
        }
        public String getModifyType() {
            return this.modifyType;
        }

    }

}
