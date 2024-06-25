// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CloseTopboxRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("conversationType")
    public Integer conversationType;

    /**
     * <strong>example:</strong>
     * <p>COOLAPP-x-xxx</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <strong>example:</strong>
     * <p>6dx-xxx-xxx</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <strong>example:</strong>
     * <p>cidxxxxx==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123xxx</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <strong>example:</strong>
     * <p>jHsR7xxx</p>
     */
    @NameInMap("unoinId")
    public String unoinId;

    /**
     * <strong>example:</strong>
     * <p>011xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CloseTopboxRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseTopboxRequest self = new CloseTopboxRequest();
        return TeaModel.build(map, self);
    }

    public CloseTopboxRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public CloseTopboxRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public CloseTopboxRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CloseTopboxRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CloseTopboxRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CloseTopboxRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public CloseTopboxRequest setUnoinId(String unoinId) {
        this.unoinId = unoinId;
        return this;
    }
    public String getUnoinId() {
        return this.unoinId;
    }

    public CloseTopboxRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
