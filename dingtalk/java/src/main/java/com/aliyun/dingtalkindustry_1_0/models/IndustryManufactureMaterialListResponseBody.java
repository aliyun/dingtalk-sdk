// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMaterialListResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<IndustryManufactureMaterialListResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static IndustryManufactureMaterialListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMaterialListResponseBody self = new IndustryManufactureMaterialListResponseBody();
        return TeaModel.build(map, self);
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

    public IndustryManufactureMaterialListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class IndustryManufactureMaterialListResponseBodyList extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("materialNo")
        public String materialNo;

        @NameInMap("materialName")
        public String materialName;

        @NameInMap("specification")
        public String specification;

        @NameInMap("type")
        public String type;

        @NameInMap("category")
        public String category;

        @NameInMap("unit")
        public String unit;

        @NameInMap("ext")
        public String ext;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("stockMaxWarn")
        public Float stockMaxWarn;

        @NameInMap("stockMinWarn")
        public Float stockMinWarn;

        public static IndustryManufactureMaterialListResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMaterialListResponseBodyList self = new IndustryManufactureMaterialListResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMaterialListResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryManufactureMaterialListResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryManufactureMaterialListResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryManufactureMaterialListResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryManufactureMaterialListResponseBodyList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public IndustryManufactureMaterialListResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public IndustryManufactureMaterialListResponseBodyList setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public IndustryManufactureMaterialListResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public IndustryManufactureMaterialListResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryManufactureMaterialListResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
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

    }

}
