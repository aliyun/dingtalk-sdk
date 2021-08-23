// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public java.util.List<ListSubCorpsResponseBodyResult> result;

    public static ListSubCorpsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubCorpsResponseBody self = new ListSubCorpsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubCorpsResponseBody setResult(java.util.List<ListSubCorpsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListSubCorpsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListSubCorpsResponseBodyResult extends TeaModel {
        // 企业corpid
        @NameInMap("corpId")
        public String corpId;

        // 企业名字
        @NameInMap("name")
        public String name;

        // 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
        @NameInMap("regionType")
        public String regionType;

        // 区域码
        @NameInMap("regionId")
        public String regionId;

        // 区域详细信息
        @NameInMap("regionLocation")
        public String regionLocation;

        // 企业行业码
        @NameInMap("industryCode")
        public Integer industryCode;

        // 企业行业名称
        @NameInMap("industry")
        public String industry;

        public static ListSubCorpsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListSubCorpsResponseBodyResult self = new ListSubCorpsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListSubCorpsResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListSubCorpsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListSubCorpsResponseBodyResult setRegionType(String regionType) {
            this.regionType = regionType;
            return this;
        }
        public String getRegionType() {
            return this.regionType;
        }

        public ListSubCorpsResponseBodyResult setRegionId(String regionId) {
            this.regionId = regionId;
            return this;
        }
        public String getRegionId() {
            return this.regionId;
        }

        public ListSubCorpsResponseBodyResult setRegionLocation(String regionLocation) {
            this.regionLocation = regionLocation;
            return this;
        }
        public String getRegionLocation() {
            return this.regionLocation;
        }

        public ListSubCorpsResponseBodyResult setIndustryCode(Integer industryCode) {
            this.industryCode = industryCode;
            return this;
        }
        public Integer getIndustryCode() {
            return this.industryCode;
        }

        public ListSubCorpsResponseBodyResult setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

    }

}
