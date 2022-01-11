// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomEntryProcessesResponseBody extends TeaModel {
    // 是否有更多
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 表单信息列表
    @NameInMap("list")
    public java.util.List<QueryCustomEntryProcessesResponseBodyList> list;

    // 下次获取数据的起始游标
    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryCustomEntryProcessesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomEntryProcessesResponseBody self = new QueryCustomEntryProcessesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomEntryProcessesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCustomEntryProcessesResponseBody setList(java.util.List<QueryCustomEntryProcessesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCustomEntryProcessesResponseBodyList> getList() {
        return this.list;
    }

    public QueryCustomEntryProcessesResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryCustomEntryProcessesResponseBodyList extends TeaModel {
        @NameInMap("formDesc")
        public String formDesc;

        @NameInMap("formId")
        public String formId;

        @NameInMap("formName")
        public String formName;

        @NameInMap("shortUrl")
        public String shortUrl;

        public static QueryCustomEntryProcessesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomEntryProcessesResponseBodyList self = new QueryCustomEntryProcessesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCustomEntryProcessesResponseBodyList setFormDesc(String formDesc) {
            this.formDesc = formDesc;
            return this;
        }
        public String getFormDesc() {
            return this.formDesc;
        }

        public QueryCustomEntryProcessesResponseBodyList setFormId(String formId) {
            this.formId = formId;
            return this;
        }
        public String getFormId() {
            return this.formId;
        }

        public QueryCustomEntryProcessesResponseBodyList setFormName(String formName) {
            this.formName = formName;
            return this;
        }
        public String getFormName() {
            return this.formName;
        }

        public QueryCustomEntryProcessesResponseBodyList setShortUrl(String shortUrl) {
            this.shortUrl = shortUrl;
            return this;
        }
        public String getShortUrl() {
            return this.shortUrl;
        }

    }

}
