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
        /**
         * <strong>example:</strong>
         * <p>ding3242423</p>
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
         * <p>1313131414</p>
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
         * <p>扩展信息</p>
         */
        @NameInMap("extend")
        public String extend;

        /**
         * <strong>example:</strong>
         * <p>测试租客</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>100</p>
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
