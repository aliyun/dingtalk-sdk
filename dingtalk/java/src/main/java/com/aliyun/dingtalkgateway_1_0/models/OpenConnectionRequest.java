// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgateway_1_0.models;

import com.aliyun.tea.*;

public class OpenConnectionRequest extends TeaModel {
    /**
     * <p>企业三方应用为suiteKey</p>
     * <p>企业自建应用为appKey</p>
     */
    @NameInMap("clientId")
    public String clientId;

    /**
     * <p>企业三方应用为suiteSecret</p>
     * <p>企业自己应用为appSecret</p>
     */
    @NameInMap("clientSecret")
    public String clientSecret;

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

    public OpenConnectionRequest setSubscriptions(java.util.List<OpenConnectionRequestSubscriptions> subscriptions) {
        this.subscriptions = subscriptions;
        return this;
    }
    public java.util.List<OpenConnectionRequestSubscriptions> getSubscriptions() {
        return this.subscriptions;
    }

    public static class OpenConnectionRequestSubscriptions extends TeaModel {
        /**
         * <p>订阅的TOPIC</p>
         */
        @NameInMap("topic")
        public String topic;

        /**
         * <p>订阅类型</p>
         */
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
