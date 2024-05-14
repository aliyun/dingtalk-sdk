// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetInActiveUserListResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    @NameInMap("metaList")
    public java.util.List<GetInActiveUserListResponseBodyMetaList> metaList;

    public static GetInActiveUserListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInActiveUserListResponseBody self = new GetInActiveUserListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInActiveUserListResponseBody setDataList(java.util.List<java.util.Map<String, ?>> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getDataList() {
        return this.dataList;
    }

    public GetInActiveUserListResponseBody setMetaList(java.util.List<GetInActiveUserListResponseBodyMetaList> metaList) {
        this.metaList = metaList;
        return this;
    }
    public java.util.List<GetInActiveUserListResponseBodyMetaList> getMetaList() {
        return this.metaList;
    }

    public static class GetInActiveUserListResponseBodyMetaList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiId")
        public String kpiId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kpiName")
        public String kpiName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("period")
        public String period;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        public static GetInActiveUserListResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            GetInActiveUserListResponseBodyMetaList self = new GetInActiveUserListResponseBodyMetaList();
            return TeaModel.build(map, self);
        }

        public GetInActiveUserListResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public GetInActiveUserListResponseBodyMetaList setKpiId(String kpiId) {
            this.kpiId = kpiId;
            return this;
        }
        public String getKpiId() {
            return this.kpiId;
        }

        public GetInActiveUserListResponseBodyMetaList setKpiName(String kpiName) {
            this.kpiName = kpiName;
            return this;
        }
        public String getKpiName() {
            return this.kpiName;
        }

        public GetInActiveUserListResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public GetInActiveUserListResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
