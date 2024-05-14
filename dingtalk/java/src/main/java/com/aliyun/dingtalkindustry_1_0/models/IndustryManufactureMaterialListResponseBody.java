// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMaterialListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<IndustryManufactureMaterialListResponseBodyList> list;

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

    public static IndustryManufactureMaterialListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMaterialListResponseBody self = new IndustryManufactureMaterialListResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMaterialListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public IndustryManufactureMaterialListResponseBody setList(java.util.List<IndustryManufactureMaterialListResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryManufactureMaterialListResponseBodyList> getList() {
        return this.list;
    }

    public IndustryManufactureMaterialListResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryManufactureMaterialListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class IndustryManufactureMaterialListResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ext")
        public String ext;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

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
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("specification")
        public String specification;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("stockMaxWarn")
        public Float stockMaxWarn;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("stockMinWarn")
        public Float stockMinWarn;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unit")
        public String unit;

        public static IndustryManufactureMaterialListResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMaterialListResponseBodyList self = new IndustryManufactureMaterialListResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMaterialListResponseBodyList setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public IndustryManufactureMaterialListResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryManufactureMaterialListResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryManufactureMaterialListResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryManufactureMaterialListResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryManufactureMaterialListResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryManufactureMaterialListResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public IndustryManufactureMaterialListResponseBodyList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public IndustryManufactureMaterialListResponseBodyList setStockMaxWarn(Float stockMaxWarn) {
            this.stockMaxWarn = stockMaxWarn;
            return this;
        }
        public Float getStockMaxWarn() {
            return this.stockMaxWarn;
        }

        public IndustryManufactureMaterialListResponseBodyList setStockMinWarn(Float stockMinWarn) {
            this.stockMinWarn = stockMinWarn;
            return this;
        }
        public Float getStockMinWarn() {
            return this.stockMinWarn;
        }

        public IndustryManufactureMaterialListResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public IndustryManufactureMaterialListResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
