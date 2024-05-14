// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<CustomizeContactListResponseBodyContent> content;

    public static CustomizeContactListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactListResponseBody self = new CustomizeContactListResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactListResponseBody setContent(java.util.List<CustomizeContactListResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<CustomizeContactListResponseBodyContent> getContent() {
        return this.content;
    }

    public static class CustomizeContactListResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("order")
        public Long order;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("rootDeptId")
        public Long rootDeptId;

        public static CustomizeContactListResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            CustomizeContactListResponseBodyContent self = new CustomizeContactListResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public CustomizeContactListResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CustomizeContactListResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CustomizeContactListResponseBodyContent setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public CustomizeContactListResponseBodyContent setRootDeptId(Long rootDeptId) {
            this.rootDeptId = rootDeptId;
            return this;
        }
        public Long getRootDeptId() {
            return this.rootDeptId;
        }

    }

}
