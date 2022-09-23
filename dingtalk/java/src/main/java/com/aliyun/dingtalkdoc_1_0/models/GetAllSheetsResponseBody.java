// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetAllSheetsResponseBody extends TeaModel {
    // 所有工作表信息
    @NameInMap("value")
    public java.util.List<GetAllSheetsResponseBodyValue> value;

    public static GetAllSheetsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllSheetsResponseBody self = new GetAllSheetsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllSheetsResponseBody setValue(java.util.List<GetAllSheetsResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<GetAllSheetsResponseBodyValue> getValue() {
        return this.value;
    }

    public static class GetAllSheetsResponseBodyValue extends TeaModel {
        // 工作表ID
        @NameInMap("id")
        public String id;

        // 工作表名称
        @NameInMap("name")
        public String name;

        public static GetAllSheetsResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            GetAllSheetsResponseBodyValue self = new GetAllSheetsResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public GetAllSheetsResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllSheetsResponseBodyValue setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
