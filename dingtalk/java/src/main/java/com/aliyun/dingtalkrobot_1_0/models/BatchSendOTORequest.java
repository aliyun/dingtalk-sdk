// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOTORequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleMarkdown</p>
     */
    @NameInMap("msgKey")
    public String msgKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;text&quot;: &quot;hello dafu&quot;,&quot;title&quot;: &quot;hello title&quot;}</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxx</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static BatchSendOTORequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOTORequest self = new BatchSendOTORequest();
        return TeaModel.build(map, self);
    }

    public BatchSendOTORequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public BatchSendOTORequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public BatchSendOTORequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public BatchSendOTORequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
