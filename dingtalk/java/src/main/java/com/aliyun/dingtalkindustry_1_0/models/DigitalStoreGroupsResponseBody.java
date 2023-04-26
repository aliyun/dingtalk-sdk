// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStoreGroupsResponseBodyContent> content;

    public static DigitalStoreGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupsResponseBody self = new DigitalStoreGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupsResponseBody setContent(java.util.List<DigitalStoreGroupsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreGroupsResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreGroupsResponseBodyContent extends TeaModel {
        @NameInMap("groupId")
        public Long groupId;

        @NameInMap("groupName")
        public String groupName;

        public static DigitalStoreGroupsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreGroupsResponseBodyContent self = new DigitalStoreGroupsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreGroupsResponseBodyContent setGroupId(Long groupId) {
            this.groupId = groupId;
            return this;
        }
        public Long getGroupId() {
            return this.groupId;
        }

        public DigitalStoreGroupsResponseBodyContent setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

    }

}
