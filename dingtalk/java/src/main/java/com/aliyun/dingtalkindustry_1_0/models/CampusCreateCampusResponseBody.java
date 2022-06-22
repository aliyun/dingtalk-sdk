// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusResponseBody extends TeaModel {
    // 园区组织ID
    @NameInMap("campusCorpId")
    public String campusCorpId;

    // 园区部门ID
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
