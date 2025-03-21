// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class ListInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListInstanceResponseBodyResult> result;

    public static ListInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListInstanceResponseBody self = new ListInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public ListInstanceResponseBody setResult(java.util.List<ListInstanceResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListInstanceResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListInstanceResponseBodyResult extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public String icon;

        @NameInMap("name")
        public String name;

        @NameInMap("prototypeAssistantId")
        public String prototypeAssistantId;

        @NameInMap("tenantAssistantId")
        public String tenantAssistantId;

        public static ListInstanceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListInstanceResponseBodyResult self = new ListInstanceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListInstanceResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListInstanceResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListInstanceResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListInstanceResponseBodyResult setPrototypeAssistantId(String prototypeAssistantId) {
            this.prototypeAssistantId = prototypeAssistantId;
            return this;
        }
        public String getPrototypeAssistantId() {
            return this.prototypeAssistantId;
        }

        public ListInstanceResponseBodyResult setTenantAssistantId(String tenantAssistantId) {
            this.tenantAssistantId = tenantAssistantId;
            return this;
        }
        public String getTenantAssistantId() {
            return this.tenantAssistantId;
        }

    }

}
