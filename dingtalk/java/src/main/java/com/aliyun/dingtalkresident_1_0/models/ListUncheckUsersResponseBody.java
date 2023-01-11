// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUncheckUsersResponseBody extends TeaModel {
    /**
     * <p>是否仍有数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一个数据序号</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>result</p>
     */
    @NameInMap("values")
    public java.util.List<ListUncheckUsersResponseBodyValues> values;

    public static ListUncheckUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUncheckUsersResponseBody self = new ListUncheckUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUncheckUsersResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListUncheckUsersResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListUncheckUsersResponseBody setValues(java.util.List<ListUncheckUsersResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<ListUncheckUsersResponseBodyValues> getValues() {
        return this.values;
    }

    public static class ListUncheckUsersResponseBodyValues extends TeaModel {
        /**
         * <p>部门ID</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <p>邀请时间</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>邀请更新时间</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <p>是否产权人</p>
         */
        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        /**
         * <p>用户名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>状态</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>用户ID</p>
         */
        @NameInMap("unionId")
        public Long unionId;

        public static ListUncheckUsersResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            ListUncheckUsersResponseBodyValues self = new ListUncheckUsersResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public ListUncheckUsersResponseBodyValues setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListUncheckUsersResponseBodyValues setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListUncheckUsersResponseBodyValues setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public ListUncheckUsersResponseBodyValues setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public ListUncheckUsersResponseBodyValues setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
        }

        public ListUncheckUsersResponseBodyValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListUncheckUsersResponseBodyValues setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListUncheckUsersResponseBodyValues setUnionId(Long unionId) {
            this.unionId = unionId;
            return this;
        }
        public Long getUnionId() {
            return this.unionId;
        }

    }

}
