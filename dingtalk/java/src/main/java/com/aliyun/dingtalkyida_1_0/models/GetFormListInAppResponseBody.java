// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormListInAppResponseBody extends TeaModel {
    // 接口返回的结果
    @NameInMap("result")
    public GetFormListInAppResponseBodyResult result;

    // 是否成功，true代表成功
    @NameInMap("success")
    public Boolean success;

    public static GetFormListInAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormListInAppResponseBody self = new GetFormListInAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormListInAppResponseBody setResult(GetFormListInAppResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFormListInAppResponseBodyResult getResult() {
        return this.result;
    }

    public GetFormListInAppResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFormListInAppResponseBodyResultDataTitle extends TeaModel {
        @NameInMap("enUS")
        public String enUS;

        @NameInMap("zhCN")
        public String zhCN;

        public static GetFormListInAppResponseBodyResultDataTitle build(java.util.Map<String, ?> map) throws Exception {
            GetFormListInAppResponseBodyResultDataTitle self = new GetFormListInAppResponseBodyResultDataTitle();
            return TeaModel.build(map, self);
        }

        public GetFormListInAppResponseBodyResultDataTitle setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public GetFormListInAppResponseBodyResultDataTitle setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class GetFormListInAppResponseBodyResultData extends TeaModel {
        @NameInMap("creator")
        public String creator;

        @NameInMap("formType")
        public String formType;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("title")
        public GetFormListInAppResponseBodyResultDataTitle title;

        public static GetFormListInAppResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            GetFormListInAppResponseBodyResultData self = new GetFormListInAppResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public GetFormListInAppResponseBodyResultData setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public GetFormListInAppResponseBodyResultData setFormType(String formType) {
            this.formType = formType;
            return this;
        }
        public String getFormType() {
            return this.formType;
        }

        public GetFormListInAppResponseBodyResultData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetFormListInAppResponseBodyResultData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetFormListInAppResponseBodyResultData setTitle(GetFormListInAppResponseBodyResultDataTitle title) {
            this.title = title;
            return this;
        }
        public GetFormListInAppResponseBodyResultDataTitle getTitle() {
            return this.title;
        }

    }

    public static class GetFormListInAppResponseBodyResult extends TeaModel {
        // 分页参数，当前页码
        @NameInMap("currentPage")
        public Integer currentPage;

        // 返回的表单列表
        @NameInMap("data")
        public java.util.List<GetFormListInAppResponseBodyResultData> data;

        // 符合条件的总数目
        @NameInMap("totalCount")
        public Integer totalCount;

        public static GetFormListInAppResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFormListInAppResponseBodyResult self = new GetFormListInAppResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFormListInAppResponseBodyResult setCurrentPage(Integer currentPage) {
            this.currentPage = currentPage;
            return this;
        }
        public Integer getCurrentPage() {
            return this.currentPage;
        }

        public GetFormListInAppResponseBodyResult setData(java.util.List<GetFormListInAppResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<GetFormListInAppResponseBodyResultData> getData() {
            return this.data;
        }

        public GetFormListInAppResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
