// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<CustomizeContactEmpListResponseBodyContent> content;

    public static CustomizeContactEmpListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpListResponseBody self = new CustomizeContactEmpListResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpListResponseBody setContent(java.util.List<CustomizeContactEmpListResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CustomizeContactEmpListResponseBodyContent> getContent() {
        return this.content;
    }

    public static class CustomizeContactEmpListResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CustomizeContactEmpListResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            CustomizeContactEmpListResponseBodyContent self = new CustomizeContactEmpListResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public CustomizeContactEmpListResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CustomizeContactEmpListResponseBodyContent setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
