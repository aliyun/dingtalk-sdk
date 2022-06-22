// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterRequest extends TeaModel {
    // 企业信用代码
    @NameInMap("creditCode")
    public String creditCode;

    // 租期开始时间
    @NameInMap("endTime")
    public Long endTime;

    // 扩展字段
    @NameInMap("extend")
    public String extend;

    // 租客名字
    @NameInMap("name")
    public String name;

    // 租客ID
    @NameInMap("renterId")
    public Long renterId;

    // 租期结束时间
    @NameInMap("startTime")
    public Long startTime;

    // 启用状态
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
