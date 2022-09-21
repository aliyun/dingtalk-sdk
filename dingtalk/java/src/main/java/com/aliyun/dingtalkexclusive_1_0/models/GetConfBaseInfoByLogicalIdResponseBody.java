// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConfBaseInfoByLogicalIdResponseBody extends TeaModel {
    // 会议ID（仅在会议正式开始后才返回该字段）
    @NameInMap("conferenceId")
    public String conferenceId;

    // 会议逻辑id
    @NameInMap("logicalConferenceId")
    public String logicalConferenceId;

    // 会议创建用户昵称
    @NameInMap("nickname")
    public String nickname;

    // 开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 会议标题
    @NameInMap("title")
    public String title;

    // 会议创建用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetConfBaseInfoByLogicalIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConfBaseInfoByLogicalIdResponseBody self = new GetConfBaseInfoByLogicalIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConfBaseInfoByLogicalIdResponseBody setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public GetConfBaseInfoByLogicalIdResponseBody setLogicalConferenceId(String logicalConferenceId) {
        this.logicalConferenceId = logicalConferenceId;
        return this;
    }
    public String getLogicalConferenceId() {
        return this.logicalConferenceId;
    }

    public GetConfBaseInfoByLogicalIdResponseBody setNickname(String nickname) {
        this.nickname = nickname;
        return this;
    }
    public String getNickname() {
        return this.nickname;
    }

    public GetConfBaseInfoByLogicalIdResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetConfBaseInfoByLogicalIdResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetConfBaseInfoByLogicalIdResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
