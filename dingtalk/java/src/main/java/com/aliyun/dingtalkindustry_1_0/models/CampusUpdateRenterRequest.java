// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateRenterRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>231313</p>
     */
    @NameInMap("creditCode")
    public String creditCode;

    /**
     * <strong>example:</strong>
     * <p>16123523124</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>扩展</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>钉钉</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12352335</p>
     */
    @NameInMap("renterId")
    public Long renterId;

    /**
     * <strong>example:</strong>
     * <p>2183478412</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
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
