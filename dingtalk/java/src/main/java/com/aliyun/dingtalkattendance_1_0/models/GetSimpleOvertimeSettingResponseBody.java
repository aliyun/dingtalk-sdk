// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleOvertimeSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSimpleOvertimeSettingResponseBodyResult result;

    public static GetSimpleOvertimeSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleOvertimeSettingResponseBody self = new GetSimpleOvertimeSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSimpleOvertimeSettingResponseBody setResult(GetSimpleOvertimeSettingResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSimpleOvertimeSettingResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetSimpleOvertimeSettingResponseBodyResultItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("settingId")
        public Long settingId;

        public static GetSimpleOvertimeSettingResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleOvertimeSettingResponseBodyResultItems self = new GetSimpleOvertimeSettingResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public GetSimpleOvertimeSettingResponseBodyResultItems setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetSimpleOvertimeSettingResponseBodyResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSimpleOvertimeSettingResponseBodyResultItems setSettingId(Long settingId) {
            this.settingId = settingId;
            return this;
        }
        public Long getSettingId() {
            return this.settingId;
        }

    }

    public static class GetSimpleOvertimeSettingResponseBodyResult extends TeaModel {
        @NameInMap("items")
        public java.util.List<GetSimpleOvertimeSettingResponseBodyResultItems> items;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("pageNumber")
        public Long pageNumber;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("totalPage")
        public Long totalPage;

        public static GetSimpleOvertimeSettingResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleOvertimeSettingResponseBodyResult self = new GetSimpleOvertimeSettingResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSimpleOvertimeSettingResponseBodyResult setItems(java.util.List<GetSimpleOvertimeSettingResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<GetSimpleOvertimeSettingResponseBodyResultItems> getItems() {
            return this.items;
        }

        public GetSimpleOvertimeSettingResponseBodyResult setPageNumber(Long pageNumber) {
            this.pageNumber = pageNumber;
            return this;
        }
        public Long getPageNumber() {
            return this.pageNumber;
        }

        public GetSimpleOvertimeSettingResponseBodyResult setTotalPage(Long totalPage) {
            this.totalPage = totalPage;
            return this;
        }
        public Long getTotalPage() {
            return this.totalPage;
        }

    }

}
