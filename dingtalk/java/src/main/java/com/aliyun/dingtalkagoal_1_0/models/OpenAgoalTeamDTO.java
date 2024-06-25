// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalTeamDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>8535683xx</p>
     */
    @NameInMap("deptId")
    public String deptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试部门</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("teamId")
    public String teamId;

    public static OpenAgoalTeamDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalTeamDTO self = new OpenAgoalTeamDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalTeamDTO setDeptId(String deptId) {
        this.deptId = deptId;
        return this;
    }
    public String getDeptId() {
        return this.deptId;
    }

    public OpenAgoalTeamDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenAgoalTeamDTO setTeamId(String teamId) {
        this.teamId = teamId;
        return this;
    }
    public String getTeamId() {
        return this.teamId;
    }

}
