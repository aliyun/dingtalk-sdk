// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MemberModelMapValue extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <strong>example:</strong>
     * <p>654058f2411fe90147e68780</p>
     */
    @NameInMap("conferenceId")
    public String conferenceId;

    /**
     * <strong>example:</strong>
     * <p>测试昵称</p>
     */
    @NameInMap("userNick")
    public String userNick;

    /**
     * <strong>example:</strong>
     * <p>1699347295876</p>
     */
    @NameInMap("joinTime")
    public Long joinTime;

    /**
     * <strong>example:</strong>
     * <p>1699347395876</p>
     */
    @NameInMap("leaveTime")
    public Long leaveTime;

    /**
     * <strong>example:</strong>
     * <p>100000</p>
     */
    @NameInMap("duration")
    public Long duration;

    /**
     * <strong>example:</strong>
     * <p>1：初始化  2：呼叫中  3：活跃（在会）  4：入会失败（拒接等）  5：被踢  6：离会</p>
     */
    @NameInMap("attendStatus")
    public Integer attendStatus;

    /**
     * <strong>example:</strong>
     * <p>true：是  false：否</p>
     */
    @NameInMap("host")
    public Boolean host;

    /**
     * <strong>example:</strong>
     * <p>true：是  false：否</p>
     */
    @NameInMap("coHost")
    public Boolean coHost;

    /**
     * <strong>example:</strong>
     * <p>true：是  false：否</p>
     */
    @NameInMap("outerOrgMember")
    public Boolean outerOrgMember;

    /**
     * <strong>example:</strong>
     * <p>true：是  false：否</p>
     */
    @NameInMap("pstnJoin")
    public Boolean pstnJoin;

    /**
     * <strong>example:</strong>
     * <p>Win Mac iOS Android</p>
     */
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
