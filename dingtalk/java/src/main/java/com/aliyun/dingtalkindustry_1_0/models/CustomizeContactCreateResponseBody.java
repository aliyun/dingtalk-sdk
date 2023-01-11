// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactCreateResponseBody extends TeaModel {
    /**
     * <p>自定义通讯录信息</p>
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
         * <p>自定义通讯录Code</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>自定义通讯录名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>在自定义通讯录列表中的排序</p>
         */
        @NameInMap("order")
        public Long order;

        /**
         * <p>根部们Id</p>
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
