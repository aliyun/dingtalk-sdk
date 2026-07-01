// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateTeamRequest extends TeaModel {
    @NameInMap("dialectCode")
    public String dialectCode;

    @NameInMap("name")
    public String name;

    @NameInMap("sceneCodes")
    public java.util.List<String> sceneCodes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teamCode")
    public String teamCode;

    public static UpdateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTeamRequest self = new UpdateTeamRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTeamRequest setDialectCode(String dialectCode) {
        this.dialectCode = dialectCode;
        return this;
    }
    public String getDialectCode() {
        return this.dialectCode;
    }

    public UpdateTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateTeamRequest setSceneCodes(java.util.List<String> sceneCodes) {
        this.sceneCodes = sceneCodes;
        return this;
    }
    public java.util.List<String> getSceneCodes() {
        return this.sceneCodes;
    }

    public UpdateTeamRequest setTeamCode(String teamCode) {
        this.teamCode = teamCode;
        return this;
    }
    public String getTeamCode() {
        return this.teamCode;
    }

}
