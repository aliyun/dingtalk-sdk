// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryDevicesResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<PageQueryDevicesResponseBodyList> list;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Long totalCount;

    public static PageQueryDevicesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageQueryDevicesResponseBody self = new PageQueryDevicesResponseBody();
        return TeaModel.build(map, self);
    }

    public PageQueryDevicesResponseBody setList(java.util.List<PageQueryDevicesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PageQueryDevicesResponseBodyList> getList() {
        return this.list;
    }

    public PageQueryDevicesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public PageQueryDevicesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PageQueryDevicesResponseBodyList extends TeaModel {
        @NameInMap("gmtExpiry")
        public Long gmtExpiry;

        @NameInMap("model")
        public String model;

        @NameInMap("name")
        public String name;

        @NameInMap("sn")
        public String sn;

        @NameInMap("type")
        public String type;

        public static PageQueryDevicesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            PageQueryDevicesResponseBodyList self = new PageQueryDevicesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public PageQueryDevicesResponseBodyList setGmtExpiry(Long gmtExpiry) {
            this.gmtExpiry = gmtExpiry;
            return this;
        }
        public Long getGmtExpiry() {
            return this.gmtExpiry;
        }

        public PageQueryDevicesResponseBodyList setModel(String model) {
            this.model = model;
            return this;
        }
        public String getModel() {
            return this.model;
        }

        public PageQueryDevicesResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PageQueryDevicesResponseBodyList setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

        public PageQueryDevicesResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
