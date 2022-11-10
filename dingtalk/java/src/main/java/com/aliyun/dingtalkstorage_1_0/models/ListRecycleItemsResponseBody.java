// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleItemsResponseBody extends TeaModel {
    // 分页游标
    // 不为空表示有更多数据
    @NameInMap("nextToken")
    public String nextToken;

    // 回收项列表
    // 最大size:
    // 	50
    @NameInMap("recycleItems")
    public java.util.List<ListRecycleItemsResponseBodyRecycleItems> recycleItems;

    public static ListRecycleItemsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleItemsResponseBody self = new ListRecycleItemsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRecycleItemsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecycleItemsResponseBody setRecycleItems(java.util.List<ListRecycleItemsResponseBodyRecycleItems> recycleItems) {
        this.recycleItems = recycleItems;
        return this;
    }
    public java.util.List<ListRecycleItemsResponseBodyRecycleItems> getRecycleItems() {
        return this.recycleItems;
    }

    public static class ListRecycleItemsResponseBodyRecycleItems extends TeaModel {
        // 原文件(夹)id
        @NameInMap("dentryId")
        public String dentryId;

        // 回收项id
        @NameInMap("id")
        public String id;

        // 操作人id
        @NameInMap("operatorId")
        public String operatorId;

        // 删除时间
        @NameInMap("operatorTime")
        public String operatorTime;

        // 原文件(夹)名称
        @NameInMap("originalName")
        public String originalName;

        // 原文件(夹)路径
        @NameInMap("originalPath")
        public String originalPath;

        // 原文件(夹)大小
        @NameInMap("size")
        public Long size;

        // 原文件(夹)所在空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 类型，目录或文件
        // 枚举值:
        // 	FILE: 文件
        // 	FOLDER: 文件夹
        @NameInMap("type")
        public String type;

        public static ListRecycleItemsResponseBodyRecycleItems build(java.util.Map<String, ?> map) throws Exception {
            ListRecycleItemsResponseBodyRecycleItems self = new ListRecycleItemsResponseBodyRecycleItems();
            return TeaModel.build(map, self);
        }

        public ListRecycleItemsResponseBodyRecycleItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public ListRecycleItemsResponseBodyRecycleItems setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListRecycleItemsResponseBodyRecycleItems setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public ListRecycleItemsResponseBodyRecycleItems setOperatorTime(String operatorTime) {
            this.operatorTime = operatorTime;
            return this;
        }
        public String getOperatorTime() {
            return this.operatorTime;
        }

        public ListRecycleItemsResponseBodyRecycleItems setOriginalName(String originalName) {
            this.originalName = originalName;
            return this;
        }
        public String getOriginalName() {
            return this.originalName;
        }

        public ListRecycleItemsResponseBodyRecycleItems setOriginalPath(String originalPath) {
            this.originalPath = originalPath;
            return this;
        }
        public String getOriginalPath() {
            return this.originalPath;
        }

        public ListRecycleItemsResponseBodyRecycleItems setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public ListRecycleItemsResponseBodyRecycleItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListRecycleItemsResponseBodyRecycleItems setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
