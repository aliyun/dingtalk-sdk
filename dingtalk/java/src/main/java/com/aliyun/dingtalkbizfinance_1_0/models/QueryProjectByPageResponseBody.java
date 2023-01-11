// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectByPageResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>resultList</p>
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
        /**
         * <p>项目code</p>
         */
        @NameInMap("caode")
        public String caode;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public Long createTime;

        /**
         * <p>创建人工号</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <p>描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>项目名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>项目code，废弃，请使用code</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>项目名称，废弃，请使用name</p>
         */
        @NameInMap("projectName")
        public String projectName;

        /**
         * <p>状态: valid, invalid, deleted</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>用户自定义code</p>
         */
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
