// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenOrgPerfDocDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("docId")
    public String docId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("executor")
    public OpenAgoalUserDTO executor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("score")
    public String score;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("state")
    public String state;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("team")
    public OpenAgoalTeamDTO team;

    public static OpenOrgPerfDocDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenOrgPerfDocDTO self = new OpenOrgPerfDocDTO();
        return TeaModel.build(map, self);
    }

    public OpenOrgPerfDocDTO setDocId(String docId) {
        this.docId = docId;
        return this;
    }
    public String getDocId() {
        return this.docId;
    }

    public OpenOrgPerfDocDTO setExecutor(OpenAgoalUserDTO executor) {
        this.executor = executor;
        return this;
    }
    public OpenAgoalUserDTO getExecutor() {
        return this.executor;
    }

    public OpenOrgPerfDocDTO setScore(String score) {
        this.score = score;
        return this;
    }
    public String getScore() {
        return this.score;
    }

    public OpenOrgPerfDocDTO setState(String state) {
        this.state = state;
        return this;
    }
    public String getState() {
        return this.state;
    }

    public OpenOrgPerfDocDTO setTeam(OpenAgoalTeamDTO team) {
        this.team = team;
        return this;
    }
    public OpenAgoalTeamDTO getTeam() {
        return this.team;
    }

}
