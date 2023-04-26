// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListRobotResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<PageListRobotResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

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
        @NameInMap("accountId")
        public Long accountId;

        @NameInMap("appKey")
        public String appKey;

        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

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
