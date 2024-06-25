// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkactivity_1_0.models;

import com.aliyun.tea.*;

public class ListActivityResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<ListActivityResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public String maxResults;

    /**
     * <strong>example:</strong>
     * <p>1686633306552</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static ListActivityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListActivityResponseBody self = new ListActivityResponseBody();
        return TeaModel.build(map, self);
    }

    public ListActivityResponseBody setList(java.util.List<ListActivityResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<ListActivityResponseBodyList> getList() {
        return this.list;
    }

    public ListActivityResponseBody setMaxResults(String maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public String getMaxResults() {
        return this.maxResults;
    }

    public ListActivityResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListActivityResponseBodyList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>5tL2HIQiQiOARCZ6xWAPHA02091683513</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <strong>example:</strong>
         * <p>@mediaId</p>
         */
        @NameInMap("bannerMediaId")
        public String bannerMediaId;

        /**
         * <strong>example:</strong>
         * <p>1683515695000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>20230613_001</p>
         */
        @NameInMap("foreignId")
        public String foreignId;

        /**
         * <strong>example:</strong>
         * <p>1683514695000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>AIGC研讨会</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static ListActivityResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            ListActivityResponseBodyList self = new ListActivityResponseBodyList();
            return TeaModel.build(map, self);
        }

        public ListActivityResponseBodyList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public ListActivityResponseBodyList setBannerMediaId(String bannerMediaId) {
            this.bannerMediaId = bannerMediaId;
            return this;
        }
        public String getBannerMediaId() {
            return this.bannerMediaId;
        }

        public ListActivityResponseBodyList setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public ListActivityResponseBodyList setForeignId(String foreignId) {
            this.foreignId = foreignId;
            return this;
        }
        public String getForeignId() {
            return this.foreignId;
        }

        public ListActivityResponseBodyList setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public ListActivityResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListActivityResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ListActivityResponseBodyList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListActivityResponseBodyList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
