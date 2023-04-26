// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterResponseBody extends TeaModel {
    @NameInMap("bindRenterCorpId")
    public String bindRenterCorpId;

    @NameInMap("bindTime")
    public Long bindTime;

    @NameInMap("creditCode")
    public String creditCode;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("extend")
    public String extend;

    @NameInMap("name")
    public String name;

    @NameInMap("renterDeptId")
    public Long renterDeptId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("state")
    public Integer state;

    public static CampusGetRenterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusGetRenterResponseBody self = new CampusGetRenterResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusGetRenterResponseBody setBindRenterCorpId(String bindRenterCorpId) {
        this.bindRenterCorpId = bindRenterCorpId;
        return this;
    }
    public String getBindRenterCorpId() {
        return this.bindRenterCorpId;
    }

    public CampusGetRenterResponseBody setBindTime(Long bindTime) {
        this.bindTime = bindTime;
        return this;
    }
    public Long getBindTime() {
        return this.bindTime;
    }

    public CampusGetRenterResponseBody setCreditCode(String creditCode) {
        this.creditCode = creditCode;
        return this;
    }
    public String getCreditCode() {
        return this.creditCode;
    }

    public CampusGetRenterResponseBody setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CampusGetRenterResponseBody setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusGetRenterResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusGetRenterResponseBody setRenterDeptId(Long renterDeptId) {
        this.renterDeptId = renterDeptId;
        return this;
    }
    public Long getRenterDeptId() {
        return this.renterDeptId;
    }

    public CampusGetRenterResponseBody setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CampusGetRenterResponseBody setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

}
