// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleItemResponseBody extends TeaModel {
    // 回收项信息
    @NameInMap("item")
    public GetRecycleItemResponseBodyItem item;

    public static GetRecycleItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecycleItemResponseBody self = new GetRecycleItemResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecycleItemResponseBody setItem(GetRecycleItemResponseBodyItem item) {
        this.item = item;
        return this;
    }
    public GetRecycleItemResponseBodyItem getItem() {
        return this.item;
    }

    public static class GetRecycleItemResponseBodyItem extends TeaModel {
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

        public static GetRecycleItemResponseBodyItem build(java.util.Map<String, ?> map) throws Exception {
            GetRecycleItemResponseBodyItem self = new GetRecycleItemResponseBodyItem();
            return TeaModel.build(map, self);
        }

        public GetRecycleItemResponseBodyItem setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public GetRecycleItemResponseBodyItem setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetRecycleItemResponseBodyItem setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public GetRecycleItemResponseBodyItem setOperatorTime(String operatorTime) {
            this.operatorTime = operatorTime;
            return this;
        }
        public String getOperatorTime() {
            return this.operatorTime;
        }

        public GetRecycleItemResponseBodyItem setOriginalName(String originalName) {
            this.originalName = originalName;
            return this;
        }
        public String getOriginalName() {
            return this.originalName;
        }

        public GetRecycleItemResponseBodyItem setOriginalPath(String originalPath) {
            this.originalPath = originalPath;
            return this;
        }
        public String getOriginalPath() {
            return this.originalPath;
        }

        public GetRecycleItemResponseBodyItem setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetRecycleItemResponseBodyItem setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public GetRecycleItemResponseBodyItem setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
