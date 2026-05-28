// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktre_1_0.models;

import com.aliyun.tea.*;

public class CreateTicketRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("description")
    public String description;

    @NameInMap("priority")
    public String priority;

    @NameInMap("reporters")
    public java.util.List<CreateTicketRequestReporters> reporters;

    public static CreateTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTicketRequest self = new CreateTicketRequest();
        return TeaModel.build(map, self);
    }

    public CreateTicketRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateTicketRequest setPriority(String priority) {
        this.priority = priority;
        return this;
    }
    public String getPriority() {
        return this.priority;
    }

    public CreateTicketRequest setReporters(java.util.List<CreateTicketRequestReporters> reporters) {
        this.reporters = reporters;
        return this;
    }
    public java.util.List<CreateTicketRequestReporters> getReporters() {
        return this.reporters;
    }

    public static class CreateTicketRequestReporters extends TeaModel {
        @NameInMap("carrier")
        public String carrier;

        @NameInMap("phone")
        public String phone;

        @NameInMap("region")
        public String region;

        @NameInMap("role")
        public String role;

        @NameInMap("screenshots")
        public java.util.List<String> screenshots;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("uid")
        public String uid;

        @NameInMap("version")
        public String version;

        public static CreateTicketRequestReporters build(java.util.Map<String, ?> map) throws Exception {
            CreateTicketRequestReporters self = new CreateTicketRequestReporters();
            return TeaModel.build(map, self);
        }

        public CreateTicketRequestReporters setCarrier(String carrier) {
            this.carrier = carrier;
            return this;
        }
        public String getCarrier() {
            return this.carrier;
        }

        public CreateTicketRequestReporters setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public String getPhone() {
            return this.phone;
        }

        public CreateTicketRequestReporters setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public CreateTicketRequestReporters setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public CreateTicketRequestReporters setScreenshots(java.util.List<String> screenshots) {
            this.screenshots = screenshots;
            return this;
        }
        public java.util.List<String> getScreenshots() {
            return this.screenshots;
        }

        public CreateTicketRequestReporters setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public CreateTicketRequestReporters setUid(String uid) {
            this.uid = uid;
            return this;
        }
        public String getUid() {
            return this.uid;
        }

        public CreateTicketRequestReporters setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
