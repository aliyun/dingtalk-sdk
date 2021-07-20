# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        thumb_url: str = None,
        file_name: str = None,
        media_id: str = None,
        media_title: str = None,
        mcn_id: str = None,
        user_id: str = None,
        media_introduction: str = None,
    ):
        # 自定义视频封面的URL地址
        self.thumb_url = thumb_url
        # 视频的文件名称,必须带扩展名,支持的扩展名参考:https://help.aliyun.com/document_detail/55396.htm?spm=a2c4g.11186623.2.11.2d385d4aG2IkCZ#title-j7o-gr4-c7a
        self.file_name = file_name
        # 如果传入该值，表示续订该mediaId对应的上传凭证 ;否则将视为新建一个视频上传连接和凭证
        self.media_id = media_id
        # 视频的标题
        self.media_title = media_title
        # 入驻账号Id(请联系钉钉接口同学获取)
        self.mcn_id = mcn_id
        # 操作人的用户id
        self.user_id = user_id
        # 视频介绍
        self.media_introduction = media_introduction

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.media_title is not None:
            result['mediaTitle'] = self.media_title
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.media_introduction is not None:
            result['mediaIntroduction'] = self.media_introduction
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('mediaTitle') is not None:
            self.media_title = m.get('mediaTitle')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('mediaIntroduction') is not None:
            self.media_introduction = m.get('mediaIntroduction')
        return self


class GetMediaCerficateResponseBody(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        oss_endpoint: str = None,
        oss_access_key_id: str = None,
        oss_access_key_secret: str = None,
        oss_security_token: str = None,
        oss_bucket_name: str = None,
        oss_file_name: str = None,
        oss_expiration: str = None,
    ):
        # 媒体文件ID
        self.media_id = media_id
        # OSS区域地址
        self.oss_endpoint = oss_endpoint
        # 上传授权密钥ID
        self.oss_access_key_id = oss_access_key_id
        # 上传授权密钥
        self.oss_access_key_secret = oss_access_key_secret
        # 上传授权安全令牌
        self.oss_security_token = oss_security_token
        # OSS Bucket名称
        self.oss_bucket_name = oss_bucket_name
        # 分配的媒体文件名
        self.oss_file_name = oss_file_name
        # 凭证有效时间(单位秒)，当上传凭证过期时，需要重新使用本次返回的videoId重新调用接口进行凭证刷新
        self.oss_expiration = oss_expiration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.oss_endpoint is not None:
            result['ossEndpoint'] = self.oss_endpoint
        if self.oss_access_key_id is not None:
            result['ossAccessKeyId'] = self.oss_access_key_id
        if self.oss_access_key_secret is not None:
            result['ossAccessKeySecret'] = self.oss_access_key_secret
        if self.oss_security_token is not None:
            result['ossSecurityToken'] = self.oss_security_token
        if self.oss_bucket_name is not None:
            result['ossBucketName'] = self.oss_bucket_name
        if self.oss_file_name is not None:
            result['ossFileName'] = self.oss_file_name
        if self.oss_expiration is not None:
            result['ossExpiration'] = self.oss_expiration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('ossEndpoint') is not None:
            self.oss_endpoint = m.get('ossEndpoint')
        if m.get('ossAccessKeyId') is not None:
            self.oss_access_key_id = m.get('ossAccessKeyId')
        if m.get('ossAccessKeySecret') is not None:
            self.oss_access_key_secret = m.get('ossAccessKeySecret')
        if m.get('ossSecurityToken') is not None:
            self.oss_security_token = m.get('ossSecurityToken')
        if m.get('ossBucketName') is not None:
            self.oss_bucket_name = m.get('ossBucketName')
        if m.get('ossFileName') is not None:
            self.oss_file_name = m.get('ossFileName')
        if m.get('ossExpiration') is not None:
            self.oss_expiration = m.get('ossExpiration')
        return self


class GetMediaCerficateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetMediaCerficateResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetMediaCerficateResponseBody()
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
        # 入驻账号Id(请联系钉钉接口同学获取)
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
        item_id: str = None,
        title: str = None,
        feed_content_type: int = None,
        duration_millis: int = None,
        url: str = None,
    ):
        # 子内容Id
        self.item_id = item_id
        # 子内容标题
        self.title = title
        # 内容类型，0表示直播，1表示图文，2表示视频，3表示音频
        self.feed_content_type = feed_content_type
        # 子内容的持续时长，单位为毫秒
        self.duration_millis = duration_millis
        # 子内容的跳转链接
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.title is not None:
            result['title'] = self.title
        if self.feed_content_type is not None:
            result['feedContentType'] = self.feed_content_type
        if self.duration_millis is not None:
            result['durationMillis'] = self.duration_millis
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('feedContentType') is not None:
            self.feed_content_type = m.get('feedContentType')
        if m.get('durationMillis') is not None:
            self.duration_millis = m.get('durationMillis')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
        feed_item: List[GetFeedResponseBodyFeedItem] = None,
    ):
        # 内容Id
        self.feed_id = feed_id
        # 子内容
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
        body: GetFeedResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetFeedResponseBody()
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
        next_token: int = None,
        max_results: int = None,
        body: List[str] = None,
        mcn_id: str = None,
    ):
        # 分页参数：起始位置，初始值应为0，后续传入返回值中的nextCursor字段中的值
        self.next_token = next_token
        # 分页参数：页面展示数量
        self.max_results = max_results
        # 内容Id，如果传入该参数，表示仅筛选内容Id出现在本列表中的内容
        self.body = body
        # 入驻账号Id(请联系钉钉接口同学获取)
        self.mcn_id = mcn_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.body is not None:
            result['body'] = self.body
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        return self


class PageFeedResponseBodyFeedList(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
        name: str = None,
        url: str = None,
        feed_type: int = None,
        thumb_url: str = None,
        feed_category: str = None,
    ):
        # 内容Id
        self.feed_id = feed_id
        # 内容名称
        self.name = name
        # 跳转Url，跳转到职场学堂后台页面
        self.url = url
        # 内容类型，0：免费内容 4：平价内容 5：专栏内容 6：训练营内容
        self.feed_type = feed_type
        # 封面URL
        self.thumb_url = thumb_url
        # 内容分类，请见https://developers.dingtalk.com/document/app/appendix-content
        self.feed_category = feed_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.name is not None:
            result['name'] = self.name
        if self.url is not None:
            result['url'] = self.url
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.feed_category is not None:
            result['feedCategory'] = self.feed_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('feedCategory') is not None:
            self.feed_category = m.get('feedCategory')
        return self


class PageFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_list: List[PageFeedResponseBodyFeedList] = None,
        next_cursor: int = None,
        has_next: bool = None,
    ):
        # 课程列表
        self.feed_list = feed_list
        # 分页参数：下一页的起始位置
        self.next_cursor = next_cursor
        # 分页参数：是否还有下一页，false表示没有下一页
        self.has_next = has_next

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.feed_list = []
        if m.get('feedList') is not None:
            for k in m.get('feedList'):
                temp_model = PageFeedResponseBodyFeedList()
                self.feed_list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        return self


class PageFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PageFeedResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = PageFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        user_id: str = None,
        name: str = None,
    ):
        # 讲师头像链接
        self.avatar = avatar
        # 讲师用户Id
        self.user_id = user_id
        # 讲师用户名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateFeedRequestCourseInfoPayInfoCsUserInfo(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        user_id: str = None,
        name: str = None,
    ):
        # 客服头像链接
        self.avatar = avatar
        # 客服用户Id
        self.user_id = user_id
        # 客服用户名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateFeedRequestCourseInfoPayInfoDiscountInfo(TeaModel):
    def __init__(
        self,
        start_time_millis: int = None,
        price: int = None,
        end_time_millis: int = None,
    ):
        # 打折开始的时间，时间戳精确到毫秒，时间为东八区时间
        self.start_time_millis = start_time_millis
        # 打折时商品的价格，单位为分
        self.price = price
        # 打折结束的时间，时间戳精确到毫秒，时间为东八区时间
        self.end_time_millis = end_time_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time_millis is not None:
            result['startTimeMillis'] = self.start_time_millis
        if self.price is not None:
            result['price'] = self.price
        if self.end_time_millis is not None:
            result['endTimeMillis'] = self.end_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTimeMillis') is not None:
            self.start_time_millis = m.get('startTimeMillis')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('endTimeMillis') is not None:
            self.end_time_millis = m.get('endTimeMillis')
        return self


