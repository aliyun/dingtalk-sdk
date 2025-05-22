// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BusinessEventUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("businessData")
    public java.util.Map<String, ?> businessData;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("eventType")
    public Integer eventType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("updateByKey")
    public Boolean updateByKey;

    public static BusinessEventUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        BusinessEventUpdateRequest self = new BusinessEventUpdateRequest();
        return TeaModel.build(map, self);
    }

    public BusinessEventUpdateRequest setBusinessData(java.util.Map<String, ?> businessData) {
        this.businessData = businessData;
        return this;
    }
    public java.util.Map<String, ?> getBusinessData() {
        return this.businessData;
    }

    public BusinessEventUpdateRequest setEventType(Integer eventType) {
        this.eventType = eventType;
        return this;
    }
    public Integer getEventType() {
        return this.eventType;
    }

    public BusinessEventUpdateRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public BusinessEventUpdateRequest setUpdateByKey(Boolean updateByKey) {
        this.updateByKey = updateByKey;
        return this;
    }
    public Boolean getUpdateByKey() {
        return this.updateByKey;
    }

}
