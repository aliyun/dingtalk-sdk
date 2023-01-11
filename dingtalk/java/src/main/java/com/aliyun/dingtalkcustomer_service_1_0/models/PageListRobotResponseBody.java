// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListRobotResponseBody extends TeaModel {
    /**
     * <p>是否有更多结果</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>查询结果列表</p>
     */
    @NameInMap("list")
    public java.util.List<PageListRobotResponseBodyList> list;

    /**
     * <p>下一次查询起始游标</p>
     */
    @NameInMap("nextCursor")
    public Long nextCursor;

    /**
     * <p>查询结果总数</p>
     */
    @NameInMap("total")
    public Long total;

    public static PageListRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListRobotResponseBody self = new PageListRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListRobotResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public PageListRobotResponseBody setList(java.util.List<PageListRobotResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PageListRobotResponseBodyList> getList() {
        return this.list;
    }

    public PageListRobotResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public PageListRobotResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class PageListRobotResponseBodyList extends TeaModel {
        /**
         * <p>机器人所在租户ID</p>
         */
        @NameInMap("accountId")
        public Long accountId;

        /**
         * <p>机器人APPKEY</p>
         */
        @NameInMap("appKey")
        public String appKey;

        /**
         * <p>机器人自增Id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>机器人名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>机器人状态</p>
         */
        @NameInMap("status")
        public Integer status;

        public static PageListRobotResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PageListRobotResponseBodyList self = new PageListRobotResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PageListRobotResponseBodyList setAccountId(Long accountId) {
            this.accountId = accountId;
            return this;
        }
        public Long getAccountId() {
            return this.accountId;
        }

        public PageListRobotResponseBodyList setAppKey(String appKey) {
            this.appKey = appKey;
            return this;
        }
        public String getAppKey() {
            return this.appKey;
        }

        public PageListRobotResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public PageListRobotResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PageListRobotResponseBodyList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
