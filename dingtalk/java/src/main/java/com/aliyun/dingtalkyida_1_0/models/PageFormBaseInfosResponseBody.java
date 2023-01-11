// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageFormBaseInfosResponseBody extends TeaModel {
    /**
     * <p>结果集</p>
     */
    @NameInMap("result")
    public PageFormBaseInfosResponseBodyResult result;

    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PageFormBaseInfosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageFormBaseInfosResponseBody self = new PageFormBaseInfosResponseBody();
        return TeaModel.build(map, self);
    }

    public PageFormBaseInfosResponseBody setResult(PageFormBaseInfosResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PageFormBaseInfosResponseBodyResult getResult() {
        return this.result;
    }

    public PageFormBaseInfosResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PageFormBaseInfosResponseBodyResultDataTitle extends TeaModel {
        @NameInMap("enUS")
        public String enUS;

        @NameInMap("zhCN")
        public String zhCN;

        public static PageFormBaseInfosResponseBodyResultDataTitle build(java.util.Map<String, ?> map) throws Exception {
            PageFormBaseInfosResponseBodyResultDataTitle self = new PageFormBaseInfosResponseBodyResultDataTitle();
            return TeaModel.build(map, self);
        }

        public PageFormBaseInfosResponseBodyResultDataTitle setEnUS(String enUS) {
            this.enUS = enUS;
            return this;
        }
        public String getEnUS() {
            return this.enUS;
        }

        public PageFormBaseInfosResponseBodyResultDataTitle setZhCN(String zhCN) {
            this.zhCN = zhCN;
            return this;
        }
        public String getZhCN() {
            return this.zhCN;
        }

    }

    public static class PageFormBaseInfosResponseBodyResultData extends TeaModel {
        @NameInMap("creator")
        public String creator;

        @NameInMap("formType")
        public String formType;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("title")
        public PageFormBaseInfosResponseBodyResultDataTitle title;

        public static PageFormBaseInfosResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            PageFormBaseInfosResponseBodyResultData self = new PageFormBaseInfosResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public PageFormBaseInfosResponseBodyResultData setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public PageFormBaseInfosResponseBodyResultData setFormType(String formType) {
            this.formType = formType;
            return this;
        }
        public String getFormType() {
            return this.formType;
        }

        public PageFormBaseInfosResponseBodyResultData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public PageFormBaseInfosResponseBodyResultData setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public PageFormBaseInfosResponseBodyResultData setTitle(PageFormBaseInfosResponseBodyResultDataTitle title) {
            this.title = title;
            return this;
        }
        public PageFormBaseInfosResponseBodyResultDataTitle getTitle() {
            return this.title;
        }

    }

    public static class PageFormBaseInfosResponseBodyResult extends TeaModel {
        /**
         * <p>当前页</p>
         */
        @NameInMap("currentPage")
        public Integer currentPage;

        @NameInMap("data")
        public java.util.List<PageFormBaseInfosResponseBodyResultData> data;

        /**
         * <p>总行数</p>
         */
        @NameInMap("totalCount")
        public Integer totalCount;

        public static PageFormBaseInfosResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PageFormBaseInfosResponseBodyResult self = new PageFormBaseInfosResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PageFormBaseInfosResponseBodyResult setCurrentPage(Integer currentPage) {
            this.currentPage = currentPage;
            return this;
        }
        public Integer getCurrentPage() {
            return this.currentPage;
        }

        public PageFormBaseInfosResponseBodyResult setData(java.util.List<PageFormBaseInfosResponseBodyResultData> data) {
            this.data = data;
            return this;
        }
        public java.util.List<PageFormBaseInfosResponseBodyResultData> getData() {
            return this.data;
        }

        public PageFormBaseInfosResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
