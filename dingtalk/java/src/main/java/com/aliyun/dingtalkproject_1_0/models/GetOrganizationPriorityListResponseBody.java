// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationPriorityListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetOrganizationPriorityListResponseBodyResult> result;

    public static GetOrganizationPriorityListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationPriorityListResponseBody self = new GetOrganizationPriorityListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrganizationPriorityListResponseBody setResult(java.util.List<GetOrganizationPriorityListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetOrganizationPriorityListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetOrganizationPriorityListResponseBodyResult extends TeaModel {
        @NameInMap("color")
        public String color;

        @NameInMap("name")
        public String name;

        @NameInMap("priority")
        public String priority;

        @NameInMap("priorityId")
        public String priorityId;

        public static GetOrganizationPriorityListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationPriorityListResponseBodyResult self = new GetOrganizationPriorityListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOrganizationPriorityListResponseBodyResult setColor(String color) {
            this.color = color;
            return this;
        }
        public String getColor() {
            return this.color;
        }

        public GetOrganizationPriorityListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetOrganizationPriorityListResponseBodyResult setPriority(String priority) {
            this.priority = priority;
            return this;
        }
        public String getPriority() {
            return this.priority;
        }

        public GetOrganizationPriorityListResponseBodyResult setPriorityId(String priorityId) {
            this.priorityId = priorityId;
            return this;
        }
        public String getPriorityId() {
            return this.priorityId;
        }

    }

}
