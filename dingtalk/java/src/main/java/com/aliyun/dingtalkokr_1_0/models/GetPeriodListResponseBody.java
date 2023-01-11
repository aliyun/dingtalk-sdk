// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class GetPeriodListResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public GetPeriodListResponseBodyData data;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetPeriodListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPeriodListResponseBody self = new GetPeriodListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPeriodListResponseBody setData(GetPeriodListResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetPeriodListResponseBodyData getData() {
        return this.data;
    }

    public GetPeriodListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetPeriodListResponseBodyDataPeriodList extends TeaModel {
        @NameInMap("endTime")
        public Float endTime;

        @NameInMap("id")
        public java.io.InputStream id;

        @NameInMap("isCurrent")
        public Boolean isCurrent;

        @NameInMap("isYearly")
        public Boolean isYearly;

        @NameInMap("name")
        public java.io.InputStream name;

        @NameInMap("startTime")
        public Float startTime;

        public static GetPeriodListResponseBodyDataPeriodList build(java.util.Map<String, ?> map) throws Exception {
            GetPeriodListResponseBodyDataPeriodList self = new GetPeriodListResponseBodyDataPeriodList();
            return TeaModel.build(map, self);
        }

        public GetPeriodListResponseBodyDataPeriodList setEndTime(Float endTime) {
            this.endTime = endTime;
            return this;
        }
        public Float getEndTime() {
            return this.endTime;
        }

        public GetPeriodListResponseBodyDataPeriodList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public GetPeriodListResponseBodyDataPeriodList setIsCurrent(Boolean isCurrent) {
            this.isCurrent = isCurrent;
            return this;
        }
        public Boolean getIsCurrent() {
            return this.isCurrent;
        }

        public GetPeriodListResponseBodyDataPeriodList setIsYearly(Boolean isYearly) {
            this.isYearly = isYearly;
            return this;
        }
        public Boolean getIsYearly() {
            return this.isYearly;
        }

        public GetPeriodListResponseBodyDataPeriodList setName(java.io.InputStream name) {
            this.name = name;
            return this;
        }
        public java.io.InputStream getName() {
            return this.name;
        }

        public GetPeriodListResponseBodyDataPeriodList setStartTime(Float startTime) {
            this.startTime = startTime;
            return this;
        }
        public Float getStartTime() {
            return this.startTime;
        }

    }

    public static class GetPeriodListResponseBodyData extends TeaModel {
        @NameInMap("periodList")
        public java.util.List<GetPeriodListResponseBodyDataPeriodList> periodList;

        public static GetPeriodListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPeriodListResponseBodyData self = new GetPeriodListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPeriodListResponseBodyData setPeriodList(java.util.List<GetPeriodListResponseBodyDataPeriodList> periodList) {
            this.periodList = periodList;
            return this;
        }
        public java.util.List<GetPeriodListResponseBodyDataPeriodList> getPeriodList() {
            return this.periodList;
        }

    }

}
