// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactCreateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public CustomizeContactCreateResponseBodyContent content;

    public static CustomizeContactCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactCreateResponseBody self = new CustomizeContactCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactCreateResponseBody setContent(CustomizeContactCreateResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public CustomizeContactCreateResponseBodyContent getContent() {
        return this.content;
    }

    public static class CustomizeContactCreateResponseBodyContent extends TeaModel {
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

        public static CustomizeContactCreateResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            CustomizeContactCreateResponseBodyContent self = new CustomizeContactCreateResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public CustomizeContactCreateResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CustomizeContactCreateResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CustomizeContactCreateResponseBodyContent setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public CustomizeContactCreateResponseBodyContent setRootDeptId(Long rootDeptId) {
            this.rootDeptId = rootDeptId;
            return this;
        }
        public Long getRootDeptId() {
            return this.rootDeptId;
        }

    }

}
