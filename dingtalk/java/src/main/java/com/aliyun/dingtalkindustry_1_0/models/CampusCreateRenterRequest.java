// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateRenterRequest extends TeaModel {
    // 企业信用代码
    @NameInMap("creditCode")
    public String creditCode;

    // 租期结束时间
    @NameInMap("endTime")
    public Long endTime;

    // 扩展信息
    @NameInMap("extend")
    public String extend;

    // 租客名称
    @NameInMap("name")
    public String name;

    // 租期开始时间
    @NameInMap("startTime")
    public Long startTime;

    // 状态
    @NameInMap("state")
    public Integer state;

    public static CampusCreateRenterRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateRenterRequest self = new CampusCreateRenterRequest();
        return TeaModel.build(map, self);
    }

    public CampusCreateRenterRequest setCreditCode(String creditCode) {
        this.creditCode = creditCode;
        return this;
    }
    public String getCreditCode() {
        return this.creditCode;
    }

    public CampusCreateRenterRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CampusCreateRenterRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusCreateRenterRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CampusCreateRenterRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CampusCreateRenterRequest setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

}
