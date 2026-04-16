// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFilterViewsResponseBody extends TeaModel {
    @NameInMap("filterViews")
    public java.util.List<GetFilterViewsResponseBodyFilterViews> filterViews;

    public static GetFilterViewsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFilterViewsResponseBody self = new GetFilterViewsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFilterViewsResponseBody setFilterViews(java.util.List<GetFilterViewsResponseBodyFilterViews> filterViews) {
        this.filterViews = filterViews;
        return this;
    }
    public java.util.List<GetFilterViewsResponseBodyFilterViews> getFilterViews() {
        return this.filterViews;
    }

    public static class GetFilterViewsResponseBodyFilterViews extends TeaModel {
        @NameInMap("criteria")
        public java.util.Map<String, FilterViewsCriteriaValue> criteria;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("range")
        public String range;

        public static GetFilterViewsResponseBodyFilterViews build(java.util.Map<String, ?> map) throws Exception {
            GetFilterViewsResponseBodyFilterViews self = new GetFilterViewsResponseBodyFilterViews();
            return TeaModel.build(map, self);
        }

        public GetFilterViewsResponseBodyFilterViews setCriteria(java.util.Map<String, FilterViewsCriteriaValue> criteria) {
            this.criteria = criteria;
            return this;
        }
        public java.util.Map<String, FilterViewsCriteriaValue> getCriteria() {
            return this.criteria;
        }

        public GetFilterViewsResponseBodyFilterViews setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetFilterViewsResponseBodyFilterViews setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFilterViewsResponseBodyFilterViews setRange(String range) {
            this.range = range;
            return this;
        }
        public String getRange() {
            return this.range;
        }

    }

}
