// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSubscribedCalendarResponseBody extends TeaModel {
    /**
     * <p>日历作者</p>
     */
    @NameInMap("author")
    public String author;

    /**
     * <p>订阅日历id</p>
     */
    @NameInMap("calendarId")
    public String calendarId;

    /**
     * <p>日历描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>可管理人群</p>
     */
    @NameInMap("managers")
    public java.util.List<String> managers;

    /**
     * <p>日历名</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>可订阅范围</p>
     */
    @NameInMap("subscribeScope")
    public GetSubscribedCalendarResponseBodySubscribeScope subscribeScope;

    public static GetSubscribedCalendarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSubscribedCalendarResponseBody self = new GetSubscribedCalendarResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSubscribedCalendarResponseBody setAuthor(String author) {
        this.author = author;
        return this;
    }
    public String getAuthor() {
        return this.author;
    }

    public GetSubscribedCalendarResponseBody setCalendarId(String calendarId) {
        this.calendarId = calendarId;
        return this;
    }
    public String getCalendarId() {
        return this.calendarId;
    }

    public GetSubscribedCalendarResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetSubscribedCalendarResponseBody setManagers(java.util.List<String> managers) {
        this.managers = managers;
        return this;
    }
    public java.util.List<String> getManagers() {
        return this.managers;
    }

    public GetSubscribedCalendarResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSubscribedCalendarResponseBody setSubscribeScope(GetSubscribedCalendarResponseBodySubscribeScope subscribeScope) {
        this.subscribeScope = subscribeScope;
        return this;
    }
    public GetSubscribedCalendarResponseBodySubscribeScope getSubscribeScope() {
        return this.subscribeScope;
    }

    public static class GetSubscribedCalendarResponseBodySubscribeScope extends TeaModel {
        /**
         * <p>可订阅组织</p>
         */
        @NameInMap("corpIds")
        public java.util.List<String> corpIds;

        /**
         * <p>可订阅群组</p>
         */
        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        /**
         * <p>可订阅用户</p>
         */
        @NameInMap("unionIds")
        public java.util.List<String> unionIds;

        public static GetSubscribedCalendarResponseBodySubscribeScope build(java.util.Map<String, ?> map) throws Exception {
            GetSubscribedCalendarResponseBodySubscribeScope self = new GetSubscribedCalendarResponseBodySubscribeScope();
            return TeaModel.build(map, self);
        }

        public GetSubscribedCalendarResponseBodySubscribeScope setCorpIds(java.util.List<String> corpIds) {
            this.corpIds = corpIds;
            return this;
        }
        public java.util.List<String> getCorpIds() {
            return this.corpIds;
        }

        public GetSubscribedCalendarResponseBodySubscribeScope setOpenConversationIds(java.util.List<String> openConversationIds) {
            this.openConversationIds = openConversationIds;
            return this;
        }
        public java.util.List<String> getOpenConversationIds() {
            return this.openConversationIds;
        }

        public GetSubscribedCalendarResponseBodySubscribeScope setUnionIds(java.util.List<String> unionIds) {
            this.unionIds = unionIds;
            return this;
        }
        public java.util.List<String> getUnionIds() {
            return this.unionIds;
        }

    }

}
