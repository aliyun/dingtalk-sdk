// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotSendDingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1:APP，2:短信，3:电话</p>
     */
    @NameInMap("remindType")
    public Integer remindType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static RobotSendDingRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotSendDingRequest self = new RobotSendDingRequest();
        return TeaModel.build(map, self);
    }

    public RobotSendDingRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public RobotSendDingRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public RobotSendDingRequest setRemindType(Integer remindType) {
        this.remindType = remindType;
        return this;
    }
    public Integer getRemindType() {
        return this.remindType;
    }

    public RobotSendDingRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
