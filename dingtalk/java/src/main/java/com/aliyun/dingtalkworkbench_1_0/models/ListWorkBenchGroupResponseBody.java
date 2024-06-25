// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ListWorkBenchGroupResponseBody extends TeaModel {
    @NameInMap("groupList")
    public java.util.List<ListWorkBenchGroupResponseBodyGroupList> groupList;

    public static ListWorkBenchGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListWorkBenchGroupResponseBody self = new ListWorkBenchGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public ListWorkBenchGroupResponseBody setGroupList(java.util.List<ListWorkBenchGroupResponseBodyGroupList> groupList) {
        this.groupList = groupList;
        return this;
    }
    public java.util.List<ListWorkBenchGroupResponseBodyGroupList> getGroupList() {
        return this.groupList;
    }

    public static class ListWorkBenchGroupResponseBodyGroupList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>desc</p>
         */
        @NameInMap("componentId")
        public String componentId;

        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        public static ListWorkBenchGroupResponseBodyGroupList build(java.util.Map<String, ?> map) throws Exception {
            ListWorkBenchGroupResponseBodyGroupList self = new ListWorkBenchGroupResponseBodyGroupList();
            return TeaModel.build(map, self);
        }

        public ListWorkBenchGroupResponseBodyGroupList setComponentId(String componentId) {
            this.componentId = componentId;
            return this;
        }
        public String getComponentId() {
            return this.componentId;
        }

        public ListWorkBenchGroupResponseBodyGroupList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
