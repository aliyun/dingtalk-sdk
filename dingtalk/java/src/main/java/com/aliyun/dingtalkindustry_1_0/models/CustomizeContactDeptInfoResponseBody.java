// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptInfoResponseBody extends TeaModel {
    // 部门信息
    @NameInMap("content")
    public CustomizeContactDeptInfoResponseBodyContent content;

    public static CustomizeContactDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptInfoResponseBody self = new CustomizeContactDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptInfoResponseBody setContent(CustomizeContactDeptInfoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public CustomizeContactDeptInfoResponseBodyContent getContent() {
        return this.content;
    }

    public static class CustomizeContactDeptInfoResponseBodyContent extends TeaModel {
        // 自定义通讯录Code
        @NameInMap("code")
        public String code;

        // 部门Id
        @NameInMap("id")
        public Long id;

        // 部门主管列表
        @NameInMap("managerIdList")
        public java.util.List<String> managerIdList;

        // 部门名称
        @NameInMap("name")
        public String name;

        // 部门排序
        @NameInMap("order")
        public Long order;

        // 上级部门Id
        @NameInMap("parentDeptId")
        public Long parentDeptId;

        // 引用的内部通讯录部门Id
        @NameInMap("refId")
        public Long refId;

        // 部门类型 0:普通部门 1:引用部门
        @NameInMap("type")
        public Long type;

        public static CustomizeContactDeptInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            CustomizeContactDeptInfoResponseBodyContent self = new CustomizeContactDeptInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public CustomizeContactDeptInfoResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CustomizeContactDeptInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public CustomizeContactDeptInfoResponseBodyContent setManagerIdList(java.util.List<String> managerIdList) {
            this.managerIdList = managerIdList;
            return this;
        }
        public java.util.List<String> getManagerIdList() {
            return this.managerIdList;
        }

        public CustomizeContactDeptInfoResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CustomizeContactDeptInfoResponseBodyContent setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public CustomizeContactDeptInfoResponseBodyContent setParentDeptId(Long parentDeptId) {
            this.parentDeptId = parentDeptId;
            return this;
        }
        public Long getParentDeptId() {
            return this.parentDeptId;
        }

        public CustomizeContactDeptInfoResponseBodyContent setRefId(Long refId) {
            this.refId = refId;
            return this;
        }
        public Long getRefId() {
            return this.refId;
        }

        public CustomizeContactDeptInfoResponseBodyContent setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

    }

}
