// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesChaptersResponseBody extends TeaModel {
    @NameInMap("chapterList")
    public java.util.List<QueryMinutesChaptersResponseBodyChapterList> chapterList;

    @NameInMap("status")
    public Integer status;

    public static QueryMinutesChaptersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesChaptersResponseBody self = new QueryMinutesChaptersResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesChaptersResponseBody setChapterList(java.util.List<QueryMinutesChaptersResponseBodyChapterList> chapterList) {
        this.chapterList = chapterList;
        return this;
    }
    public java.util.List<QueryMinutesChaptersResponseBodyChapterList> getChapterList() {
        return this.chapterList;
    }

    public QueryMinutesChaptersResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public static class QueryMinutesChaptersResponseBodyChapterList extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("title")
        public String title;

        @NameInMap("uuid")
        public String uuid;

        public static QueryMinutesChaptersResponseBodyChapterList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesChaptersResponseBodyChapterList self = new QueryMinutesChaptersResponseBodyChapterList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesChaptersResponseBodyChapterList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryMinutesChaptersResponseBodyChapterList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public QueryMinutesChaptersResponseBodyChapterList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public QueryMinutesChaptersResponseBodyChapterList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryMinutesChaptersResponseBodyChapterList setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
