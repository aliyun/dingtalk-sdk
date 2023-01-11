// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCommonEventRequest extends TeaModel {
    /**
     * <p>add 创建事件/update 更新事件</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>应用appkey</p>
     */
    @NameInMap("appKey")
    public String appKey;

    @NameInMap("bizData")
    public java.util.Map<String, ?> bizData;

    /**
     * <p>事件集合，目前仅1个有效</p>
     */
    @NameInMap("eventType")
    public java.util.List<String> eventType;

    public static IndustryManufactureCommonEventRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCommonEventRequest self = new IndustryManufactureCommonEventRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCommonEventRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureCommonEventRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureCommonEventRequest setBizData(java.util.Map<String, ?> bizData) {
        this.bizData = bizData;
        return this;
    }
    public java.util.Map<String, ?> getBizData() {
        return this.bizData;
    }

    public IndustryManufactureCommonEventRequest setEventType(java.util.List<String> eventType) {
        this.eventType = eventType;
        return this;
    }
    public java.util.List<String> getEventType() {
        return this.eventType;
    }

}
