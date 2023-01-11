// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConfBaseInfoByLogicalIdResponseBody extends TeaModel {
    /**
     * <p>会议ID（仅在会议正式开始后才返回该字段）</p>
     */
    @NameInMap("conferenceId")
    public String conferenceId;

    /**
     * <p>会议逻辑id</p>
     */
    @NameInMap("logicalConferenceId")
    public String logicalConferenceId;

    /**
     * <p>会议创建用户昵称</p>
     */
    @NameInMap("nickname")
    public String nickname;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>会议标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>会议创建用户id</p>
     */
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
