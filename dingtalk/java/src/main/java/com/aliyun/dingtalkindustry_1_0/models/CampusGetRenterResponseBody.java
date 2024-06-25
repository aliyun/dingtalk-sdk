// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetRenterResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding121313</p>
     */
    @NameInMap("bindRenterCorpId")
    public String bindRenterCorpId;

    /**
     * <strong>example:</strong>
     * <p>1655704317794</p>
     */
    @NameInMap("bindTime")
    public Long bindTime;

    /**
     * <strong>example:</strong>
     * <p>231313</p>
     */
    @NameInMap("creditCode")
    public String creditCode;

    /**
     * <strong>example:</strong>
     * <p>1655704317794</p>
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
     * <strong>example:</strong>
     * <p>名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>101</p>
     */
    @NameInMap("renterDeptId")
    public Long renterDeptId;

    /**
     * <strong>example:</strong>
     * <p>1655704317794</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
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
