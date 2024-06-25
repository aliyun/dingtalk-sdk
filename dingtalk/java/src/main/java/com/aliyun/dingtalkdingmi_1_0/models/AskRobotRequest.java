// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotRequest extends TeaModel {
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小蜜机器人能做什么</p>
     */
    @NameInMap("question")
    public String question;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd1234</p>
     */
    @NameInMap("robotAppKey")
    public String robotAppKey;

    /**
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("sessionUuid")
    public String sessionUuid;

    public static AskRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        AskRobotRequest self = new AskRobotRequest();
        return TeaModel.build(map, self);
    }

    public AskRobotRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public AskRobotRequest setQuestion(String question) {
        this.question = question;
        return this;
    }
    public String getQuestion() {
        return this.question;
    }

    public AskRobotRequest setRobotAppKey(String robotAppKey) {
        this.robotAppKey = robotAppKey;
        return this;
    }
    public String getRobotAppKey() {
        return this.robotAppKey;
    }

    public AskRobotRequest setSessionUuid(String sessionUuid) {
        this.sessionUuid = sessionUuid;
        return this;
    }
    public String getSessionUuid() {
        return this.sessionUuid;
    }

}
