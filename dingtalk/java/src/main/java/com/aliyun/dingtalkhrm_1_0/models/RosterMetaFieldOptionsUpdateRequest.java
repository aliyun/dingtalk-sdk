// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaFieldOptionsUpdateRequest extends TeaModel {
    @NameInMap("appAgentId")
    public Long appAgentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fieldCode")
    public String fieldCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupId")
    public String groupId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("labels")
    public java.util.List<String> labels;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modifyType")
    public String modifyType;

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

    public RosterMetaFieldOptionsUpdateRequest setFieldCode(String fieldCode) {
        this.fieldCode = fieldCode;
        return this;
    }
    public String getFieldCode() {
        return this.fieldCode;
    }

    public RosterMetaFieldOptionsUpdateRequest setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public RosterMetaFieldOptionsUpdateRequest setLabels(java.util.List<String> labels) {
        this.labels = labels;
        return this;
    }
    public java.util.List<String> getLabels() {
        return this.labels;
    }

    public RosterMetaFieldOptionsUpdateRequest setModifyType(String modifyType) {
        this.modifyType = modifyType;
        return this;
    }
    public String getModifyType() {
        return this.modifyType;
    }

}
