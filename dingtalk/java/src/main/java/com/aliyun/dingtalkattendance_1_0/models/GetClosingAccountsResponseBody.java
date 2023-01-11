// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetClosingAccountsResponseBody extends TeaModel {
    /**
     * <p>规则列表</p>
     */
    @NameInMap("result")
    public java.util.List<GetClosingAccountsResponseBodyResult> result;

    public static GetClosingAccountsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetClosingAccountsResponseBody self = new GetClosingAccountsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetClosingAccountsResponseBody setResult(java.util.List<GetClosingAccountsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetClosingAccountsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetClosingAccountsResponseBodyResultClosingAccountModel extends TeaModel {
        /**
         * <p>封账时间-日</p>
         */
        @NameInMap("closingDay")
        public Integer closingDay;

        /**
         * <p>封账时间-时分</p>
         */
        @NameInMap("closingHourMinutes")
        public Long closingHourMinutes;

        /**
         * <p>封账范围-结束日</p>
         */
        @NameInMap("endDay")
        public Integer endDay;

        /**
         * <p>封账范围-结束月</p>
         */
        @NameInMap("endMonth")
        public Integer endMonth;

        /**
         * <p>封账范围-开始日</p>
         */
        @NameInMap("startDay")
        public Integer startDay;

        /**
         * <p>封账范围-开始月</p>
         */
        @NameInMap("startMonth")
        public Integer startMonth;

        public static GetClosingAccountsResponseBodyResultClosingAccountModel build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResultClosingAccountModel self = new GetClosingAccountsResponseBodyResultClosingAccountModel();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setClosingDay(Integer closingDay) {
            this.closingDay = closingDay;
            return this;
        }
        public Integer getClosingDay() {
            return this.closingDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setClosingHourMinutes(Long closingHourMinutes) {
            this.closingHourMinutes = closingHourMinutes;
            return this;
        }
        public Long getClosingHourMinutes() {
            return this.closingHourMinutes;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndDay(Integer endDay) {
            this.endDay = endDay;
            return this;
        }
        public Integer getEndDay() {
            return this.endDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setEndMonth(Integer endMonth) {
            this.endMonth = endMonth;
            return this;
        }
        public Integer getEndMonth() {
            return this.endMonth;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartDay(Integer startDay) {
            this.startDay = startDay;
            return this;
        }
        public Integer getStartDay() {
            return this.startDay;
        }

        public GetClosingAccountsResponseBodyResultClosingAccountModel setStartMonth(Integer startMonth) {
            this.startMonth = startMonth;
            return this;
        }
        public Integer getStartMonth() {
            return this.startMonth;
        }

    }

    public static class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel extends TeaModel {
        /**
         * <p>解封时间点</p>
         */
        @NameInMap("invalidTimeStamp")
        public Long invalidTimeStamp;

        public static GetClosingAccountsResponseBodyResultUnsealClosingAccountModel build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResultUnsealClosingAccountModel self = new GetClosingAccountsResponseBodyResultUnsealClosingAccountModel();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel setInvalidTimeStamp(Long invalidTimeStamp) {
            this.invalidTimeStamp = invalidTimeStamp;
            return this;
        }
        public Long getInvalidTimeStamp() {
            return this.invalidTimeStamp;
        }

    }

    public static class GetClosingAccountsResponseBodyResult extends TeaModel {
        /**
         * <p>封账规则</p>
         */
        @NameInMap("closingAccountModel")
        public GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel;

        /**
         * <p>开关</p>
         */
        @NameInMap("switchOn")
        public Boolean switchOn;

        /**
         * <p>解封规则</p>
         */
        @NameInMap("unsealClosingAccountModel")
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel;

        /**
         * <p>人员ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetClosingAccountsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetClosingAccountsResponseBodyResult self = new GetClosingAccountsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetClosingAccountsResponseBodyResult setClosingAccountModel(GetClosingAccountsResponseBodyResultClosingAccountModel closingAccountModel) {
            this.closingAccountModel = closingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultClosingAccountModel getClosingAccountModel() {
            return this.closingAccountModel;
        }

        public GetClosingAccountsResponseBodyResult setSwitchOn(Boolean switchOn) {
            this.switchOn = switchOn;
            return this;
        }
        public Boolean getSwitchOn() {
            return this.switchOn;
        }

        public GetClosingAccountsResponseBodyResult setUnsealClosingAccountModel(GetClosingAccountsResponseBodyResultUnsealClosingAccountModel unsealClosingAccountModel) {
            this.unsealClosingAccountModel = unsealClosingAccountModel;
            return this;
        }
        public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel getUnsealClosingAccountModel() {
            return this.unsealClosingAccountModel;
        }

        public GetClosingAccountsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
