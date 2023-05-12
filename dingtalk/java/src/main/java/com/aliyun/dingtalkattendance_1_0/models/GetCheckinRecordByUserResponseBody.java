// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetCheckinRecordByUserResponseBody extends TeaModel {
    @NameInMap("result")
    public GetCheckinRecordByUserResponseBodyResult result;

    public static GetCheckinRecordByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCheckinRecordByUserResponseBody self = new GetCheckinRecordByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCheckinRecordByUserResponseBody setResult(GetCheckinRecordByUserResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetCheckinRecordByUserResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCheckinRecordByUserResponseBodyResultPageListCustomDataList build(java.util.Map<String, ?> map) throws Exception {
            GetCheckinRecordByUserResponseBodyResultPageListCustomDataList self = new GetCheckinRecordByUserResponseBodyResultPageListCustomDataList();
            return TeaModel.build(map, self);
        }

        public GetCheckinRecordByUserResponseBodyResultPageListCustomDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetCheckinRecordByUserResponseBodyResultPageListCustomDataList setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCheckinRecordByUserResponseBodyResultPageListCustomDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCheckinRecordByUserResponseBodyResultPageList extends TeaModel {
        @NameInMap("checkinTime")
        public Long checkinTime;

        @NameInMap("customDataList")
        public java.util.List<GetCheckinRecordByUserResponseBodyResultPageListCustomDataList> customDataList;

        @NameInMap("detailPlace")
        public String detailPlace;

        @NameInMap("imageList")
        public java.util.List<String> imageList;

        @NameInMap("latitude")
        public String latitude;

        @NameInMap("longitude")
        public String longitude;

        @NameInMap("place")
        public String place;

        @NameInMap("remark")
        public String remark;

        @NameInMap("userId")
        public String userId;

        @NameInMap("visitUser")
        public String visitUser;

        public static GetCheckinRecordByUserResponseBodyResultPageList build(java.util.Map<String, ?> map) throws Exception {
            GetCheckinRecordByUserResponseBodyResultPageList self = new GetCheckinRecordByUserResponseBodyResultPageList();
            return TeaModel.build(map, self);
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setCheckinTime(Long checkinTime) {
            this.checkinTime = checkinTime;
            return this;
        }
        public Long getCheckinTime() {
            return this.checkinTime;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setCustomDataList(java.util.List<GetCheckinRecordByUserResponseBodyResultPageListCustomDataList> customDataList) {
            this.customDataList = customDataList;
            return this;
        }
        public java.util.List<GetCheckinRecordByUserResponseBodyResultPageListCustomDataList> getCustomDataList() {
            return this.customDataList;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setDetailPlace(String detailPlace) {
            this.detailPlace = detailPlace;
            return this;
        }
        public String getDetailPlace() {
            return this.detailPlace;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setImageList(java.util.List<String> imageList) {
            this.imageList = imageList;
            return this;
        }
        public java.util.List<String> getImageList() {
            return this.imageList;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setPlace(String place) {
            this.place = place;
            return this;
        }
        public String getPlace() {
            return this.place;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetCheckinRecordByUserResponseBodyResultPageList setVisitUser(String visitUser) {
            this.visitUser = visitUser;
            return this;
        }
        public String getVisitUser() {
            return this.visitUser;
        }

    }

    public static class GetCheckinRecordByUserResponseBodyResult extends TeaModel {
        @NameInMap("nextToken")
        public Long nextToken;

        @NameInMap("pageList")
        public java.util.List<GetCheckinRecordByUserResponseBodyResultPageList> pageList;

        public static GetCheckinRecordByUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetCheckinRecordByUserResponseBodyResult self = new GetCheckinRecordByUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetCheckinRecordByUserResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

        public GetCheckinRecordByUserResponseBodyResult setPageList(java.util.List<GetCheckinRecordByUserResponseBodyResultPageList> pageList) {
            this.pageList = pageList;
            return this;
        }
        public java.util.List<GetCheckinRecordByUserResponseBodyResultPageList> getPageList() {
            return this.pageList;
        }

    }

}
