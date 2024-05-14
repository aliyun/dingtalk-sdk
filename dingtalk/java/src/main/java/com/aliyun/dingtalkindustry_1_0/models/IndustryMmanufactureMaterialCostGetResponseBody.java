// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryMmanufactureMaterialCostGetResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> list;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextCursor")
    public Long nextCursor;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static IndustryMmanufactureMaterialCostGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryMmanufactureMaterialCostGetResponseBody self = new IndustryMmanufactureMaterialCostGetResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setList(java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryMmanufactureMaterialCostGetResponseBodyList> getList() {
        return this.list;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryMmanufactureMaterialCostGetResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class IndustryMmanufactureMaterialCostGetResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("actPrice")
        public Float actPrice;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("count")
        public Float count;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ext")
        public String ext;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("materialCostNo")
        public String materialCostNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("materialName")
        public String materialName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("materialNo")
        public String materialNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("price")
        public Float price;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        public static IndustryMmanufactureMaterialCostGetResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryMmanufactureMaterialCostGetResponseBodyList self = new IndustryMmanufactureMaterialCostGetResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setActPrice(Float actPrice) {
            this.actPrice = actPrice;
            return this;
        }
        public Float getActPrice() {
            return this.actPrice;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setCount(Float count) {
            this.count = count;
            return this;
        }
        public Float getCount() {
            return this.count;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
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

        public IndustryMmanufactureMaterialCostGetResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialCostNo(String materialCostNo) {
            this.materialCostNo = materialCostNo;
            return this;
        }
        public String getMaterialCostNo() {
            return this.materialCostNo;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setPrice(Float price) {
            this.price = price;
            return this;
        }
        public Float getPrice() {
            return this.price;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public IndustryMmanufactureMaterialCostGetResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
