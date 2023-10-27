// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenTeamDTO extends TeaModel {
    @NameInMap("deptUid")
    public String deptUid;

    @NameInMap("dingDeptId")
    public String dingDeptId;

    @NameInMap("name")
    public String name;

    public static OpenTeamDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenTeamDTO self = new OpenTeamDTO();
        return TeaModel.build(map, self);
    }

    public OpenTeamDTO setDeptUid(String deptUid) {
        this.deptUid = deptUid;
        return this;
    }
    public String getDeptUid() {
        return this.deptUid;
    }

    public OpenTeamDTO setDingDeptId(String dingDeptId) {
        this.dingDeptId = dingDeptId;
        return this;
    }
    public String getDingDeptId() {
        return this.dingDeptId;
    }

    public OpenTeamDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
