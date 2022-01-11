// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectByPageResponseBody extends TeaModel {
    // 是否还有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // resultList
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
        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 创建时间
        @NameInMap("createTime")
        public Long createTime;

        // 创建人工号
        @NameInMap("creator")
        public String creator;

        // 描述
        @NameInMap("description")
        public String description;

        // 项目code
        @NameInMap("projectCode")
        public String projectCode;

        // 项目名称
        @NameInMap("projectName")
        public String projectName;

        // 状态: valid, invalid, deleted
        @NameInMap("status")
        public String status;

        public static QueryProjectByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryProjectByPageResponseBodyList self = new QueryProjectByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryProjectByPageResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
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

    }

}
