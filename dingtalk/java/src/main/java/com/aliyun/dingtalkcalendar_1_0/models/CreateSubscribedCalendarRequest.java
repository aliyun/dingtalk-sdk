// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateSubscribedCalendarRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("managers")
    public java.util.List<String> managers;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subscribeScope")
    public CreateSubscribedCalendarRequestSubscribeScope subscribeScope;

    public static CreateSubscribedCalendarRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSubscribedCalendarRequest self = new CreateSubscribedCalendarRequest();
        return TeaModel.build(map, self);
    }

    public CreateSubscribedCalendarRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateSubscribedCalendarRequest setManagers(java.util.List<String> managers) {
        this.managers = managers;
        return this;
    }
    public java.util.List<String> getManagers() {
        return this.managers;
    }

    public CreateSubscribedCalendarRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSubscribedCalendarRequest setSubscribeScope(CreateSubscribedCalendarRequestSubscribeScope subscribeScope) {
        this.subscribeScope = subscribeScope;
        return this;
    }
    public CreateSubscribedCalendarRequestSubscribeScope getSubscribeScope() {
        return this.subscribeScope;
    }

    public static class CreateSubscribedCalendarRequestSubscribeScope extends TeaModel {
        @NameInMap("corpIds")
        public java.util.List<String> corpIds;

        @NameInMap("openConversationIds")
        public java.util.List<String> openConversationIds;

        @NameInMap("unionIds")
        public java.util.List<String> unionIds;

        public static CreateSubscribedCalendarRequestSubscribeScope build(java.util.Map<String, ?> map) throws Exception {
            CreateSubscribedCalendarRequestSubscribeScope self = new CreateSubscribedCalendarRequestSubscribeScope();
            return TeaModel.build(map, self);
        }

        public CreateSubscribedCalendarRequestSubscribeScope setCorpIds(java.util.List<String> corpIds) {
            this.corpIds = corpIds;
            return this;
        }
        public java.util.List<String> getCorpIds() {
            return this.corpIds;
        }

        public CreateSubscribedCalendarRequestSubscribeScope setOpenConversationIds(java.util.List<String> openConversationIds) {
            this.openConversationIds = openConversationIds;
            return this;
        }
        public java.util.List<String> getOpenConversationIds() {
            return this.openConversationIds;
        }

        public CreateSubscribedCalendarRequestSubscribeScope setUnionIds(java.util.List<String> unionIds) {
            this.unionIds = unionIds;
            return this;
        }
        public java.util.List<String> getUnionIds() {
            return this.unionIds;
        }

    }

}
