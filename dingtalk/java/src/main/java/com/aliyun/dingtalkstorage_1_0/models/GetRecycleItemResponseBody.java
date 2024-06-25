// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleItemResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>dentry_id</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <strong>example:</strong>
         * <p>recycle_item_id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>operator_id</p>
         */
        @NameInMap("operatorId")
        public String operatorId;

        /**
         * <strong>example:</strong>
         * <p>2022-01-01T10:00:00Z</p>
         */
        @NameInMap("operatorTime")
        public String operatorTime;

        /**
         * <strong>example:</strong>
         * <p>dentry_name</p>
         */
        @NameInMap("originalName")
        public String originalName;

        /**
         * <strong>example:</strong>
         * <p>dentry_path</p>
         */
        @NameInMap("originalPath")
        public String originalPath;

        /**
         * <strong>example:</strong>
         * <p>512</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <strong>example:</strong>
         * <p>file</p>
         */
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
