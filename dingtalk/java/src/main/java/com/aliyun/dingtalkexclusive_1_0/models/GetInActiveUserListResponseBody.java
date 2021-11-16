// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetInActiveUserListResponseBody extends TeaModel {
    // 指标数据
    @NameInMap("dataList")
    public java.util.List<java.util.Map<String, ?>> dataList;

    // 指标元数据
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
        // 指标ID
        @NameInMap("kpiId")
        public String kpiId;

        // 指标名称
        @NameInMap("kpiName")
        public String kpiName;

        // 指标单位
        @NameInMap("unit")
        public String unit;

        // 指标口径
        @NameInMap("kpiCaliber")
        public String kpiCaliber;

        // 指标周期
        @NameInMap("period")
        public String period;

        public static GetInActiveUserListResponseBodyMetaList build(java.util.Map<String, ?> map) throws Exception {
            GetInActiveUserListResponseBodyMetaList self = new GetInActiveUserListResponseBodyMetaList();
            return TeaModel.build(map, self);
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

        public GetInActiveUserListResponseBodyMetaList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public GetInActiveUserListResponseBodyMetaList setKpiCaliber(String kpiCaliber) {
            this.kpiCaliber = kpiCaliber;
            return this;
        }
        public String getKpiCaliber() {
            return this.kpiCaliber;
        }

        public GetInActiveUserListResponseBodyMetaList setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

    }

}
