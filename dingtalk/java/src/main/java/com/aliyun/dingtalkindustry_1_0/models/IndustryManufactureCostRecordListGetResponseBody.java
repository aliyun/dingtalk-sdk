// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCostRecordListGetResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<IndustryManufactureCostRecordListGetResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static IndustryManufactureCostRecordListGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCostRecordListGetResponseBody self = new IndustryManufactureCostRecordListGetResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCostRecordListGetResponseBody setList(java.util.List<IndustryManufactureCostRecordListGetResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryManufactureCostRecordListGetResponseBodyList> getList() {
        return this.list;
    }

    public IndustryManufactureCostRecordListGetResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryManufactureCostRecordListGetResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public IndustryManufactureCostRecordListGetResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class IndustryManufactureCostRecordListGetResponseBodyList extends TeaModel {
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("materialCostRecordNo")
        public String materialCostRecordNo;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("materialNo")
        public String materialNo;

        @NameInMap("materialName")
        public String materialName;

        @NameInMap("unit")
        public String unit;

        @NameInMap("count")
        public Float count;

        @NameInMap("type")
        public String type;

        @NameInMap("price")
        public Float price;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("productionTaskNo")
        public String productionTaskNo;

        @NameInMap("isDeleted")
        public String isDeleted;

        @NameInMap("ext")
        public String ext;

        @NameInMap("memo")
        public String memo;

        @NameInMap("realCount")
        public Float realCount;

        @NameInMap("realPrice")
        public Float realPrice;

        @NameInMap("processCode")
        public String processCode;

        public static IndustryManufactureCostRecordListGetResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureCostRecordListGetResponseBodyList self = new IndustryManufactureCostRecordListGetResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setMaterialCostRecordNo(String materialCostRecordNo) {
            this.materialCostRecordNo = materialCostRecordNo;
            return this;
        }
        public String getMaterialCostRecordNo() {
            return this.materialCostRecordNo;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setCount(Float count) {
            this.count = count;
            return this;
        }
        public Float getCount() {
            return this.count;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setPrice(Float price) {
            this.price = price;
            return this;
        }
        public Float getPrice() {
            return this.price;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setProductionTaskNo(String productionTaskNo) {
            this.productionTaskNo = productionTaskNo;
            return this;
        }
        public String getProductionTaskNo() {
            return this.productionTaskNo;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setIsDeleted(String isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public String getIsDeleted() {
            return this.isDeleted;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setRealCount(Float realCount) {
            this.realCount = realCount;
            return this;
        }
        public Float getRealCount() {
            return this.realCount;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setRealPrice(Float realPrice) {
            this.realPrice = realPrice;
            return this;
        }
        public Float getRealPrice() {
            return this.realPrice;
        }

        public IndustryManufactureCostRecordListGetResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
