// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentSubDeptsResponseBody extends TeaModel {
    @NameInMap("departmentList")
    public java.util.List<ListResidentSubDeptsResponseBodyDepartmentList> departmentList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("total")
    public Long total;

    public static ListResidentSubDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentSubDeptsResponseBody self = new ListResidentSubDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentSubDeptsResponseBody setDepartmentList(java.util.List<ListResidentSubDeptsResponseBodyDepartmentList> departmentList) {
        this.departmentList = departmentList;
        return this;
    }
    public java.util.List<ListResidentSubDeptsResponseBodyDepartmentList> getDepartmentList() {
        return this.departmentList;
    }

    public ListResidentSubDeptsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListResidentSubDeptsResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public ListResidentSubDeptsResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class ListResidentSubDeptsResponseBodyDepartmentList extends TeaModel {
        @NameInMap("departmentId")
        public Long departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("superDepartmentId")
        public Long superDepartmentId;

        public static ListResidentSubDeptsResponseBodyDepartmentList build(java.util.Map<String, ?> map) throws Exception {
            ListResidentSubDeptsResponseBodyDepartmentList self = new ListResidentSubDeptsResponseBodyDepartmentList();
            return TeaModel.build(map, self);
        }

        public ListResidentSubDeptsResponseBodyDepartmentList setDepartmentId(Long departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public Long getDepartmentId() {
            return this.departmentId;
        }

        public ListResidentSubDeptsResponseBodyDepartmentList setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public ListResidentSubDeptsResponseBodyDepartmentList setSuperDepartmentId(Long superDepartmentId) {
            this.superDepartmentId = superDepartmentId;
            return this;
        }
        public Long getSuperDepartmentId() {
            return this.superDepartmentId;
        }

    }

}
