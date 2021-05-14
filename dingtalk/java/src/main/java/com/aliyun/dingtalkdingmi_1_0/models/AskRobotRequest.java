// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotRequest extends TeaModel {
    // 问题
    @NameInMap("question")
    public String question;

    // 企业corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 机器人id
    @NameInMap("robotAppKey")
    public String robotAppKey;

    // sessionId(非必传)
    @NameInMap("sessionUuid")
    public String sessionUuid;

    // suiteKey
    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static AskRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        AskRobotRequest self = new AskRobotRequest();
        return TeaModel.build(map, self);
    }

    public AskRobotRequest setQuestion(String question) {
        this.question = question;
        return this;
    }
    public String getQuestion() {
        return this.question;
    }

    public AskRobotRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
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

    public AskRobotRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

}
