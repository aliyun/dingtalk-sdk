// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusGroupRequest extends TeaModel {
    // 扩展信息
    @NameInMap("extend")
    public String extend;

    // 园区项目组
    @NameInMap("name")
    public String name;

    public static CampusCreateCampusGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusGroupRequest self = new CampusCreateCampusGroupRequest();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusGroupRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusCreateCampusGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
