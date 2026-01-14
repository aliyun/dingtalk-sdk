// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorDataPushRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>code_sik2834jdi383jd</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<AgoalIndicatorDataPushRequestData> data;

    public static AgoalIndicatorDataPushRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorDataPushRequest self = new AgoalIndicatorDataPushRequest();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorDataPushRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public AgoalIndicatorDataPushRequest setData(java.util.List<AgoalIndicatorDataPushRequestData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<AgoalIndicatorDataPushRequestData> getData() {
        return this.data;
    }

    public static class AgoalIndicatorDataPushRequestData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("data")
        public String data;

        /**
         * <strong>example:</strong>
         * <p>2025-11-01 11:01:00</p>
         */
        @NameInMap("period")
        public String period;

        /**
         * <strong>example:</strong>
         * <p>YEAR、HALF_YEAR、QUARTER、DOUBLE_MONTH、MONTH、WEEK</p>
         */
        @NameInMap("periodType")
        public String periodType;

        public static AgoalIndicatorDataPushRequestData build(java.util.Map<String, ?> map) throws Exception {
            AgoalIndicatorDataPushRequestData self = new AgoalIndicatorDataPushRequestData();
            return TeaModel.build(map, self);
        }

        public AgoalIndicatorDataPushRequestData setData(String data) {
            this.data = data;
            return this;
        }
        public String getData() {
            return this.data;
        }

        public AgoalIndicatorDataPushRequestData setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public AgoalIndicatorDataPushRequestData setPeriodType(String periodType) {
            this.periodType = periodType;
            return this;
        }
        public String getPeriodType() {
            return this.periodType;
        }

    }

}
