// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCompetitionRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5F44C</p>
     */
    @NameInMap("competitionCode")
    public String competitionCode;

    /**
     * <strong>example:</strong>
     * <p>edu</p>
     */
    @NameInMap("groupTemplateCode")
    public String groupTemplateCode;

    @NameInMap("joinGroup")
    public Boolean joinGroup;

    /**
     * <strong>example:</strong>
     * <p>小明</p>
     */
    @NameInMap("participantName")
    public String participantName;

    /**
     * <strong>example:</strong>
     * <p>VYn5fYjORJMi</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddCompetitionRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCompetitionRecordRequest self = new AddCompetitionRecordRequest();
        return TeaModel.build(map, self);
    }

    public AddCompetitionRecordRequest setCompetitionCode(String competitionCode) {
        this.competitionCode = competitionCode;
        return this;
    }
    public String getCompetitionCode() {
        return this.competitionCode;
    }

    public AddCompetitionRecordRequest setGroupTemplateCode(String groupTemplateCode) {
        this.groupTemplateCode = groupTemplateCode;
        return this;
    }
    public String getGroupTemplateCode() {
        return this.groupTemplateCode;
    }

    public AddCompetitionRecordRequest setJoinGroup(Boolean joinGroup) {
        this.joinGroup = joinGroup;
        return this;
    }
    public Boolean getJoinGroup() {
        return this.joinGroup;
    }

    public AddCompetitionRecordRequest setParticipantName(String participantName) {
        this.participantName = participantName;
        return this;
    }
    public String getParticipantName() {
        return this.participantName;
    }

    public AddCompetitionRecordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
