// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotRequest extends TeaModel {
    @NameInMap("dingUserId")
    public String dingUserId;

    // 问题
    @NameInMap("question")
    public String question;

    // 机器人id
    @NameInMap("robotAppKey")
    public String robotAppKey;

    // sessionId(非必传)
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
