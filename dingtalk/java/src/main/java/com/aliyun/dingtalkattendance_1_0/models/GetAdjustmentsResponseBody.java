// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetAdjustmentsResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public java.util.List<GetAdjustmentsResponseBodyResult> result;

    public static GetAdjustmentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAdjustmentsResponseBody self = new GetAdjustmentsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAdjustmentsResponseBody setResult(java.util.List<GetAdjustmentsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetAdjustmentsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetAdjustmentsResponseBodyResultItems extends TeaModel {
        // 补卡规则id
        @NameInMap("id")
        public Long id;

        // 补卡规则名称
        @NameInMap("name")
        public String name;

        @NameInMap("settingId")
        public Long settingId;

        public static GetAdjustmentsResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetAdjustmentsResponseBodyResultItems self = new GetAdjustmentsResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public GetAdjustmentsResponseBodyResultItems setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetAdjustmentsResponseBodyResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAdjustmentsResponseBodyResultItems setSettingId(Long settingId) {
            this.settingId = settingId;
            return this;
        }
        public Long getSettingId() {
            return this.settingId;
        }

    }

    public static class GetAdjustmentsResponseBodyResult extends TeaModel {
        // 补卡规则集合
        @NameInMap("items")
        public java.util.List<GetAdjustmentsResponseBodyResultItems> items;

        // 当前页码
        @NameInMap("pageNumber")
        public Long pageNumber;

        // 总页数
        @NameInMap("totalPage")
        public Long totalPage;

        public static GetAdjustmentsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAdjustmentsResponseBodyResult self = new GetAdjustmentsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAdjustmentsResponseBodyResult setItems(java.util.List<GetAdjustmentsResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<GetAdjustmentsResponseBodyResultItems> getItems() {
            return this.items;
        }

        public GetAdjustmentsResponseBodyResult setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetAdjustmentsResponseBodyResult setTotalPage(Long totalPage) {
            this.totalPage = totalPage;
            return this;
        }
        public Long getTotalPage() {
            return this.totalPage;
        }

    }

}
