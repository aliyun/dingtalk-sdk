// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertDropdownListsRequest extends TeaModel {
    @NameInMap("options")
    public java.util.List<InsertDropdownListsRequestOptions> options;

    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static InsertDropdownListsRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertDropdownListsRequest self = new InsertDropdownListsRequest();
        return TeaModel.build(map, self);
    }

    public InsertDropdownListsRequest setOptions(java.util.List<InsertDropdownListsRequestOptions> options) {
        this.options = options;
        return this;
    }
    public java.util.List<InsertDropdownListsRequestOptions> getOptions() {
        return this.options;
    }

    public InsertDropdownListsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class InsertDropdownListsRequestOptions extends TeaModel {
        @NameInMap("color")
        public String color;

        @NameInMap("value")
        public String value;

        public static InsertDropdownListsRequestOptions build(java.util.Map<String, ?> map) throws Exception {
            InsertDropdownListsRequestOptions self = new InsertDropdownListsRequestOptions();
            return TeaModel.build(map, self);
        }

        public InsertDropdownListsRequestOptions setColor(String color) {
            this.color = color;
            return this;
        }
        public String getColor() {
            return this.color;
        }

        public InsertDropdownListsRequestOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
