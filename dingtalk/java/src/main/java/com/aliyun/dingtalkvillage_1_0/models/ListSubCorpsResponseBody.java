// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("corpList")
    public java.util.List<ListSubCorpsResponseBodyCorpList> corpList;

    public static ListSubCorpsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubCorpsResponseBody self = new ListSubCorpsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubCorpsResponseBody setCorpList(java.util.List<ListSubCorpsResponseBodyCorpList> corpList) {
        this.corpList = corpList;
        return this;
    }
    public java.util.List<ListSubCorpsResponseBodyCorpList> getCorpList() {
        return this.corpList;
    }

    public static class ListSubCorpsResponseBodyCorpList extends TeaModel {
        /**
         * <p>组织corpid</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>组织名字</p>
         */
        @NameInMap("corpName")
        public String corpName;

        /**
         * <p>组织行业名称</p>
         */
        @NameInMap("industry")
        public String industry;

        /**
         * <p>组织行业码</p>
         */
        @NameInMap("industryCode")
        public Integer industryCode;

        /**
         * <p>区域码</p>
         */
        @NameInMap("regionId")
        public String regionId;

        /**
         * <p>区域详细信息</p>
         */
        @NameInMap("regionLocation")
        public String regionLocation;

        /**
         * <p>区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区</p>
         */
        @NameInMap("regionType")
        public String regionType;

        public static ListSubCorpsResponseBodyCorpList build(java.util.Map<String, ?> map) throws Exception {
            ListSubCorpsResponseBodyCorpList self = new ListSubCorpsResponseBodyCorpList();
            return TeaModel.build(map, self);
        }

        public ListSubCorpsResponseBodyCorpList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListSubCorpsResponseBodyCorpList setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

        public ListSubCorpsResponseBodyCorpList setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public ListSubCorpsResponseBodyCorpList setIndustryCode(Integer industryCode) {
            this.industryCode = industryCode;
            return this;
        }
        public Integer getIndustryCode() {
            return this.industryCode;
        }

        public ListSubCorpsResponseBodyCorpList setRegionId(String regionId) {
            this.regionId = regionId;
            return this;
        }
        public String getRegionId() {
            return this.regionId;
        }

        public ListSubCorpsResponseBodyCorpList setRegionLocation(String regionLocation) {
            this.regionLocation = regionLocation;
            return this;
        }
        public String getRegionLocation() {
            return this.regionLocation;
        }

        public ListSubCorpsResponseBodyCorpList setRegionType(String regionType) {
            this.regionType = regionType;
            return this;
        }
        public String getRegionType() {
            return this.regionType;
        }

    }

}
