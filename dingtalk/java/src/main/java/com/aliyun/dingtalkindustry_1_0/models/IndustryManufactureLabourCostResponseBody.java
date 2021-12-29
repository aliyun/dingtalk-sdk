// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureLabourCostResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<IndustryManufactureLabourCostResponseBodyList> list;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    public static IndustryManufactureLabourCostResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureLabourCostResponseBody self = new IndustryManufactureLabourCostResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureLabourCostResponseBody setList(java.util.List<IndustryManufactureLabourCostResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<IndustryManufactureLabourCostResponseBodyList> getList() {
        return this.list;
    }

    public IndustryManufactureLabourCostResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public IndustryManufactureLabourCostResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public IndustryManufactureLabourCostResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class IndustryManufactureLabourCostResponseBodyList extends TeaModel {
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("labourCostNo")
        public String labourCostNo;

        @NameInMap("labourCostName")
        public String labourCostName;

        @NameInMap("processNo")
        public String processNo;

        @NameInMap("processName")
        public String processName;

        @NameInMap("materialNo")
        public String materialNo;

        @NameInMap("materialName")
        public String materialName;

        @NameInMap("qualifiedPrice")
        public Float qualifiedPrice;

        @NameInMap("unQualifiedPrice1")
        public Float unQualifiedPrice1;

        @NameInMap("unQualifiedReason1")
        public String unQualifiedReason1;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("ext")
        public String ext;

        @NameInMap("unQualifiedReason2")
        public String unQualifiedReason2;

        @NameInMap("unQualifiedPrice2")
        public Float unQualifiedPrice2;

        @NameInMap("unQualifiedInfo")
        public String unQualifiedInfo;

        public static IndustryManufactureLabourCostResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureLabourCostResponseBodyList self = new IndustryManufactureLabourCostResponseBodyList();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureLabourCostResponseBodyList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public IndustryManufactureLabourCostResponseBodyList setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public IndustryManufactureLabourCostResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public IndustryManufactureLabourCostResponseBodyList setLabourCostNo(String labourCostNo) {
            this.labourCostNo = labourCostNo;
            return this;
        }
        public String getLabourCostNo() {
            return this.labourCostNo;
        }

        public IndustryManufactureLabourCostResponseBodyList setLabourCostName(String labourCostName) {
            this.labourCostName = labourCostName;
            return this;
        }
        public String getLabourCostName() {
            return this.labourCostName;
        }

        public IndustryManufactureLabourCostResponseBodyList setProcessNo(String processNo) {
            this.processNo = processNo;
            return this;
        }
        public String getProcessNo() {
            return this.processNo;
        }

        public IndustryManufactureLabourCostResponseBodyList setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public IndustryManufactureLabourCostResponseBodyList setMaterialNo(String materialNo) {
            this.materialNo = materialNo;
            return this;
        }
        public String getMaterialNo() {
            return this.materialNo;
        }

        public IndustryManufactureLabourCostResponseBodyList setMaterialName(String materialName) {
            this.materialName = materialName;
            return this;
        }
        public String getMaterialName() {
            return this.materialName;
        }

        public IndustryManufactureLabourCostResponseBodyList setQualifiedPrice(Float qualifiedPrice) {
            this.qualifiedPrice = qualifiedPrice;
            return this;
        }
        public Float getQualifiedPrice() {
            return this.qualifiedPrice;
        }

        public IndustryManufactureLabourCostResponseBodyList setUnQualifiedPrice1(Float unQualifiedPrice1) {
            this.unQualifiedPrice1 = unQualifiedPrice1;
            return this;
        }
        public Float getUnQualifiedPrice1() {
            return this.unQualifiedPrice1;
        }

        public IndustryManufactureLabourCostResponseBodyList setUnQualifiedReason1(String unQualifiedReason1) {
            this.unQualifiedReason1 = unQualifiedReason1;
            return this;
        }
        public String getUnQualifiedReason1() {
            return this.unQualifiedReason1;
        }

        public IndustryManufactureLabourCostResponseBodyList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public IndustryManufactureLabourCostResponseBodyList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public IndustryManufactureLabourCostResponseBodyList setExt(String ext) {
            this.ext = ext;
            return this;
        }
        public String getExt() {
            return this.ext;
        }

        public IndustryManufactureLabourCostResponseBodyList setUnQualifiedReason2(String unQualifiedReason2) {
            this.unQualifiedReason2 = unQualifiedReason2;
            return this;
        }
        public String getUnQualifiedReason2() {
            return this.unQualifiedReason2;
        }

        public IndustryManufactureLabourCostResponseBodyList setUnQualifiedPrice2(Float unQualifiedPrice2) {
            this.unQualifiedPrice2 = unQualifiedPrice2;
            return this;
        }
        public Float getUnQualifiedPrice2() {
            return this.unQualifiedPrice2;
        }

        public IndustryManufactureLabourCostResponseBodyList setUnQualifiedInfo(String unQualifiedInfo) {
            this.unQualifiedInfo = unQualifiedInfo;
            return this;
        }
        public String getUnQualifiedInfo() {
            return this.unQualifiedInfo;
        }

    }

}
