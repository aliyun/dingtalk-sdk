// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetProjectGroupResponseBody extends TeaModel {
    // 返回结果对象
    @NameInMap("result")
    public java.util.List<GetProjectGroupResponseBodyResult> result;

    public static GetProjectGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectGroupResponseBody self = new GetProjectGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectGroupResponseBody setResult(java.util.List<GetProjectGroupResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectGroupResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectGroupResponseBodyResult extends TeaModel {
        // 创建时间
        @NameInMap("created")
        public String created;

        // 分组ID
        @NameInMap("id")
        public String id;

        // 分组名字
        @NameInMap("name")
        public String name;

        // 更新时间
        @NameInMap("updated")
        public String updated;

        // 分组可见性。organization 或者 involves
        @NameInMap("visible")
        public String visible;

        public static GetProjectGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectGroupResponseBodyResult self = new GetProjectGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectGroupResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetProjectGroupResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetProjectGroupResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProjectGroupResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetProjectGroupResponseBodyResult setVisible(String visible) {
            this.visible = visible;
            return this;
        }
        public String getVisible() {
            return this.visible;
        }

    }

}
