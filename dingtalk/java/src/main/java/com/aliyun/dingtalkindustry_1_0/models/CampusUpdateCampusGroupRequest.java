// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("campusProjectGroupId")
    public Long campusProjectGroupId;

    /**
     * <strong>example:</strong>
     * <p>扩展信息</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <strong>example:</strong>
     * <p>绿城未来park</p>
     */
    @NameInMap("name")
    public String name;

    public static CampusUpdateCampusGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusGroupRequest self = new CampusUpdateCampusGroupRequest();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusGroupRequest setCampusProjectGroupId(Long campusProjectGroupId) {
        this.campusProjectGroupId = campusProjectGroupId;
        return this;
    }
    public Long getCampusProjectGroupId() {
        return this.campusProjectGroupId;
    }

    public CampusUpdateCampusGroupRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusUpdateCampusGroupRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
