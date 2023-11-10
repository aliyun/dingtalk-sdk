// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MemberModelMapValue extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    @NameInMap("conferenceId")
    public String conferenceId;

    @NameInMap("userNick")
    public String userNick;

    @NameInMap("joinTime")
    public Long joinTime;

    @NameInMap("leaveTime")
    public Long leaveTime;

    @NameInMap("duration")
    public Long duration;

    @NameInMap("attendStatus")
    public Integer attendStatus;

    @NameInMap("host")
    public Boolean host;

    @NameInMap("coHost")
    public Boolean coHost;

    @NameInMap("outerOrgMember")
    public Boolean outerOrgMember;

    @NameInMap("pstnJoin")
    public Boolean pstnJoin;

    @NameInMap("deviceType")
    public String deviceType;

    public static MemberModelMapValue build(java.util.Map<String, ?> map) throws Exception {
        MemberModelMapValue self = new MemberModelMapValue();
        return TeaModel.build(map, self);
    }

    public MemberModelMapValue setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public MemberModelMapValue setConferenceId(String conferenceId) {
        this.conferenceId = conferenceId;
        return this;
    }
    public String getConferenceId() {
        return this.conferenceId;
    }

    public MemberModelMapValue setUserNick(String userNick) {
        this.userNick = userNick;
        return this;
    }
    public String getUserNick() {
        return this.userNick;
    }

    public MemberModelMapValue setJoinTime(Long joinTime) {
        this.joinTime = joinTime;
        return this;
    }
    public Long getJoinTime() {
        return this.joinTime;
    }

    public MemberModelMapValue setLeaveTime(Long leaveTime) {
        this.leaveTime = leaveTime;
        return this;
    }
    public Long getLeaveTime() {
        return this.leaveTime;
    }

    public MemberModelMapValue setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public MemberModelMapValue setAttendStatus(Integer attendStatus) {
        this.attendStatus = attendStatus;
        return this;
    }
    public Integer getAttendStatus() {
        return this.attendStatus;
    }

    public MemberModelMapValue setHost(Boolean host) {
        this.host = host;
        return this;
    }
    public Boolean getHost() {
        return this.host;
    }

    public MemberModelMapValue setCoHost(Boolean coHost) {
        this.coHost = coHost;
        return this;
    }
    public Boolean getCoHost() {
        return this.coHost;
    }

    public MemberModelMapValue setOuterOrgMember(Boolean outerOrgMember) {
        this.outerOrgMember = outerOrgMember;
        return this;
    }
    public Boolean getOuterOrgMember() {
        return this.outerOrgMember;
    }

    public MemberModelMapValue setPstnJoin(Boolean pstnJoin) {
        this.pstnJoin = pstnJoin;
        return this;
    }
    public Boolean getPstnJoin() {
        return this.pstnJoin;
    }

    public MemberModelMapValue setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

}
