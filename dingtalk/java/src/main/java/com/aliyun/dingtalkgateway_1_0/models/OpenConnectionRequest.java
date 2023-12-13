// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgateway_1_0.models;

import com.aliyun.tea.*;

public class OpenConnectionRequest extends TeaModel {
    @NameInMap("clientId")
    public String clientId;

    @NameInMap("clientSecret")
    public String clientSecret;

    @NameInMap("extras")
    public java.util.Map<String, ?> extras;

    @NameInMap("localIp")
    public String localIp;

    @NameInMap("subscriptions")
    public java.util.List<OpenConnectionRequestSubscriptions> subscriptions;

    public static OpenConnectionRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenConnectionRequest self = new OpenConnectionRequest();
        return TeaModel.build(map, self);
    }

    public OpenConnectionRequest setClientId(String clientId) {
        this.clientId = clientId;
        return this;
    }
    public String getClientId() {
        return this.clientId;
    }

    public OpenConnectionRequest setClientSecret(String clientSecret) {
        this.clientSecret = clientSecret;
        return this;
    }
    public String getClientSecret() {
        return this.clientSecret;
    }

    public OpenConnectionRequest setExtras(java.util.Map<String, ?> extras) {
        this.extras = extras;
        return this;
    }
    public java.util.Map<String, ?> getExtras() {
        return this.extras;
    }

    public OpenConnectionRequest setLocalIp(String localIp) {
        this.localIp = localIp;
        return this;
    }
    public String getLocalIp() {
        return this.localIp;
    }

    public OpenConnectionRequest setSubscriptions(java.util.List<OpenConnectionRequestSubscriptions> subscriptions) {
        this.subscriptions = subscriptions;
        return this;
    }
    public java.util.List<OpenConnectionRequestSubscriptions> getSubscriptions() {
        return this.subscriptions;
    }

    public static class OpenConnectionRequestSubscriptions extends TeaModel {
        @NameInMap("topic")
        public String topic;

        @NameInMap("type")
        public String type;

        public static OpenConnectionRequestSubscriptions build(java.util.Map<String, ?> map) throws Exception {
            OpenConnectionRequestSubscriptions self = new OpenConnectionRequestSubscriptions();
            return TeaModel.build(map, self);
        }

        public OpenConnectionRequestSubscriptions setTopic(String topic) {
            this.topic = topic;
            return this;
        }
        public String getTopic() {
            return this.topic;
        }

        public OpenConnectionRequestSubscriptions setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
