// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusGroupResponseBody extends TeaModel {
    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>项目名</p>
     */
    @NameInMap("projectGroupName")
    public String projectGroupName;

    public static CampusGetCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusGroupResponseBody self = new CampusGetCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusGroupResponseBody setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusGetCampusGroupResponseBody setProjectGroupName(String projectGroupName) {
        this.projectGroupName = projectGroupName;
        return this;
    }
    public String getProjectGroupName() {
        return this.projectGroupName;
    }

}