class CreateFeedRequestCourseInfoPayInfo(TeaModel):
    def __init__(
        self,
        cs_user_info: CreateFeedRequestCourseInfoPayInfoCsUserInfo = None,
        price: int = None,
        discount_info: CreateFeedRequestCourseInfoPayInfoDiscountInfo = None,
    ):
        # 客服身份信息
        self.cs_user_info = cs_user_info
        # 商品的默认情况下非打折时的价格，单位为分
        self.price = price
        # 课程打折信息
        self.discount_info = discount_info

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
        if self.price is not None:
            result['price'] = self.price
        if self.discount_info is not None:
            result['discountInfo'] = self.discount_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('csUserInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfoCsUserInfo()
            self.cs_user_info = temp_model.from_map(m['csUserInfo'])
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('discountInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfoDiscountInfo()
            self.discount_info = temp_model.from_map(m['discountInfo'])
        return self


class CreateFeedRequestCourseInfo(TeaModel):
    def __init__(
        self,
        study_group_name: str = None,
        lector_user_info: CreateFeedRequestCourseInfoLectorUserInfo = None,
        pay_info: CreateFeedRequestCourseInfoPayInfo = None,
    ):
        # 创建一个和该课程绑定的学习群和圈子
        self.study_group_name = study_group_name
        # 讲师身份信息
        self.lector_user_info = lector_user_info
        # 支付信息
        self.pay_info = pay_info

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
        if self.study_group_name is not None:
            result['studyGroupName'] = self.study_group_name
        if self.lector_user_info is not None:
            result['lectorUserInfo'] = self.lector_user_info.to_map()
        if self.pay_info is not None:
            result['payInfo'] = self.pay_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('studyGroupName') is not None:
            self.study_group_name = m.get('studyGroupName')
        if m.get('lectorUserInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoLectorUserInfo()
            self.lector_user_info = temp_model.from_map(m['lectorUserInfo'])
        if m.get('payInfo') is not None:
            temp_model = CreateFeedRequestCourseInfoPayInfo()
            self.pay_info = temp_model.from_map(m['payInfo'])
        return self


class CreateFeedRequestFeedInfoMediaContents(TeaModel):
    def __init__(
        self,
        type: int = None,
        media_id: str = None,
        title: str = None,
    ):
        # 媒体的类型，当前该接口只支持video和audio,2:视频,3:音频
        self.type = type
        # 媒体的mediaId，唯一对应oss中的一个视频或者音频
        self.media_id = media_id
        # 媒体的标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateFeedRequestFeedInfoRecommends(TeaModel):
    def __init__(
        self,
        type: int = None,
        object_id: str = None,
    ):
        # 推荐物品的类别,0:课程,1:微应用
        self.type = type
        # 推荐物品的id，可以时feedId或者是微应用Id
        self.object_id = object_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.object_id is not None:
            result['objectId'] = self.object_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('objectId') is not None:
            self.object_id = m.get('objectId')
        return self


class CreateFeedRequestFeedInfo(TeaModel):
    def __init__(
        self,
        action_type: int = None,
        media_contents: List[CreateFeedRequestFeedInfoMediaContents] = None,
        feed_category: int = None,
        belongs_to: int = None,
        industry_id: int = None,
        thumb_url: str = None,
        recommends: List[CreateFeedRequestFeedInfoRecommends] = None,
        feed_id: str = None,
        title: str = None,
        feed_type: int = None,
        introduction: str = None,
        feed_tag: str = None,
        mcn_id: str = None,
        introduction_pic_url: str = None,
    ):
        # 请求的行为，是保存还是发布,1为save，2为publish，是修改还是新建取决于feedId是否为空
        self.action_type = action_type
        # 一个课程下可以有多个视频或音频教程
        self.media_contents = media_contents
        # 内容分类，课程分类列表详情请见附录中的列表
        self.feed_category = feed_category
        # 版权所属:1：自有， 2.代理， 3.钉钉
        self.belongs_to = belongs_to
        # 行业划分，决定了展示的页面的不同，例如学习中心下的职场、教育、商学院的划分,目前支持的行业id有：10001：职场学堂，10008：K12教育，10023：新职业，10024：钉钉培训
        self.industry_id = industry_id
        # 课程的封面Url
        self.thumb_url = thumb_url
        # 推荐内容集合
        self.recommends = recommends
        # 可选参数，当feedId不为null时，表示对当前课程进行修改，否则为新建一个课程
        self.feed_id = feed_id
        # 内容的标题（标题不能重复）
        self.title = title
        # 内容类别,限制只能使用4种类型：0：免费 4：平价 5：专栏 6：训练营
        self.feed_type = feed_type
        # 课程的描述
        self.introduction = introduction
        # 课程的文字标签
        self.feed_tag = feed_tag
        # 入驻账号Id(请联系钉钉接口同学获取)
        self.mcn_id = mcn_id
        # 课程简介用的图片
        self.introduction_pic_url = introduction_pic_url

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
        result['mediaContents'] = []
        if self.media_contents is not None:
            for k in self.media_contents:
                result['mediaContents'].append(k.to_map() if k else None)
        if self.feed_category is not None:
            result['feedCategory'] = self.feed_category
        if self.belongs_to is not None:
            result['belongsTo'] = self.belongs_to
        if self.industry_id is not None:
            result['industryId'] = self.industry_id
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        result['recommends'] = []
        if self.recommends is not None:
            for k in self.recommends:
                result['recommends'].append(k.to_map() if k else None)
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.title is not None:
            result['title'] = self.title
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.feed_tag is not None:
            result['feedTag'] = self.feed_tag
        if self.mcn_id is not None:
            result['mcnId'] = self.mcn_id
        if self.introduction_pic_url is not None:
            result['introductionPicUrl'] = self.introduction_pic_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        self.media_contents = []
        if m.get('mediaContents') is not None:
            for k in m.get('mediaContents'):
                temp_model = CreateFeedRequestFeedInfoMediaContents()
                self.media_contents.append(temp_model.from_map(k))
        if m.get('feedCategory') is not None:
            self.feed_category = m.get('feedCategory')
        if m.get('belongsTo') is not None:
            self.belongs_to = m.get('belongsTo')
        if m.get('industryId') is not None:
            self.industry_id = m.get('industryId')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        self.recommends = []
        if m.get('recommends') is not None:
            for k in m.get('recommends'):
                temp_model = CreateFeedRequestFeedInfoRecommends()
                self.recommends.append(temp_model.from_map(k))
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('feedTag') is not None:
            self.feed_tag = m.get('feedTag')
        if m.get('mcnId') is not None:
            self.mcn_id = m.get('mcnId')
        if m.get('introductionPicUrl') is not None:
            self.introduction_pic_url = m.get('introductionPicUrl')
        return self


class CreateFeedRequest(TeaModel):
    def __init__(
        self,
        course_info: CreateFeedRequestCourseInfo = None,
        feed_info: CreateFeedRequestFeedInfo = None,
        create_user_id: str = None,
    ):
        # 课程相关信息
        self.course_info = course_info
        # 内容相关信息
        self.feed_info = feed_info
        # 发布者的用户Id
        self.create_user_id = create_user_id

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
        if self.feed_info is not None:
            result['feedInfo'] = self.feed_info.to_map()
        if self.create_user_id is not None:
            result['createUserId'] = self.create_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseInfo') is not None:
            temp_model = CreateFeedRequestCourseInfo()
            self.course_info = temp_model.from_map(m['courseInfo'])
        if m.get('feedInfo') is not None:
            temp_model = CreateFeedRequestFeedInfo()
            self.feed_info = temp_model.from_map(m['feedInfo'])
        if m.get('createUserId') is not None:
            self.create_user_id = m.get('createUserId')
        return self


class CreateFeedResponseBody(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
    ):
        # 创建内容的内容Id
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
        body: CreateFeedResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CreateFeedResponseBody()
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
        # 希望查询的用户的id列表
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
        uid: str = None,
        duration_millis: int = None,
    ):
        # 用户id
        self.uid = uid
        # 时间持续长度，单位为毫秒
        self.duration_millis = duration_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.uid is not None:
            result['uid'] = self.uid
        if self.duration_millis is not None:
            result['durationMillis'] = self.duration_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('durationMillis') is not None:
            self.duration_millis = m.get('durationMillis')
        return self


class ListItemUserDataResponseBody(TeaModel):
    def __init__(
        self,
        study_infos: List[ListItemUserDataResponseBodyStudyInfos] = None,
    ):
        # 学习的时长记录
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
        body: ListItemUserDataResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = ListItemUserDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


