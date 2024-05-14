// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureFeeListGetResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<IndustryManufactureFeeListGetResponseBodyList> list;

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

    public static IndustryManufactureFeeListGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureFeeListGetResponseBody self = new IndustryManufactureFeeListGetResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureFeeListGetResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public IndustryManufactureFeeListGetResponseBody setList(java.util.List<IndustryManufactureFeeListGetResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryManufactureFeeListGetResponseBodyList> getList() {
        return this.list;
    }

    public IndustryManufactureFeeListGetResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryManufactureFeeListGetResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class IndustryManufactureFeeListGetResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public String amount;

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
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("isDeleted")
        public String isDeleted;

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
        @NameInMap("perAmount")
        public Float perAmount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("productionTaskNo")
        public String productionTaskNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

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

        public static IndustryManufactureFeeListGetResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureFeeListGetResponseBodyList self = new IndustryManufactureFeeListGetResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureFeeListGetResponseBodyList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public IndustryManufactureFeeListGetResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryManufactureFeeListGetResponseBodyList setCount(Float count) {
            this.count = count;
            return this;
        }
        public Float getCount() {
            return this.count;
        }

        public IndustryManufactureFeeListGetResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryManufactureFeeListGetResponseBodyList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public IndustryManufactureFeeListGetResponseBodyList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public IndustryManufactureFeeListGetResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public IndustryManufactureFeeListGetResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryManufactureFeeListGetResponseBodyList setIsDeleted(String isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public String getIsDeleted() {
            return this.isDeleted;
        }

        public IndustryManufactureFeeListGetResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryManufactureFeeListGetResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryManufactureFeeListGetResponseBodyList setPerAmount(Float perAmount) {
            this.perAmount = perAmount;
            return this;
        }
        public Float getPerAmount() {
            return this.perAmount;
        }

        public IndustryManufactureFeeListGetResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public IndustryManufactureFeeListGetResponseBodyList setProductionTaskNo(String productionTaskNo) {
            this.productionTaskNo = productionTaskNo;
            return this;
        }
        public String getProductionTaskNo() {
            return this.productionTaskNo;
        }

        public IndustryManufactureFeeListGetResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public IndustryManufactureFeeListGetResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public IndustryManufactureFeeListGetResponseBodyList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

}
