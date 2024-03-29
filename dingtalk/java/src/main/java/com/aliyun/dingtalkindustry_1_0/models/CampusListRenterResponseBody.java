// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListRenterResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<CampusListRenterResponseBodyResult> result;

    public static CampusListRenterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusListRenterResponseBody self = new CampusListRenterResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusListRenterResponseBody setResult(java.util.List<CampusListRenterResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CampusListRenterResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CampusListRenterResponseBodyResult extends TeaModel {
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

        public static CampusListRenterResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CampusListRenterResponseBodyResult self = new CampusListRenterResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CampusListRenterResponseBodyResult setBindRenterCorpId(String bindRenterCorpId) {
            this.bindRenterCorpId = bindRenterCorpId;
            return this;
        }
        public String getBindRenterCorpId() {
            return this.bindRenterCorpId;
        }

        public CampusListRenterResponseBodyResult setBindTime(Long bindTime) {
            this.bindTime = bindTime;
            return this;
        }
        public Long getBindTime() {
            return this.bindTime;
        }

        public CampusListRenterResponseBodyResult setCreditCode(String creditCode) {
            this.creditCode = creditCode;
            return this;
        }
        public String getCreditCode() {
            return this.creditCode;
        }

        public CampusListRenterResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public CampusListRenterResponseBodyResult setExtend(String extend) {
            this.extend = extend;
            return this;
        }
        public String getExtend() {
            return this.extend;
        }

        public CampusListRenterResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CampusListRenterResponseBodyResult setRenterDeptId(Long renterDeptId) {
            this.renterDeptId = renterDeptId;
            return this;
        }
        public Long getRenterDeptId() {
            return this.renterDeptId;
        }

        public CampusListRenterResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public CampusListRenterResponseBodyResult setState(Integer state) {
            this.state = state;
            return this;
        }
        public Integer getState() {
            return this.state;
        }

    }

}
