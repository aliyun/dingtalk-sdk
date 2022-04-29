// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UpdateSubscribedCalendarsRequest extends TeaModel {
    // 日历介绍
    @NameInMap("description")
    public String description;

    // 日历管理员列表
    @NameInMap("managers")
    public java.util.List<String> managers;

    // 日历名
    @NameInMap("name")
    public String name;

    // 可订阅列表
    @NameInMap("subscribeScope")
    public UpdateSubscribedCalendarsRequestSubscribeScope subscribeScope;

    public static UpdateSubscribedCalendarsRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubscribedCalendarsRequest self = new UpdateSubscribedCalendarsRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSubscribedCalendarsRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public UpdateSubscribedCalendarsRequest setManagers(java.util.List<String> managers) {
        this.managers = managers;
        return this;
    }
    public java.util.List<String> getManagers() {
        return this.managers;
    }

    public UpdateSubscribedCalendarsRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateSubscribedCalendarsRequest setSubscribeScope(UpdateSubscribedCalendarsRequestSubscribeScope subscribeScope) {
        this.subscribeScope = subscribeScope;
        return this;
    }
    public UpdateSubscribedCalendarsRequestSubscribeScope getSubscribeScope() {
        return this.subscribeScope;
    }

    public static class UpdateSubscribedCalendarsRequestSubscribeScope extends TeaModel {
        // 可订阅组织列表
        @NameInMap("corpIds")
        public java.util.List<String> corpIds;

        // 可订阅群组列表
        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        // 可订阅人员列表
        @NameInMap("unionIds")
        public java.util.List<String> unionIds;

        public static UpdateSubscribedCalendarsRequestSubscribeScope build(java.util.Map<String, ?> map) throws Exception {
            UpdateSubscribedCalendarsRequestSubscribeScope self = new UpdateSubscribedCalendarsRequestSubscribeScope();
            return TeaModel.build(map, self);
        }

        public UpdateSubscribedCalendarsRequestSubscribeScope setCorpIds(java.util.List<String> corpIds) {
            this.corpIds = corpIds;
            return this;
        }
        public java.util.List<String> getCorpIds() {
            return this.corpIds;
        }

        public UpdateSubscribedCalendarsRequestSubscribeScope setOpenConversationIds(java.util.List<String> openConversationIds) {
            this.openConversationIds = openConversationIds;
            return this;
        }
        public java.util.List<String> getOpenConversationIds() {
            return this.openConversationIds;
        }

        public UpdateSubscribedCalendarsRequestSubscribeScope setUnionIds(java.util.List<String> unionIds) {
            this.unionIds = unionIds;
            return this;
        }
        public java.util.List<String> getUnionIds() {
            return this.unionIds;
        }

    }

}
