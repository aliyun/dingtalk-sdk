# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateFeedHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateFeedRequestCourseInfoLectorUserInfo(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.avatar = avatar
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateFeedRequestCourseInfoPayInfoCsUserInfo(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.avatar = avatar
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateFeedRequestCourseInfoPayInfoDiscountInfo(TeaModel):
    def __init__(
        self,
        end_time_millis: int = None,
        price: int = None,
        start_time_millis: int = None,
    ):
        # This parameter is required.
        self.end_time_millis = end_time_millis
        # This parameter is required.
        self.price = price
        # This parameter is required.
        self.start_time_millis = start_time_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time_millis is not None:
            result['endTimeMillis'] = self.end_time_millis
        if self.price is not None:
            result['price'] = self.price
        if self.start_time_millis is not None:
            result['startTimeMillis'] = self.start_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTimeMillis') is not None:
            self.end_time_millis = m.get('endTimeMillis')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('startTimeMillis') is not None:
            self.start_time_millis = m.get('startTimeMillis')
        return self


class CreateFeedRequestCourseInfoPayInfo(TeaModel):
    def __init__(
        self,
        cs_user_info: CreateFeedRequestCourseInfoPayInfoCsUserInfo = None,
        discount_info: CreateFeedRequestCourseInfoPayInfoDiscountInfo = None,
        price: int = None,
    ):
        # This parameter is required.
        self.cs_user_info = cs_user_info
        self.discount_info = discount_info
        # This parameter is required.
        self.price = price

    def validate(self):
        if self.cs_user_info:
            self.cs_user_info.validate()
        if self.discount_info:
            self.discount_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cs_user_info is not None:
            result['csUserInfo'] = self.cs_user_info.to_map()
        if self.discount_info is not None:
            result['discountInfo'] = self.discount_info.to_map()
        if self.price is not None:
            result['price'] = self.price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('csUserInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfoCsUserInfo()
            self.cs_user_info = temp_model.from_map(m['csUserInfo'])
        if m.get('discountInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfoDiscountInfo()
            self.discount_info = temp_model.from_map(m['discountInfo'])
        if m.get('price') is not None:
            self.price = m.get('price')
        return self


class CreateFeedRequestCourseInfo(TeaModel):
    def __init__(
        self,
        lector_user_info: CreateFeedRequestCourseInfoLectorUserInfo = None,
        pay_info: CreateFeedRequestCourseInfoPayInfo = None,
        study_group_name: str = None,
    ):
        # This parameter is required.
        self.lector_user_info = lector_user_info
        self.pay_info = pay_info
        self.study_group_name = study_group_name

    def validate(self):
        if self.lector_user_info:
            self.lector_user_info.validate()
        if self.pay_info:
            self.pay_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.lector_user_info is not None:
            result['lectorUserInfo'] = self.lector_user_info.to_map()
        if self.pay_info is not None:
            result['payInfo'] = self.pay_info.to_map()
        if self.study_group_name is not None:
            result['studyGroupName'] = self.study_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lectorUserInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoLectorUserInfo()
            self.lector_user_info = temp_model.from_map(m['lectorUserInfo'])
        if m.get('payInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfo()
            self.pay_info = temp_model.from_map(m['payInfo'])
        if m.get('studyGroupName') is not None:
            self.study_group_name = m.get('studyGroupName')
        return self


class CreateFeedRequestFeedInfoMediaContents(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        title: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.media_id = media_id
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateFeedRequestFeedInfoRecommends(TeaModel):
    def __init__(
        self,
        object_id: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.object_id = object_id
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.object_id is not None:
            result['objectId'] = self.object_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectId') is not None:
            self.object_id = m.get('objectId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateFeedRequestFeedInfo(TeaModel):
    def __init__(
        self,
        action_type: int = None,
        belongs_to: int = None,
        feed_category: int = None,
        feed_id: str = None,
        feed_tag: str = None,
        feed_type: int = None,
        industry_id: int = None,
        introduction: str = None,
        introduction_pic_url: str = None,
        mcn_id: str = None,
        media_contents: List[CreateFeedRequestFeedInfoMediaContents] = None,
        recommends: List[CreateFeedRequestFeedInfoRecommends] = None,
        thumb_url: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.action_type = action_type
        # This parameter is required.
        self.belongs_to = belongs_to
        # This parameter is required.
        self.feed_category = feed_category
        self.feed_id = feed_id
        self.feed_tag = feed_tag
        # This parameter is required.
        self.feed_type = feed_type
        self.industry_id = industry_id
        # This parameter is required.
        self.introduction = introduction
        self.introduction_pic_url = introduction_pic_url
        # This parameter is required.
        self.mcn_id = mcn_id
        # This parameter is required.
        self.media_contents = media_contents
        self.recommends = recommends
        # This parameter is required.
        self.thumb_url = thumb_url
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.media_contents:
            for k in self.media_contents:
                if k:
                    k.validate()
        if self.recommends:
            for k in self.recommends:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.belongs_to is not None:
            result['belongsTo'] = self.belongs_to
        if self.feed_category is not None:
            result['feedCategory'] = self.feed_category
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.feed_tag is not None:
            result['feedTag'] = self.feed_tag
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.industry_id is not None:
            result['industryId'] = self.industry_id
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.introduction_pic_url is not None:
            result['introductionPicUrl'] = self.introduction_pic_url
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        result['mediaContents'] = []
        if self.media_contents is not None:
            for k in self.media_contents:
                result['mediaContents'].append(k.to_map() if k else None)
        result['recommends'] = []
        if self.recommends is not None:
            for k in self.recommends:
                result['recommends'].append(k.to_map() if k else None)
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('belongsTo') is not None:
            self.belongs_to = m.get('belongsTo')
        if m.get('feedCategory') is not None:
            self.feed_category = m.get('feedCategory')
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('feedTag') is not None:
            self.feed_tag = m.get('feedTag')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('industryId') is not None:
            self.industry_id = m.get('industryId')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('introductionPicUrl') is not None:
            self.introduction_pic_url = m.get('introductionPicUrl')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        self.media_contents = []
        if m.get('mediaContents') is not None:
            for k in m.get('mediaContents'):
                temp_model = CreateFeedRequestFeedInfoMediaContents()
                self.media_contents.append(temp_model.from_map(k))
        self.recommends = []
        if m.get('recommends') is not None:
            for k in m.get('recommends'):
                temp_model = CreateFeedRequestFeedInfoRecommends()
                self.recommends.append(temp_model.from_map(k))
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateFeedRequest(TeaModel):
    def __init__(
        self,
        course_info: CreateFeedRequestCourseInfo = None,
        create_user_id: str = None,
        feed_info: CreateFeedRequestFeedInfo = None,
    ):
        self.course_info = course_info
        # This parameter is required.
        self.create_user_id = create_user_id
        # This parameter is required.
        self.feed_info = feed_info

    def validate(self):
        if self.course_info:
            self.course_info.validate()
        if self.feed_info:
            self.feed_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_info is not None:
            result['courseInfo'] = self.course_info.to_map()
        if self.create_user_id is not None:
            result['createUserId'] = self.create_user_id
        if self.feed_info is not None:
            result['feedInfo'] = self.feed_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseInfo') is not None:
            temp_model = CreateFeedRequestCourseInfo()
            self.course_info = temp_model.from_map(m['courseInfo'])
        if m.get('createUserId') is not None:
            self.create_user_id = m.get('createUserId')
        if m.get('feedInfo') is not None:
            temp_model = CreateFeedRequestFeedInfo()
            self.feed_info = temp_model.from_map(m['feedInfo'])
        return self


class CreateFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
    ):
        # This parameter is required.
        self.feed_id = feed_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        return self


class CreateFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateFeedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteVideosHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteVideosRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
    ):
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class DeleteVideosResponseBodyResult(TeaModel):
    def __init__(
        self,
        failed: List[str] = None,
        success: int = None,
        total: int = None,
    ):
        self.failed = failed
        self.success = success
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed is not None:
            result['failed'] = self.failed
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failed') is not None:
            self.failed = m.get('failed')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class DeleteVideosResponseBody(TeaModel):
    def __init__(
        self,
        result: DeleteVideosResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = DeleteVideosResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteVideosResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteVideosResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = DeleteVideosResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFeedHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetFeedRequest(TeaModel):
    def __init__(
        self,
        mcn_id: str = None,
    ):
        # This parameter is required.
        self.mcn_id = mcn_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        return self


class GetFeedResponseBodyFeedItem(TeaModel):
    def __init__(
        self,
        duration_millis: int = None,
        feed_content_type: int = None,
        item_id: str = None,
        title: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.duration_millis = duration_millis
        # This parameter is required.
        self.feed_content_type = feed_content_type
        # This parameter is required.
        self.item_id = item_id
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration_millis is not None:
            result['durationMillis'] = self.duration_millis
        if self.feed_content_type is not None:
            result['feedContentType'] = self.feed_content_type
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('durationMillis') is not None:
            self.duration_millis = m.get('durationMillis')
        if m.get('feedContentType') is not None:
            self.feed_content_type = m.get('feedContentType')
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
        feed_item: List[GetFeedResponseBodyFeedItem] = None,
    ):
        # This parameter is required.
        self.feed_id = feed_id
        # This parameter is required.
        self.feed_item = feed_item

    def validate(self):
        if self.feed_item:
            for k in self.feed_item:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        result['feedItem'] = []
        if self.feed_item is not None:
            for k in self.feed_item:
                result['feedItem'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        self.feed_item = []
        if m.get('feedItem') is not None:
            for k in m.get('feedItem'):
                temp_model = GetFeedResponseBodyFeedItem()
                self.feed_item.append(temp_model.from_map(k))
        return self


class GetFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFeedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMediaCerficateHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetMediaCerficateRequest(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        mcn_id: str = None,
        media_id: str = None,
        media_introduction: str = None,
        media_title: str = None,
        thumb_url: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.file_name = file_name
        # This parameter is required.
        self.mcn_id = mcn_id
        self.media_id = media_id
        self.media_introduction = media_introduction
        # This parameter is required.
        self.media_title = media_title
        self.thumb_url = thumb_url
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.media_introduction is not None:
            result['mediaIntroduction'] = self.media_introduction
        if self.media_title is not None:
            result['mediaTitle'] = self.media_title
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('mediaIntroduction') is not None:
            self.media_introduction = m.get('mediaIntroduction')
        if m.get('mediaTitle') is not None:
            self.media_title = m.get('mediaTitle')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetMediaCerficateResponseBody(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        oss_access_key_id: str = None,
        oss_access_key_secret: str = None,
        oss_bucket_name: str = None,
        oss_endpoint: str = None,
        oss_expiration: str = None,
        oss_file_name: str = None,
        oss_security_token: str = None,
    ):
        # This parameter is required.
        self.media_id = media_id
        # This parameter is required.
        self.oss_access_key_id = oss_access_key_id
        # This parameter is required.
        self.oss_access_key_secret = oss_access_key_secret
        # This parameter is required.
        self.oss_bucket_name = oss_bucket_name
        # This parameter is required.
        self.oss_endpoint = oss_endpoint
        # This parameter is required.
        self.oss_expiration = oss_expiration
        # This parameter is required.
        self.oss_file_name = oss_file_name
        # This parameter is required.
        self.oss_security_token = oss_security_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.oss_access_key_id is not None:
            result['ossAccessKeyId'] = self.oss_access_key_id
        if self.oss_access_key_secret is not None:
            result['ossAccessKeySecret'] = self.oss_access_key_secret
        if self.oss_bucket_name is not None:
            result['ossBucketName'] = self.oss_bucket_name
        if self.oss_endpoint is not None:
            result['ossEndpoint'] = self.oss_endpoint
        if self.oss_expiration is not None:
            result['ossExpiration'] = self.oss_expiration
        if self.oss_file_name is not None:
            result['ossFileName'] = self.oss_file_name
        if self.oss_security_token is not None:
            result['ossSecurityToken'] = self.oss_security_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('ossAccessKeyId') is not None:
            self.oss_access_key_id = m.get('ossAccessKeyId')
        if m.get('ossAccessKeySecret') is not None:
            self.oss_access_key_secret = m.get('ossAccessKeySecret')
        if m.get('ossBucketName') is not None:
            self.oss_bucket_name = m.get('ossBucketName')
        if m.get('ossEndpoint') is not None:
            self.oss_endpoint = m.get('ossEndpoint')
        if m.get('ossExpiration') is not None:
            self.oss_expiration = m.get('ossExpiration')
        if m.get('ossFileName') is not None:
            self.oss_file_name = m.get('ossFileName')
        if m.get('ossSecurityToken') is not None:
            self.oss_security_token = m.get('ossSecurityToken')
        return self


class GetMediaCerficateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMediaCerficateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetMediaCerficateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListItemUserDataHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListItemUserDataRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class ListItemUserDataResponseBodyStudyInfos(TeaModel):
    def __init__(
        self,
        duration_millis: int = None,
        uid: str = None,
    ):
        # This parameter is required.
        self.duration_millis = duration_millis
        # This parameter is required.
        self.uid = uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration_millis is not None:
            result['durationMillis'] = self.duration_millis
        if self.uid is not None:
            result['uid'] = self.uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('durationMillis') is not None:
            self.duration_millis = m.get('durationMillis')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        return self


class ListItemUserDataResponseBody(TeaModel):
    def __init__(
        self,
        study_infos: List[ListItemUserDataResponseBodyStudyInfos] = None,
    ):
        # This parameter is required.
        self.study_infos = study_infos

    def validate(self):
        if self.study_infos:
            for k in self.study_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['studyInfos'] = []
        if self.study_infos is not None:
            for k in self.study_infos:
                result['studyInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.study_infos = []
        if m.get('studyInfos') is not None:
            for k in m.get('studyInfos'):
                temp_model = ListItemUserDataResponseBodyStudyInfos()
                self.study_infos.append(temp_model.from_map(k))
        return self


class ListItemUserDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListItemUserDataResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = ListItemUserDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageFeedHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PageFeedRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
        max_results: int = None,
        mcn_id: str = None,
        next_token: int = None,
    ):
        self.body = body
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.mcn_id = mcn_id
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class PageFeedResponseBodyFeedList(TeaModel):
    def __init__(
        self,
        feed_category: str = None,
        feed_id: str = None,
        feed_type: int = None,
        name: str = None,
        thumb_url: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.feed_category = feed_category
        # This parameter is required.
        self.feed_id = feed_id
        # This parameter is required.
        self.feed_type = feed_type
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.thumb_url = thumb_url
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_category is not None:
            result['feedCategory'] = self.feed_category
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.name is not None:
            result['name'] = self.name
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedCategory') is not None:
            self.feed_category = m.get('feedCategory')
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PageFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_list: List[PageFeedResponseBodyFeedList] = None,
        has_next: bool = None,
        next_cursor: int = None,
    ):
        # This parameter is required.
        self.feed_list = feed_list
        # This parameter is required.
        self.has_next = has_next
        # This parameter is required.
        self.next_cursor = next_cursor

    def validate(self):
        if self.feed_list:
            for k in self.feed_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['feedList'] = []
        if self.feed_list is not None:
            for k in self.feed_list:
                result['feedList'].append(k.to_map() if k else None)
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.feed_list = []
        if m.get('feedList') is not None:
            for k in m.get('feedList'):
                temp_model = PageFeedResponseBodyFeedList()
                self.feed_list.append(temp_model.from_map(k))
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        return self


class PageFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PageFeedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = PageFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadVideosHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UploadVideosRequestBody(TeaModel):
    def __init__(
        self,
        author_icon_url: str = None,
        author_id: str = None,
        author_name: str = None,
        cover_url: str = None,
        jump_icon_url: str = None,
        jump_title: str = None,
        jump_url: str = None,
        video_duration: str = None,
        video_height: str = None,
        video_id: str = None,
        video_title: str = None,
        video_width: str = None,
        webp_url: str = None,
    ):
        self.author_icon_url = author_icon_url
        self.author_id = author_id
        self.author_name = author_name
        self.cover_url = cover_url
        self.jump_icon_url = jump_icon_url
        self.jump_title = jump_title
        self.jump_url = jump_url
        self.video_duration = video_duration
        self.video_height = video_height
        self.video_id = video_id
        self.video_title = video_title
        self.video_width = video_width
        self.webp_url = webp_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.author_icon_url is not None:
            result['authorIconUrl'] = self.author_icon_url
        if self.author_id is not None:
            result['authorId'] = self.author_id
        if self.author_name is not None:
            result['authorName'] = self.author_name
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.jump_icon_url is not None:
            result['jumpIconUrl'] = self.jump_icon_url
        if self.jump_title is not None:
            result['jumpTitle'] = self.jump_title
        if self.jump_url is not None:
            result['jumpUrl'] = self.jump_url
        if self.video_duration is not None:
            result['videoDuration'] = self.video_duration
        if self.video_height is not None:
            result['videoHeight'] = self.video_height
        if self.video_id is not None:
            result['videoId'] = self.video_id
        if self.video_title is not None:
            result['videoTitle'] = self.video_title
        if self.video_width is not None:
            result['videoWidth'] = self.video_width
        if self.webp_url is not None:
            result['webpUrl'] = self.webp_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorIconUrl') is not None:
            self.author_icon_url = m.get('authorIconUrl')
        if m.get('authorId') is not None:
            self.author_id = m.get('authorId')
        if m.get('authorName') is not None:
            self.author_name = m.get('authorName')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('jumpIconUrl') is not None:
            self.jump_icon_url = m.get('jumpIconUrl')
        if m.get('jumpTitle') is not None:
            self.jump_title = m.get('jumpTitle')
        if m.get('jumpUrl') is not None:
            self.jump_url = m.get('jumpUrl')
        if m.get('videoDuration') is not None:
            self.video_duration = m.get('videoDuration')
        if m.get('videoHeight') is not None:
            self.video_height = m.get('videoHeight')
        if m.get('videoId') is not None:
            self.video_id = m.get('videoId')
        if m.get('videoTitle') is not None:
            self.video_title = m.get('videoTitle')
        if m.get('videoWidth') is not None:
            self.video_width = m.get('videoWidth')
        if m.get('webpUrl') is not None:
            self.webp_url = m.get('webpUrl')
        return self


class UploadVideosRequest(TeaModel):
    def __init__(
        self,
        body: List[UploadVideosRequestBody] = None,
    ):
        self.body = body

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = UploadVideosRequestBody()
                self.body.append(temp_model.from_map(k))
        return self


class UploadVideosResponseBodyResult(TeaModel):
    def __init__(
        self,
        failed: List[str] = None,
        has_uploaded: int = None,
        success: int = None,
        total: int = None,
    ):
        self.failed = failed
        self.has_uploaded = has_uploaded
        self.success = success
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed is not None:
            result['failed'] = self.failed
        if self.has_uploaded is not None:
            result['hasUploaded'] = self.has_uploaded
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failed') is not None:
            self.failed = m.get('failed')
        if m.get('hasUploaded') is not None:
            self.has_uploaded = m.get('hasUploaded')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class UploadVideosResponseBody(TeaModel):
    def __init__(
        self,
        result: UploadVideosResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = UploadVideosResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadVideosResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadVideosResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UploadVideosResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


