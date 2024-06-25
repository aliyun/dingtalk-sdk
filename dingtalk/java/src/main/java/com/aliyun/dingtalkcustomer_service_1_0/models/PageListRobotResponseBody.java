// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListRobotResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<PageListRobotResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("nextCursor")
    public Long nextCursor;

    /**
     * <strong>example:</strong>
     * <p>90</p>
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
         * <strong>example:</strong>
         * <p>32001</p>
         */
        @NameInMap("accountId")
        public Long accountId;

        /**
         * <strong>example:</strong>
         * <p>U1xup2nKKQ9zwXynjpAHVDOD</p>
         */
        @NameInMap("appKey")
        public String appKey;

        /**
         * <strong>example:</strong>
         * <p>62703378</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>测试的机器人</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
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
