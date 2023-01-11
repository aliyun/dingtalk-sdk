// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUsersResponseBody extends TeaModel {
    /**
     * <p>人员列表</p>
     */
    @NameInMap("content")
    public java.util.List<DigitalStoreUsersResponseBodyContent> content;

    public static DigitalStoreUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUsersResponseBody self = new DigitalStoreUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUsersResponseBody setContent(java.util.List<DigitalStoreUsersResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreUsersResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreUsersResponseBodyContent extends TeaModel {
        /**
         * <p>人员姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>人员Id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static DigitalStoreUsersResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreUsersResponseBodyContent self = new DigitalStoreUsersResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreUsersResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DigitalStoreUsersResponseBodyContent setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
