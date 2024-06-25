// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsResponseBody extends TeaModel {
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("corpName")
        public String corpName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("industry")
        public String industry;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>149 区县，148 乡镇街道，145 村， 150 社区， 151 小区</p>
         */
        @NameInMap("industryCode")
        public Integer industryCode;

        @NameInMap("regionId")
        public String regionId;

        /**
         * <strong>example:</strong>
         * <p>浙江省_杭州市_余杭区_仓前街道</p>
         */
        @NameInMap("regionLocation")
        public String regionLocation;

        /**
         * <p>This parameter is required.</p>
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
