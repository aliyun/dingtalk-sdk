// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetDeptsByOrgIdResponseBody extends TeaModel {
    // deptList
    @NameInMap("deptList")
    public java.util.List<GetDeptsByOrgIdResponseBodyDeptList> deptList;

    // hasMore
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("maxResults")
    public Integer maxResults;

    // nextCursor
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetDeptsByOrgIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeptsByOrgIdResponseBody self = new GetDeptsByOrgIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeptsByOrgIdResponseBody setDeptList(java.util.List<GetDeptsByOrgIdResponseBodyDeptList> deptList) {
        this.deptList = deptList;
        return this;
    }
    public java.util.List<GetDeptsByOrgIdResponseBodyDeptList> getDeptList() {
        return this.deptList;
    }

    public GetDeptsByOrgIdResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetDeptsByOrgIdResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetDeptsByOrgIdResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class GetDeptsByOrgIdResponseBodyDeptList extends TeaModel {
        // id
        @NameInMap("dept_id")
        public Long deptId;

        // name
        @NameInMap("name")
        public String name;

        // parentId
        @NameInMap("parent_id")
        public Long parentId;

        public static GetDeptsByOrgIdResponseBodyDeptList build(java.util.Map<String, ?> map) throws Exception {
            GetDeptsByOrgIdResponseBodyDeptList self = new GetDeptsByOrgIdResponseBodyDeptList();
            return TeaModel.build(map, self);
        }

        public GetDeptsByOrgIdResponseBodyDeptList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public GetDeptsByOrgIdResponseBodyDeptList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetDeptsByOrgIdResponseBodyDeptList setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

    }

}
