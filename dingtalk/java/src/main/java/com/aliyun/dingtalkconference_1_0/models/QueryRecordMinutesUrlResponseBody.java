// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryRecordMinutesUrlResponseBody extends TeaModel {
    @NameInMap("recordMinutesUrls")
    public java.util.List<QueryRecordMinutesUrlResponseBodyRecordMinutesUrls> recordMinutesUrls;

    public static QueryRecordMinutesUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRecordMinutesUrlResponseBody self = new QueryRecordMinutesUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRecordMinutesUrlResponseBody setRecordMinutesUrls(java.util.List<QueryRecordMinutesUrlResponseBodyRecordMinutesUrls> recordMinutesUrls) {
        this.recordMinutesUrls = recordMinutesUrls;
        return this;
    }
    public java.util.List<QueryRecordMinutesUrlResponseBodyRecordMinutesUrls> getRecordMinutesUrls() {
        return this.recordMinutesUrls;
    }

    public static class QueryRecordMinutesUrlResponseBodyRecordMinutesUrls extends TeaModel {
        @NameInMap("recordMinutesUrl")
        public String recordMinutesUrl;

        public static QueryRecordMinutesUrlResponseBodyRecordMinutesUrls build(java.util.Map<String, ?> map) throws Exception {
            QueryRecordMinutesUrlResponseBodyRecordMinutesUrls self = new QueryRecordMinutesUrlResponseBodyRecordMinutesUrls();
            return TeaModel.build(map, self);
        }

        public QueryRecordMinutesUrlResponseBodyRecordMinutesUrls setRecordMinutesUrl(String recordMinutesUrl) {
            this.recordMinutesUrl = recordMinutesUrl;
            return this;
        }
        public String getRecordMinutesUrl() {
            return this.recordMinutesUrl;
        }

    }

}
