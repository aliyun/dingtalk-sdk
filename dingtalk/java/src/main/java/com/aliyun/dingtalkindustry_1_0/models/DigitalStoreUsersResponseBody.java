// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUsersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>112121341231</p>
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
