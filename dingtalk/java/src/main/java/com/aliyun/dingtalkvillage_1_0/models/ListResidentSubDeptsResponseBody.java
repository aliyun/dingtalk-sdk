// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentSubDeptsResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListResidentSubDeptsResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("total")
    public Long total;

    public static ListResidentSubDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentSubDeptsResponseBody self = new ListResidentSubDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentSubDeptsResponseBody setList(java.util.List<ListResidentSubDeptsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListResidentSubDeptsResponseBodyList> getList() {
        return this.list;
    }

    public ListResidentSubDeptsResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListResidentSubDeptsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListResidentSubDeptsResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class ListResidentSubDeptsResponseBodyList extends TeaModel {
        @NameInMap("deptId")
        public Long deptId;

        @NameInMap("name")
        public String name;

        @NameInMap("superId")
        public Long superId;

        public static ListResidentSubDeptsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentSubDeptsResponseBodyList self = new ListResidentSubDeptsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListResidentSubDeptsResponseBodyList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListResidentSubDeptsResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentSubDeptsResponseBodyList setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
