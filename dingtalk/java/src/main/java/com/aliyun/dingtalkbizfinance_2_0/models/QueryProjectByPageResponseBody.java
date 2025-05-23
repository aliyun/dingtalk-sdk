// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryProjectByPageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<QueryProjectByPageResponseBodyList> list;

    public static QueryProjectByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProjectByPageResponseBody self = new QueryProjectByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProjectByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryProjectByPageResponseBody setList(java.util.List<QueryProjectByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryProjectByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class QueryProjectByPageResponseBodyList extends TeaModel {
        @NameInMap("caode")
        public String caode;

        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1631524595555</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>aaaa</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <strong>example:</strong>
         * <p>外派项目</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public String name;

        @NameInMap("parentCode")
        public String parentCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROJ-xxx</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>外派项目</p>
         */
        @NameInMap("projectName")
        public String projectName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>valid</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("userDefineCode")
        public String userDefineCode;

        public static QueryProjectByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectByPageResponseBodyList self = new QueryProjectByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryProjectByPageResponseBodyList setCaode(String caode) {
            this.caode = caode;
            return this;
        }
        public String getCaode() {
            return this.caode;
        }

        public QueryProjectByPageResponseBodyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryProjectByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryProjectByPageResponseBodyList setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public QueryProjectByPageResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryProjectByPageResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProjectByPageResponseBodyList setParentCode(String parentCode) {
            this.parentCode = parentCode;
            return this;
        }
        public String getParentCode() {
            return this.parentCode;
        }

        public QueryProjectByPageResponseBodyList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public QueryProjectByPageResponseBodyList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public QueryProjectByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryProjectByPageResponseBodyList setUserDefineCode(String userDefineCode) {
            this.userDefineCode = userDefineCode;
            return this;
        }
        public String getUserDefineCode() {
            return this.userDefineCode;
        }

    }

}
