// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationPriorityListResponseBody extends TeaModel {
    // 优先级列表
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

    public static class GetOrganizationPriorityListResponseBodyResultPayloadLocalesName extends TeaModel {
        // 英文名
        @NameInMap("en")
        public String en;

        // 中文名
        @NameInMap("zh")
        public String zh;

        public static GetOrganizationPriorityListResponseBodyResultPayloadLocalesName build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationPriorityListResponseBodyResultPayloadLocalesName self = new GetOrganizationPriorityListResponseBodyResultPayloadLocalesName();
            return TeaModel.build(map, self);
        }

        public GetOrganizationPriorityListResponseBodyResultPayloadLocalesName setEn(String en) {
            this.en = en;
            return this;
        }
        public String getEn() {
            return this.en;
        }

        public GetOrganizationPriorityListResponseBodyResultPayloadLocalesName setZh(String zh) {
            this.zh = zh;
            return this;
        }
        public String getZh() {
            return this.zh;
        }

    }

    public static class GetOrganizationPriorityListResponseBodyResultPayloadLocales extends TeaModel {
        // 名称
        @NameInMap("name")
        public GetOrganizationPriorityListResponseBodyResultPayloadLocalesName name;

        public static GetOrganizationPriorityListResponseBodyResultPayloadLocales build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationPriorityListResponseBodyResultPayloadLocales self = new GetOrganizationPriorityListResponseBodyResultPayloadLocales();
            return TeaModel.build(map, self);
        }

        public GetOrganizationPriorityListResponseBodyResultPayloadLocales setName(GetOrganizationPriorityListResponseBodyResultPayloadLocalesName name) {
            this.name = name;
            return this;
        }
        public GetOrganizationPriorityListResponseBodyResultPayloadLocalesName getName() {
            return this.name;
        }

    }

    public static class GetOrganizationPriorityListResponseBodyResultPayload extends TeaModel {
        // 优先级多语言
        @NameInMap("locales")
        public GetOrganizationPriorityListResponseBodyResultPayloadLocales locales;

        public static GetOrganizationPriorityListResponseBodyResultPayload build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationPriorityListResponseBodyResultPayload self = new GetOrganizationPriorityListResponseBodyResultPayload();
            return TeaModel.build(map, self);
        }

        public GetOrganizationPriorityListResponseBodyResultPayload setLocales(GetOrganizationPriorityListResponseBodyResultPayloadLocales locales) {
            this.locales = locales;
            return this;
        }
        public GetOrganizationPriorityListResponseBodyResultPayloadLocales getLocales() {
            return this.locales;
        }

    }

    public static class GetOrganizationPriorityListResponseBodyResult extends TeaModel {
        // 颜色
        @NameInMap("color")
        public String color;

        // 名称
        @NameInMap("name")
        public String name;

        // 额外信息
        @NameInMap("payload")
        public GetOrganizationPriorityListResponseBodyResultPayload payload;

        // 优先级值
        @NameInMap("priority")
        public String priority;

        // id
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

        public GetOrganizationPriorityListResponseBodyResult setPayload(GetOrganizationPriorityListResponseBodyResultPayload payload) {
            this.payload = payload;
            return this;
        }
        public GetOrganizationPriorityListResponseBodyResultPayload getPayload() {
            return this.payload;
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
