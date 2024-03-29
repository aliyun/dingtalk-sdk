// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterRequest extends TeaModel {
    @NameInMap("creditCode")
    public String creditCode;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("extend")
    public String extend;

    @NameInMap("name")
    public String name;

    @NameInMap("renterId")
    public Long renterId;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("state")
    public Integer state;

    public static CampusUpdateRenterRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateRenterRequest self = new CampusUpdateRenterRequest();
        return TeaModel.build(map, self);
    }

    public CampusUpdateRenterRequest setCreditCode(String creditCode) {
        this.creditCode = creditCode;
        return this;
    }
    public String getCreditCode() {
        return this.creditCode;
    }

    public CampusUpdateRenterRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CampusUpdateRenterRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusUpdateRenterRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusUpdateRenterRequest setRenterId(Long renterId) {
        this.renterId = renterId;
        return this;
    }
    public Long getRenterId() {
        return this.renterId;
    }

    public CampusUpdateRenterRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CampusUpdateRenterRequest setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

}
