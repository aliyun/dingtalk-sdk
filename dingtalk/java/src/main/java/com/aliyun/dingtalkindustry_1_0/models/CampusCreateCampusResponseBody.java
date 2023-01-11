// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusResponseBody extends TeaModel {
    /**
     * <p>园区组织ID</p>
     */
    @NameInMap("campusCorpId")
    public String campusCorpId;

    /**
     * <p>园区部门ID</p>
     */
    @NameInMap("campusDeptId")
    public String campusDeptId;

    public static CampusCreateCampusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusResponseBody self = new CampusCreateCampusResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusResponseBody setCampusCorpId(String campusCorpId) {
        this.campusCorpId = campusCorpId;
        return this;
    }
    public String getCampusCorpId() {
        return this.campusCorpId;
    }

    public CampusCreateCampusResponseBody setCampusDeptId(String campusDeptId) {
        this.campusDeptId = campusDeptId;
        return this;
    }
    public String getCampusDeptId() {
        return this.campusDeptId;
    }

}
