// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPageResponseBody extends TeaModel {
    /**
     * <p>resultList</p>
     */
    @NameInMap("list")
    public java.util.List<PullDataByPageResponseBodyList> list;

    /**
     * <p>单次获取的最大记录条数。</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>用于查看下一页数据的游标，如果为空则说明没有更多数据了。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static PullDataByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPageResponseBody self = new PullDataByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public PullDataByPageResponseBody setList(java.util.List<PullDataByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PullDataByPageResponseBodyList> getList() {
        return this.list;
    }

    public PullDataByPageResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public PullDataByPageResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class PullDataByPageResponseBodyList extends TeaModel {
        /**
         * <p>创建数据的应用id。</p>
         */
        @NameInMap("dataCreateAppId")
        public String dataCreateAppId;

        /**
         * <p>创建数据的应用类型，isv应用为premium_microapp。</p>
         */
        @NameInMap("dataCreateAppType")
        public String dataCreateAppType;

        /**
         * <p>数据创建时间。</p>
         */
        @NameInMap("dataGmtCreate")
        public Long dataGmtCreate;

        /**
         * <p>数据最后修改时间。</p>
         */
        @NameInMap("dataGmtModified")
        public Long dataGmtModified;

        /**
         * <p>最后修改数据的应用id。</p>
         */
        @NameInMap("dataModifiedAppId")
        public String dataModifiedAppId;

        /**
         * <p>最后修改数据的应用类型，取值同dataCreateAppType。</p>
         */
        @NameInMap("dataModifiedAppType")
        public String dataModifiedAppType;

        /**
         * <p>数据完整内容。</p>
         */
        @NameInMap("jsonData")
        public String jsonData;

        public static PullDataByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PullDataByPageResponseBodyList self = new PullDataByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PullDataByPageResponseBodyList setDataCreateAppId(String dataCreateAppId) {
            this.dataCreateAppId = dataCreateAppId;
            return this;
        }
        public String getDataCreateAppId() {
            return this.dataCreateAppId;
        }

        public PullDataByPageResponseBodyList setDataCreateAppType(String dataCreateAppType) {
            this.dataCreateAppType = dataCreateAppType;
            return this;
        }
        public String getDataCreateAppType() {
            return this.dataCreateAppType;
        }

        public PullDataByPageResponseBodyList setDataGmtCreate(Long dataGmtCreate) {
            this.dataGmtCreate = dataGmtCreate;
            return this;
        }
        public Long getDataGmtCreate() {
            return this.dataGmtCreate;
        }

        public PullDataByPageResponseBodyList setDataGmtModified(Long dataGmtModified) {
            this.dataGmtModified = dataGmtModified;
            return this;
        }
        public Long getDataGmtModified() {
            return this.dataGmtModified;
        }

        public PullDataByPageResponseBodyList setDataModifiedAppId(String dataModifiedAppId) {
            this.dataModifiedAppId = dataModifiedAppId;
            return this;
        }
        public String getDataModifiedAppId() {
            return this.dataModifiedAppId;
        }

        public PullDataByPageResponseBodyList setDataModifiedAppType(String dataModifiedAppType) {
            this.dataModifiedAppType = dataModifiedAppType;
            return this;
        }
        public String getDataModifiedAppType() {
            return this.dataModifiedAppType;
        }

        public PullDataByPageResponseBodyList setJsonData(String jsonData) {
            this.jsonData = jsonData;
            return this;
        }
        public String getJsonData() {
            return this.jsonData;
        }

    }

}
