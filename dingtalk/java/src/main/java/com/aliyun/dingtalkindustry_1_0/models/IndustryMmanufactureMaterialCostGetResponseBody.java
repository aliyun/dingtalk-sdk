// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryMmanufactureMaterialCostGetResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> list;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static IndustryMmanufactureMaterialCostGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryMmanufactureMaterialCostGetResponseBody self = new IndustryMmanufactureMaterialCostGetResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setList(java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> getList() {
        return this.list;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class IndustryMmanufactureMaterialCostGetResponseBodyList extends TeaModel {
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("materialCostNo")
        public String materialCostNo;

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

        @NameInMap("price")
        public Float price;

        @NameInMap("actPrice")
        public Float actPrice;

        @NameInMap("ext")
        public String ext;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("memo")
        public String memo;

        public static IndustryMmanufactureMaterialCostGetResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryMmanufactureMaterialCostGetResponseBodyList self = new IndustryMmanufactureMaterialCostGetResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialCostNo(String materialCostNo) {
            this.materialCostNo = materialCostNo;
            return this;
        }
        public String getMaterialCostNo() {
            return this.materialCostNo;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setCount(Float count) {
            this.count = count;
            return this;
        }
        public Float getCount() {
            return this.count;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setPrice(Float price) {
            this.price = price;
            return this;
        }
        public Float getPrice() {
            return this.price;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setActPrice(Float actPrice) {
            this.actPrice = actPrice;
            return this;
        }
        public Float getActPrice() {
            return this.actPrice;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
