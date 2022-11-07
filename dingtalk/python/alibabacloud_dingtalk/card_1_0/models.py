# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AppendSpaceHeaders(TeaModel):
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


class AppendSpaceRequestCoFeedOpenSpaceModel(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        # 【必填】标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class AppendSpaceRequestImGroupOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        self.alert_content = alert_content
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class AppendSpaceRequestImGroupOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        self.search_desc = search_desc
        self.search_icon = search_icon
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class AppendSpaceRequestImGroupOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: AppendSpaceRequestImGroupOpenSpaceModelNotification = None,
        search_support: AppendSpaceRequestImGroupOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        self.last_message_i18n = last_message_i18n
        # xpn信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = AppendSpaceRequestImGroupOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = AppendSpaceRequestImGroupOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class AppendSpaceRequestImSingleOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        self.alert_content = alert_content
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class AppendSpaceRequestImSingleOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        self.search_desc = search_desc
        self.search_icon = search_icon
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class AppendSpaceRequestImSingleOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: AppendSpaceRequestImSingleOpenSpaceModelNotification = None,
        search_support: AppendSpaceRequestImSingleOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        self.last_message_i18n = last_message_i18n
        # xpn信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = AppendSpaceRequestImSingleOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = AppendSpaceRequestImSingleOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class AppendSpaceRequestTopOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class AppendSpaceRequestWorkBenchOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class AppendSpaceRequest(TeaModel):
    def __init__(
        self,
        co_feed_open_space_model: AppendSpaceRequestCoFeedOpenSpaceModel = None,
        im_group_open_space_model: AppendSpaceRequestImGroupOpenSpaceModel = None,
        im_single_open_space_model: AppendSpaceRequestImSingleOpenSpaceModel = None,
        out_track_id: str = None,
        top_open_space_model: AppendSpaceRequestTopOpenSpaceModel = None,
        work_bench_open_space_model: AppendSpaceRequestWorkBenchOpenSpaceModel = None,
    ):
        # 协作场域信息
        self.co_feed_open_space_model = co_feed_open_space_model
        # IM群聊场域信息
        self.im_group_open_space_model = im_group_open_space_model
        # IM单聊场域信息
        self.im_single_open_space_model = im_single_open_space_model
        # 唯一标识一张卡片的外部Id
        self.out_track_id = out_track_id
        # 吊顶场域信息
        self.top_open_space_model = top_open_space_model
        # 工作台场域信息
        self.work_bench_open_space_model = work_bench_open_space_model

    def validate(self):
        if self.co_feed_open_space_model:
            self.co_feed_open_space_model.validate()
        if self.im_group_open_space_model:
            self.im_group_open_space_model.validate()
        if self.im_single_open_space_model:
            self.im_single_open_space_model.validate()
        if self.top_open_space_model:
            self.top_open_space_model.validate()
        if self.work_bench_open_space_model:
            self.work_bench_open_space_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.co_feed_open_space_model is not None:
            result['coFeedOpenSpaceModel'] = self.co_feed_open_space_model.to_map()
        if self.im_group_open_space_model is not None:
            result['imGroupOpenSpaceModel'] = self.im_group_open_space_model.to_map()
        if self.im_single_open_space_model is not None:
            result['imSingleOpenSpaceModel'] = self.im_single_open_space_model.to_map()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.top_open_space_model is not None:
            result['topOpenSpaceModel'] = self.top_open_space_model.to_map()
        if self.work_bench_open_space_model is not None:
            result['workBenchOpenSpaceModel'] = self.work_bench_open_space_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coFeedOpenSpaceModel') is not None:
            temp_model = AppendSpaceRequestCoFeedOpenSpaceModel()
            self.co_feed_open_space_model = temp_model.from_map(m['coFeedOpenSpaceModel'])
        if m.get('imGroupOpenSpaceModel') is not None:
            temp_model = AppendSpaceRequestImGroupOpenSpaceModel()
            self.im_group_open_space_model = temp_model.from_map(m['imGroupOpenSpaceModel'])
        if m.get('imSingleOpenSpaceModel') is not None:
            temp_model = AppendSpaceRequestImSingleOpenSpaceModel()
            self.im_single_open_space_model = temp_model.from_map(m['imSingleOpenSpaceModel'])
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('topOpenSpaceModel') is not None:
            temp_model = AppendSpaceRequestTopOpenSpaceModel()
            self.top_open_space_model = temp_model.from_map(m['topOpenSpaceModel'])
        if m.get('workBenchOpenSpaceModel') is not None:
            temp_model = AppendSpaceRequestWorkBenchOpenSpaceModel()
            self.work_bench_open_space_model = temp_model.from_map(m['workBenchOpenSpaceModel'])
        return self


class AppendSpaceResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AppendSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AppendSpaceResponseBody = None,
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
            temp_model = AppendSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAndDeliverHeaders(TeaModel):
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


class CreateAndDeliverRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板-文本内容参数
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class CreateAndDeliverRequestCoFeedOpenDeliverModel(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        gmt_time_line: int = None,
    ):
        # 【必填】业务标识
        self.biz_tag = biz_tag
        # 【必填】协作场域下的排序时间
        self.gmt_time_line = gmt_time_line

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.gmt_time_line is not None:
            result['gmtTimeLine'] = self.gmt_time_line
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('gmtTimeLine') is not None:
            self.gmt_time_line = m.get('gmtTimeLine')
        return self


class CreateAndDeliverRequestCoFeedOpenSpaceModel(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        # 【必填】标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateAndDeliverRequestImGroupOpenDeliverModel(TeaModel):
    def __init__(
        self,
        at_user_ids: Dict[str, str] = None,
        recipients: List[str] = None,
        robot_code: str = None,
    ):
        # 消息@人，
        self.at_user_ids = at_user_ids
        # 指定接收者
        self.recipients = recipients
        # 机器人的code
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_user_ids is not None:
            result['atUserIds'] = self.at_user_ids
        if self.recipients is not None:
            result['recipients'] = self.recipients
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atUserIds') is not None:
            self.at_user_ids = m.get('atUserIds')
        if m.get('recipients') is not None:
            self.recipients = m.get('recipients')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class CreateAndDeliverRequestImGroupOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        self.alert_content = alert_content
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        self.search_desc = search_desc
        self.search_icon = search_icon
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class CreateAndDeliverRequestImGroupOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: CreateAndDeliverRequestImGroupOpenSpaceModelNotification = None,
        search_support: CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        self.last_message_i18n = last_message_i18n
        # 通知信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = CreateAndDeliverRequestImGroupOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = CreateAndDeliverRequestImGroupOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class CreateAndDeliverRequestImSingleOpenDeliverModel(TeaModel):
    def __init__(
        self,
        at_user_ids: Dict[str, str] = None,
    ):
        # 消息@人，
        self.at_user_ids = at_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_user_ids is not None:
            result['atUserIds'] = self.at_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atUserIds') is not None:
            self.at_user_ids = m.get('atUserIds')
        return self


class CreateAndDeliverRequestImSingleOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        self.alert_content = alert_content
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        self.search_desc = search_desc
        self.search_icon = search_icon
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class CreateAndDeliverRequestImSingleOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: CreateAndDeliverRequestImSingleOpenSpaceModelNotification = None,
        search_support: CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        self.last_message_i18n = last_message_i18n
        # 通知信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = CreateAndDeliverRequestImSingleOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = CreateAndDeliverRequestImSingleOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig(TeaModel):
    def __init__(
        self,
        interval: int = None,
        pull_strategy: str = None,
        time_unit: str = None,
    ):
        # 间隔
        self.interval = interval
        # 拉取策略 (NONE: 不拉取,无动态数据, INTERVAL: 间隔拉取, ONCE: 只拉取一次)
        self.pull_strategy = pull_strategy
        # 间隔的时间单位 (SECONDS, MINUTES, HOURS, DAYS)
        self.time_unit = time_unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.interval is not None:
            result['interval'] = self.interval
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        return self


class CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs(TeaModel):
    def __init__(
        self,
        const_params: Dict[str, str] = None,
        dynamic_data_source_id: str = None,
        pull_config: CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig = None,
    ):
        # 回调数据源的常量参数
        self.const_params = const_params
        # 数据源配置id
        self.dynamic_data_source_id = dynamic_data_source_id
        # 数据源拉取配置
        self.pull_config = pull_config

    def validate(self):
        if self.pull_config:
            self.pull_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.const_params is not None:
            result['constParams'] = self.const_params
        if self.dynamic_data_source_id is not None:
            result['dynamicDataSourceId'] = self.dynamic_data_source_id
        if self.pull_config is not None:
            result['pullConfig'] = self.pull_config.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('constParams') is not None:
            self.const_params = m.get('constParams')
        if m.get('dynamicDataSourceId') is not None:
            self.dynamic_data_source_id = m.get('dynamicDataSourceId')
        if m.get('pullConfig') is not None:
            temp_model = CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig()
            self.pull_config = temp_model.from_map(m['pullConfig'])
        return self


class OpenDynamicDataConfigDynamicDataMappingValue(TeaModel):
    def __init__(
        self,
        path: str = None,
        dynamic_data_value_type: str = None,
    ):
        # jsonPath
        self.path = path
        # 值的类型 (STRING: String, ARRAY: 数组, OBJECT: 对象, CHART: 图表, TABLE: 表格, INDICATOR: 指标卡)
        self.dynamic_data_value_type = dynamic_data_value_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.path is not None:
            result['path'] = self.path
        if self.dynamic_data_value_type is not None:
            result['dynamicDataValueType'] = self.dynamic_data_value_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('dynamicDataValueType') is not None:
            self.dynamic_data_value_type = m.get('dynamicDataValueType')
        return self


class CreateAndDeliverRequestOpenDynamicDataConfig(TeaModel):
    def __init__(
        self,
        dynamic_data_mapping: Dict[str, OpenDynamicDataConfigDynamicDataMappingValue] = None,
        dynamic_data_mapping_method: str = None,
        dynamic_data_source_configs: List[CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs] = None,
    ):
        # 动态数据替换关系,key是变量名, value是数据源的jsonPath相关配置
        self.dynamic_data_mapping = dynamic_data_mapping
        # 动态数据映射类型 (REPLACE_WITHOUT_MAPPING: 直接将动态数据返回，无需根据 key mapping, MAPPING_BY_KEY: 根据创建时的 key 进行 mapping)
        self.dynamic_data_mapping_method = dynamic_data_mapping_method
        # 动态数据源配置列表
        self.dynamic_data_source_configs = dynamic_data_source_configs

    def validate(self):
        if self.dynamic_data_mapping:
            for v in self.dynamic_data_mapping.values():
                if v:
                    v.validate()
        if self.dynamic_data_source_configs:
            for k in self.dynamic_data_source_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dynamicDataMapping'] = {}
        if self.dynamic_data_mapping is not None:
            for k, v in self.dynamic_data_mapping.items():
                result['dynamicDataMapping'][k] = v.to_map()
        if self.dynamic_data_mapping_method is not None:
            result['dynamicDataMappingMethod'] = self.dynamic_data_mapping_method
        result['dynamicDataSourceConfigs'] = []
        if self.dynamic_data_source_configs is not None:
            for k in self.dynamic_data_source_configs:
                result['dynamicDataSourceConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dynamic_data_mapping = {}
        if m.get('dynamicDataMapping') is not None:
            for k, v in m.get('dynamicDataMapping').items():
                temp_model = OpenDynamicDataConfigDynamicDataMappingValue()
                self.dynamic_data_mapping[k] = temp_model.from_map(v)
        if m.get('dynamicDataMappingMethod') is not None:
            self.dynamic_data_mapping_method = m.get('dynamicDataMappingMethod')
        self.dynamic_data_source_configs = []
        if m.get('dynamicDataSourceConfigs') is not None:
            for k in m.get('dynamicDataSourceConfigs'):
                temp_model = CreateAndDeliverRequestOpenDynamicDataConfigDynamicDataSourceConfigs()
                self.dynamic_data_source_configs.append(temp_model.from_map(k))
        return self


class CreateAndDeliverRequestTopOpenDeliverModel(TeaModel):
    def __init__(
        self,
        expired_time_millis: int = None,
        platforms: List[str] = None,
        user_ids: List[str] = None,
    ):
        # 【必填】过期时间戳
        self.expired_time_millis = expired_time_millis
        # 可以查看该吊顶卡片的设备
        self.platforms = platforms
        # 可以查看该吊顶卡片的staffId
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expired_time_millis is not None:
            result['expiredTimeMillis'] = self.expired_time_millis
        if self.platforms is not None:
            result['platforms'] = self.platforms
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expiredTimeMillis') is not None:
            self.expired_time_millis = m.get('expiredTimeMillis')
        if m.get('platforms') is not None:
            self.platforms = m.get('platforms')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateAndDeliverRequestTopOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class CreateAndDeliverRequestWorkBenchOpenDeliverModel(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        plugin_component_name: str = None,
        preview_url: str = None,
        project_name: str = None,
        user_id: str = None,
    ):
        # 【必填】组件icon对应组件左上角的图标
        self.icon = icon
        # 【必填】卡片名称
        self.name = name
        # 【必填】卡片组件名
        self.plugin_component_name = plugin_component_name
        # 【必填】卡片预览图
        self.preview_url = preview_url
        # 【必填】保持和微应用名称相同
        self.project_name = project_name
        # 【必填】操作者Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.plugin_component_name is not None:
            result['pluginComponentName'] = self.plugin_component_name
        if self.preview_url is not None:
            result['previewUrl'] = self.preview_url
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pluginComponentName') is not None:
            self.plugin_component_name = m.get('pluginComponentName')
        if m.get('previewUrl') is not None:
            self.preview_url = m.get('previewUrl')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateAndDeliverRequestWorkBenchOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 【必填】场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class PrivateDataValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板-文本内容参数
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class CreateAndDeliverRequest(TeaModel):
    def __init__(
        self,
        callback_route_key: str = None,
        card_at_user_ids: List[str] = None,
        card_data: CreateAndDeliverRequestCardData = None,
        card_template_id: str = None,
        co_feed_open_deliver_model: CreateAndDeliverRequestCoFeedOpenDeliverModel = None,
        co_feed_open_space_model: CreateAndDeliverRequestCoFeedOpenSpaceModel = None,
        im_group_open_deliver_model: CreateAndDeliverRequestImGroupOpenDeliverModel = None,
        im_group_open_space_model: CreateAndDeliverRequestImGroupOpenSpaceModel = None,
        im_single_open_deliver_model: CreateAndDeliverRequestImSingleOpenDeliverModel = None,
        im_single_open_space_model: CreateAndDeliverRequestImSingleOpenSpaceModel = None,
        open_dynamic_data_config: CreateAndDeliverRequestOpenDynamicDataConfig = None,
        open_space_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        top_open_deliver_model: CreateAndDeliverRequestTopOpenDeliverModel = None,
        top_open_space_model: CreateAndDeliverRequestTopOpenSpaceModel = None,
        user_id: str = None,
        user_id_type: int = None,
        work_bench_open_deliver_model: CreateAndDeliverRequestWorkBenchOpenDeliverModel = None,
        work_bench_open_space_model: CreateAndDeliverRequestWorkBenchOpenSpaceModel = None,
    ):
        # 卡片回调时的路由 key
        self.callback_route_key = callback_route_key
        self.card_at_user_ids = card_at_user_ids
        # 卡片数据
        self.card_data = card_data
        # 卡片内容模板ID
        self.card_template_id = card_template_id
        # 协作投放参数
        self.co_feed_open_deliver_model = co_feed_open_deliver_model
        # 协作场域信息
        self.co_feed_open_space_model = co_feed_open_space_model
        # 群聊投放参数
        self.im_group_open_deliver_model = im_group_open_deliver_model
        # IM群聊场域信息
        self.im_group_open_space_model = im_group_open_space_model
        # 单聊场域投放参数
        self.im_single_open_deliver_model = im_single_open_deliver_model
        # IM单聊场域信息
        self.im_single_open_space_model = im_single_open_space_model
        # 动态数据源配置
        self.open_dynamic_data_config = open_dynamic_data_config
        # dt.card//spaceType.spaceId;spaceType.spaceId
        self.open_space_id = open_space_id
        # 外部业务标识符
        self.out_track_id = out_track_id
        self.private_data = private_data
        # 吊顶投放参数
        self.top_open_deliver_model = top_open_deliver_model
        # 吊顶场域信息
        self.top_open_space_model = top_open_space_model
        # 卡片创建者 id
        self.user_id = user_id
        self.user_id_type = user_id_type
        # 工作台投放参数
        self.work_bench_open_deliver_model = work_bench_open_deliver_model
        # 工作台场域信息
        self.work_bench_open_space_model = work_bench_open_space_model

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.co_feed_open_deliver_model:
            self.co_feed_open_deliver_model.validate()
        if self.co_feed_open_space_model:
            self.co_feed_open_space_model.validate()
        if self.im_group_open_deliver_model:
            self.im_group_open_deliver_model.validate()
        if self.im_group_open_space_model:
            self.im_group_open_space_model.validate()
        if self.im_single_open_deliver_model:
            self.im_single_open_deliver_model.validate()
        if self.im_single_open_space_model:
            self.im_single_open_space_model.validate()
        if self.open_dynamic_data_config:
            self.open_dynamic_data_config.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()
        if self.top_open_deliver_model:
            self.top_open_deliver_model.validate()
        if self.top_open_space_model:
            self.top_open_space_model.validate()
        if self.work_bench_open_deliver_model:
            self.work_bench_open_deliver_model.validate()
        if self.work_bench_open_space_model:
            self.work_bench_open_space_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_at_user_ids is not None:
            result['cardAtUserIds'] = self.card_at_user_ids
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.co_feed_open_deliver_model is not None:
            result['coFeedOpenDeliverModel'] = self.co_feed_open_deliver_model.to_map()
        if self.co_feed_open_space_model is not None:
            result['coFeedOpenSpaceModel'] = self.co_feed_open_space_model.to_map()
        if self.im_group_open_deliver_model is not None:
            result['imGroupOpenDeliverModel'] = self.im_group_open_deliver_model.to_map()
        if self.im_group_open_space_model is not None:
            result['imGroupOpenSpaceModel'] = self.im_group_open_space_model.to_map()
        if self.im_single_open_deliver_model is not None:
            result['imSingleOpenDeliverModel'] = self.im_single_open_deliver_model.to_map()
        if self.im_single_open_space_model is not None:
            result['imSingleOpenSpaceModel'] = self.im_single_open_space_model.to_map()
        if self.open_dynamic_data_config is not None:
            result['openDynamicDataConfig'] = self.open_dynamic_data_config.to_map()
        if self.open_space_id is not None:
            result['openSpaceId'] = self.open_space_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.top_open_deliver_model is not None:
            result['topOpenDeliverModel'] = self.top_open_deliver_model.to_map()
        if self.top_open_space_model is not None:
            result['topOpenSpaceModel'] = self.top_open_space_model.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        if self.work_bench_open_deliver_model is not None:
            result['workBenchOpenDeliverModel'] = self.work_bench_open_deliver_model.to_map()
        if self.work_bench_open_space_model is not None:
            result['workBenchOpenSpaceModel'] = self.work_bench_open_space_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardAtUserIds') is not None:
            self.card_at_user_ids = m.get('cardAtUserIds')
        if m.get('cardData') is not None:
            temp_model = CreateAndDeliverRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('coFeedOpenDeliverModel') is not None:
            temp_model = CreateAndDeliverRequestCoFeedOpenDeliverModel()
            self.co_feed_open_deliver_model = temp_model.from_map(m['coFeedOpenDeliverModel'])
        if m.get('coFeedOpenSpaceModel') is not None:
            temp_model = CreateAndDeliverRequestCoFeedOpenSpaceModel()
            self.co_feed_open_space_model = temp_model.from_map(m['coFeedOpenSpaceModel'])
        if m.get('imGroupOpenDeliverModel') is not None:
            temp_model = CreateAndDeliverRequestImGroupOpenDeliverModel()
            self.im_group_open_deliver_model = temp_model.from_map(m['imGroupOpenDeliverModel'])
        if m.get('imGroupOpenSpaceModel') is not None:
            temp_model = CreateAndDeliverRequestImGroupOpenSpaceModel()
            self.im_group_open_space_model = temp_model.from_map(m['imGroupOpenSpaceModel'])
        if m.get('imSingleOpenDeliverModel') is not None:
            temp_model = CreateAndDeliverRequestImSingleOpenDeliverModel()
            self.im_single_open_deliver_model = temp_model.from_map(m['imSingleOpenDeliverModel'])
        if m.get('imSingleOpenSpaceModel') is not None:
            temp_model = CreateAndDeliverRequestImSingleOpenSpaceModel()
            self.im_single_open_space_model = temp_model.from_map(m['imSingleOpenSpaceModel'])
        if m.get('openDynamicDataConfig') is not None:
            temp_model = CreateAndDeliverRequestOpenDynamicDataConfig()
            self.open_dynamic_data_config = temp_model.from_map(m['openDynamicDataConfig'])
        if m.get('openSpaceId') is not None:
            self.open_space_id = m.get('openSpaceId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('topOpenDeliverModel') is not None:
            temp_model = CreateAndDeliverRequestTopOpenDeliverModel()
            self.top_open_deliver_model = temp_model.from_map(m['topOpenDeliverModel'])
        if m.get('topOpenSpaceModel') is not None:
            temp_model = CreateAndDeliverRequestTopOpenSpaceModel()
            self.top_open_space_model = temp_model.from_map(m['topOpenSpaceModel'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        if m.get('workBenchOpenDeliverModel') is not None:
            temp_model = CreateAndDeliverRequestWorkBenchOpenDeliverModel()
            self.work_bench_open_deliver_model = temp_model.from_map(m['workBenchOpenDeliverModel'])
        if m.get('workBenchOpenSpaceModel') is not None:
            temp_model = CreateAndDeliverRequestWorkBenchOpenSpaceModel()
            self.work_bench_open_space_model = temp_model.from_map(m['workBenchOpenSpaceModel'])
        return self


class CreateAndDeliverResponseBodyResultDeliverResults(TeaModel):
    def __init__(
        self,
        error_msg: str = None,
        space_id: str = None,
        space_type: str = None,
        success: bool = None,
    ):
        # 错误信息
        self.error_msg = error_msg
        # 场域Id
        self.space_id = space_id
        # 场域类型 (IM: IM类型，包括群聊和单聊，仅供返回结果使用, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type
        # 投放成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateAndDeliverResponseBodyResult(TeaModel):
    def __init__(
        self,
        deliver_results: List[CreateAndDeliverResponseBodyResultDeliverResults] = None,
        out_track_id: str = None,
    ):
        # 投放结果
        self.deliver_results = deliver_results
        # 外部卡片实例Id
        self.out_track_id = out_track_id

    def validate(self):
        if self.deliver_results:
            for k in self.deliver_results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deliverResults'] = []
        if self.deliver_results is not None:
            for k in self.deliver_results:
                result['deliverResults'].append(k.to_map() if k else None)
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.deliver_results = []
        if m.get('deliverResults') is not None:
            for k in m.get('deliverResults'):
                temp_model = CreateAndDeliverResponseBodyResultDeliverResults()
                self.deliver_results.append(temp_model.from_map(k))
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        return self


class CreateAndDeliverResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateAndDeliverResponseBodyResult = None,
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
            temp_model = CreateAndDeliverResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateAndDeliverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateAndDeliverResponseBody = None,
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
            temp_model = CreateAndDeliverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCardHeaders(TeaModel):
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


class CreateCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数，普通文本类型
        # ● key：参数名
        # ● value: 参数值
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class CreateCardRequestCoFeedOpenSpaceModel(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        # 卡片标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateCardRequestImGroupOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        # 【条件必填】通知内容
        # 若不填写则使用默认文案：如你收到1条新消息
        self.alert_content = alert_content
        # 是否推送通知，默认为 false
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class CreateCardRequestImGroupOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        #  【条件必填】供消息展示与搜索的字段
        #  【注意】最大限制200个字符，超过存储截断200
        self.search_desc = search_desc
        # 类型的icon，供搜索展示使用
        self.search_icon = search_icon
        # 卡片类型名
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class CreateCardRequestImGroupOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: CreateCardRequestImGroupOpenSpaceModelNotification = None,
        search_support: CreateCardRequestImGroupOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        # key为语言枚举值，value为lastMessage内容
        # 目前支持的语言枚举值：
        # 简体中文: ZH_CN
        # 繁体中文: ZH_TW
        # 英文： EN_US
        # 日语: JA_JP
        # 越南语: VI_VN
        self.last_message_i18n = last_message_i18n
        # 卡片的通知属性信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认 false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = CreateCardRequestImGroupOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = CreateCardRequestImGroupOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class CreateCardRequestImSingleOpenSpaceModelNotification(TeaModel):
    def __init__(
        self,
        alert_content: str = None,
        notification_off: bool = None,
    ):
        # 【条件必填】通知内容
        # 若不填写则使用默认文案：如你收到1条新消息
        self.alert_content = alert_content
        # 是否推送通知，默认为 false
        self.notification_off = notification_off

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alert_content is not None:
            result['alertContent'] = self.alert_content
        if self.notification_off is not None:
            result['notificationOff'] = self.notification_off
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alertContent') is not None:
            self.alert_content = m.get('alertContent')
        if m.get('notificationOff') is not None:
            self.notification_off = m.get('notificationOff')
        return self


class CreateCardRequestImSingleOpenSpaceModelSearchSupport(TeaModel):
    def __init__(
        self,
        search_desc: str = None,
        search_icon: str = None,
        search_type_name: str = None,
    ):
        # 【条件必填】供消息展示与搜索的字段
        #  【注意】最大限制200个字符，超过存储截断200
        self.search_desc = search_desc
        # 类型的icon，供搜索展示使用
        self.search_icon = search_icon
        # 卡片类型名
        self.search_type_name = search_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.search_desc is not None:
            result['searchDesc'] = self.search_desc
        if self.search_icon is not None:
            result['searchIcon'] = self.search_icon
        if self.search_type_name is not None:
            result['searchTypeName'] = self.search_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('searchDesc') is not None:
            self.search_desc = m.get('searchDesc')
        if m.get('searchIcon') is not None:
            self.search_icon = m.get('searchIcon')
        if m.get('searchTypeName') is not None:
            self.search_type_name = m.get('searchTypeName')
        return self


class CreateCardRequestImSingleOpenSpaceModel(TeaModel):
    def __init__(
        self,
        last_message_i18n: Dict[str, str] = None,
        notification: CreateCardRequestImSingleOpenSpaceModelNotification = None,
        search_support: CreateCardRequestImSingleOpenSpaceModelSearchSupport = None,
        support_forward: bool = None,
    ):
        # 支持国际化的LastMessage
        # key为语言枚举值，value为lastMessage内容
        # 目前支持的语言枚举值：
        # 简体中文: ZH_CN
        # 繁体中文: ZH_TW
        # 英文： EN_US
        # 日语: JA_JP
        # 越南语: VI_VN
        self.last_message_i18n = last_message_i18n
        # 卡片的通知属性信息
        self.notification = notification
        # 支持卡片消息可被搜索字段
        self.search_support = search_support
        # 是否支持转发, 默认 false
        self.support_forward = support_forward

    def validate(self):
        if self.notification:
            self.notification.validate()
        if self.search_support:
            self.search_support.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message_i18n is not None:
            result['lastMessageI18n'] = self.last_message_i18n
        if self.notification is not None:
            result['notification'] = self.notification.to_map()
        if self.search_support is not None:
            result['searchSupport'] = self.search_support.to_map()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessageI18n') is not None:
            self.last_message_i18n = m.get('lastMessageI18n')
        if m.get('notification') is not None:
            temp_model = CreateCardRequestImSingleOpenSpaceModelNotification()
            self.notification = temp_model.from_map(m['notification'])
        if m.get('searchSupport') is not None:
            temp_model = CreateCardRequestImSingleOpenSpaceModelSearchSupport()
            self.search_support = temp_model.from_map(m['searchSupport'])
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig(TeaModel):
    def __init__(
        self,
        interval: int = None,
        pull_strategy: str = None,
        time_unit: str = None,
    ):
        # 拉取的间隔时间，只在将 pullStrategy 设置为 INTERVAL 的时候生效
        self.interval = interval
        # 【条件必填】拉取策略，可选值：
        # ● NONE：不拉取，无动态数据
        # ● INTERVAL：间隔拉取
        # ● ONCE：只拉取一次
        self.pull_strategy = pull_strategy
        # 拉取的间隔时间的单位，只在将 pullStrategy 设置为 INTERVAL 的时候生效。 可选值：
        # ● SECONDS
        # ● MINUTES
        # ● HOURS
        # ● DAYS
        self.time_unit = time_unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.interval is not None:
            result['interval'] = self.interval
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        return self


class CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs(TeaModel):
    def __init__(
        self,
        const_params: Dict[str, str] = None,
        dynamic_data_source_id: str = None,
        pull_config: CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig = None,
    ):
        # 回调数据源的常量参数
        self.const_params = const_params
        # 【条件必填】数据源的唯一 ID
        self.dynamic_data_source_id = dynamic_data_source_id
        # 【条件必填】数据源拉取配置
        self.pull_config = pull_config

    def validate(self):
        if self.pull_config:
            self.pull_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.const_params is not None:
            result['constParams'] = self.const_params
        if self.dynamic_data_source_id is not None:
            result['dynamicDataSourceId'] = self.dynamic_data_source_id
        if self.pull_config is not None:
            result['pullConfig'] = self.pull_config.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('constParams') is not None:
            self.const_params = m.get('constParams')
        if m.get('dynamicDataSourceId') is not None:
            self.dynamic_data_source_id = m.get('dynamicDataSourceId')
        if m.get('pullConfig') is not None:
            temp_model = CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigsPullConfig()
            self.pull_config = temp_model.from_map(m['pullConfig'])
        return self


class CreateCardRequestOpenDynamicDataConfig(TeaModel):
    def __init__(
        self,
        dynamic_data_mapping: Dict[str, OpenDynamicDataConfigDynamicDataMappingValue] = None,
        dynamic_data_mapping_method: str = None,
        dynamic_data_source_configs: List[CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs] = None,
    ):
        # 动态数据替换关系
        # ● key：变量名
        # ● value：数据映射的配置
        self.dynamic_data_mapping = dynamic_data_mapping
        # 动态数据映射方法，可选值
        # ● REPLACE_WITHOUT_MAPPING：直接返回动态数据
        # ● MAPPING_BY_KEY：根据指定的规则，将返回数据映射到卡片数据上
        # 默认值：REPLACE_WITHOUT_MAPPING
        self.dynamic_data_mapping_method = dynamic_data_mapping_method
        # 动态数据源配置列表
        self.dynamic_data_source_configs = dynamic_data_source_configs

    def validate(self):
        if self.dynamic_data_mapping:
            for v in self.dynamic_data_mapping.values():
                if v:
                    v.validate()
        if self.dynamic_data_source_configs:
            for k in self.dynamic_data_source_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dynamicDataMapping'] = {}
        if self.dynamic_data_mapping is not None:
            for k, v in self.dynamic_data_mapping.items():
                result['dynamicDataMapping'][k] = v.to_map()
        if self.dynamic_data_mapping_method is not None:
            result['dynamicDataMappingMethod'] = self.dynamic_data_mapping_method
        result['dynamicDataSourceConfigs'] = []
        if self.dynamic_data_source_configs is not None:
            for k in self.dynamic_data_source_configs:
                result['dynamicDataSourceConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dynamic_data_mapping = {}
        if m.get('dynamicDataMapping') is not None:
            for k, v in m.get('dynamicDataMapping').items():
                temp_model = OpenDynamicDataConfigDynamicDataMappingValue()
                self.dynamic_data_mapping[k] = temp_model.from_map(v)
        if m.get('dynamicDataMappingMethod') is not None:
            self.dynamic_data_mapping_method = m.get('dynamicDataMappingMethod')
        self.dynamic_data_source_configs = []
        if m.get('dynamicDataSourceConfigs') is not None:
            for k in m.get('dynamicDataSourceConfigs'):
                temp_model = CreateCardRequestOpenDynamicDataConfigDynamicDataSourceConfigs()
                self.dynamic_data_source_configs.append(temp_model.from_map(k))
        return self


class CreateCardRequestTopOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 吊顶无其他场域属性，通过增加spaeType使卡片支持吊顶场域；吊顶对应spaceType为: ONE_BOX
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class CreateCardRequestWorkBenchOpenSpaceModel(TeaModel):
    def __init__(
        self,
        space_type: str = None,
    ):
        # 工作台无其他场域属性，通过增加spaeType使卡片支持工作台场域;工作台对应spaceType为: WORK_BENCH
        self.space_type = space_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        return self


class CreateCardRequest(TeaModel):
    def __init__(
        self,
        callback_route_key: str = None,
        card_at_user_ids: List[str] = None,
        card_data: CreateCardRequestCardData = None,
        card_template_id: str = None,
        co_feed_open_space_model: CreateCardRequestCoFeedOpenSpaceModel = None,
        im_group_open_space_model: CreateCardRequestImGroupOpenSpaceModel = None,
        im_single_open_space_model: CreateCardRequestImSingleOpenSpaceModel = None,
        open_dynamic_data_config: CreateCardRequestOpenDynamicDataConfig = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        top_open_space_model: CreateCardRequestTopOpenSpaceModel = None,
        user_id: str = None,
        user_id_type: int = None,
        work_bench_open_space_model: CreateCardRequestWorkBenchOpenSpaceModel = None,
    ):
        # 卡片回调时的路由 Key，用于查询注册的 callbackUrl
        self.callback_route_key = callback_route_key
        self.card_at_user_ids = card_at_user_ids
        # 卡片数据
        self.card_data = card_data
        # 卡片的模版 Id
        self.card_template_id = card_template_id
        # 协作场域信息
        self.co_feed_open_space_model = co_feed_open_space_model
        # IM 群聊场域信息
        self.im_group_open_space_model = im_group_open_space_model
        # IM 单聊场域信息
        self.im_single_open_space_model = im_single_open_space_model
        # 动态数据源配置
        self.open_dynamic_data_config = open_dynamic_data_config
        # 唯一标示卡片的外部编码
        self.out_track_id = out_track_id
        # 用户的私有数据。
        # ● key：userId
        # ● value：用户私有数据（cardData）
        self.private_data = private_data
        # 吊顶场域信息
        self.top_open_space_model = top_open_space_model
        # 卡片创建者的 userId
        self.user_id = user_id
        self.user_id_type = user_id_type
        # 工作台场域信息
        self.work_bench_open_space_model = work_bench_open_space_model

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.co_feed_open_space_model:
            self.co_feed_open_space_model.validate()
        if self.im_group_open_space_model:
            self.im_group_open_space_model.validate()
        if self.im_single_open_space_model:
            self.im_single_open_space_model.validate()
        if self.open_dynamic_data_config:
            self.open_dynamic_data_config.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()
        if self.top_open_space_model:
            self.top_open_space_model.validate()
        if self.work_bench_open_space_model:
            self.work_bench_open_space_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_at_user_ids is not None:
            result['cardAtUserIds'] = self.card_at_user_ids
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.co_feed_open_space_model is not None:
            result['coFeedOpenSpaceModel'] = self.co_feed_open_space_model.to_map()
        if self.im_group_open_space_model is not None:
            result['imGroupOpenSpaceModel'] = self.im_group_open_space_model.to_map()
        if self.im_single_open_space_model is not None:
            result['imSingleOpenSpaceModel'] = self.im_single_open_space_model.to_map()
        if self.open_dynamic_data_config is not None:
            result['openDynamicDataConfig'] = self.open_dynamic_data_config.to_map()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.top_open_space_model is not None:
            result['topOpenSpaceModel'] = self.top_open_space_model.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        if self.work_bench_open_space_model is not None:
            result['workBenchOpenSpaceModel'] = self.work_bench_open_space_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardAtUserIds') is not None:
            self.card_at_user_ids = m.get('cardAtUserIds')
        if m.get('cardData') is not None:
            temp_model = CreateCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('coFeedOpenSpaceModel') is not None:
            temp_model = CreateCardRequestCoFeedOpenSpaceModel()
            self.co_feed_open_space_model = temp_model.from_map(m['coFeedOpenSpaceModel'])
        if m.get('imGroupOpenSpaceModel') is not None:
            temp_model = CreateCardRequestImGroupOpenSpaceModel()
            self.im_group_open_space_model = temp_model.from_map(m['imGroupOpenSpaceModel'])
        if m.get('imSingleOpenSpaceModel') is not None:
            temp_model = CreateCardRequestImSingleOpenSpaceModel()
            self.im_single_open_space_model = temp_model.from_map(m['imSingleOpenSpaceModel'])
        if m.get('openDynamicDataConfig') is not None:
            temp_model = CreateCardRequestOpenDynamicDataConfig()
            self.open_dynamic_data_config = temp_model.from_map(m['openDynamicDataConfig'])
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('topOpenSpaceModel') is not None:
            temp_model = CreateCardRequestTopOpenSpaceModel()
            self.top_open_space_model = temp_model.from_map(m['topOpenSpaceModel'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        if m.get('workBenchOpenSpaceModel') is not None:
            temp_model = CreateCardRequestWorkBenchOpenSpaceModel()
            self.work_bench_open_space_model = temp_model.from_map(m['workBenchOpenSpaceModel'])
        return self


class CreateCardResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCardResponseBody = None,
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
            temp_model = CreateCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeliverCardHeaders(TeaModel):
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


class DeliverCardRequestCoFeedOpenDeliverModel(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        gmt_time_line: int = None,
    ):
        # 【必填】业务标识
        self.biz_tag = biz_tag
        # 【必填】协作场域下的排序时间
        self.gmt_time_line = gmt_time_line

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.gmt_time_line is not None:
            result['gmtTimeLine'] = self.gmt_time_line
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('gmtTimeLine') is not None:
            self.gmt_time_line = m.get('gmtTimeLine')
        return self


class DeliverCardRequestImGroupOpenDeliverModel(TeaModel):
    def __init__(
        self,
        at_user_ids: Dict[str, str] = None,
        recipients: List[str] = None,
        robot_code: str = None,
    ):
        # 消息@人，
        self.at_user_ids = at_user_ids
        # 指定接收者
        self.recipients = recipients
        # 机器人的code
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_user_ids is not None:
            result['atUserIds'] = self.at_user_ids
        if self.recipients is not None:
            result['recipients'] = self.recipients
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atUserIds') is not None:
            self.at_user_ids = m.get('atUserIds')
        if m.get('recipients') is not None:
            self.recipients = m.get('recipients')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class DeliverCardRequestImSingleOpenDeliverModel(TeaModel):
    def __init__(
        self,
        at_user_ids: Dict[str, str] = None,
    ):
        # 消息@人，
        self.at_user_ids = at_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_user_ids is not None:
            result['atUserIds'] = self.at_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atUserIds') is not None:
            self.at_user_ids = m.get('atUserIds')
        return self


class DeliverCardRequestTopOpenDeliverModel(TeaModel):
    def __init__(
        self,
        expired_time_mills: int = None,
        platforms: List[str] = None,
        user_ids: List[str] = None,
    ):
        # 【必填】过期时间戳
        self.expired_time_mills = expired_time_mills
        # 可以查看该吊顶卡片的设备
        self.platforms = platforms
        # 可以查看该吊顶卡片的staffId
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expired_time_mills is not None:
            result['expiredTimeMills'] = self.expired_time_mills
        if self.platforms is not None:
            result['platforms'] = self.platforms
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expiredTimeMills') is not None:
            self.expired_time_mills = m.get('expiredTimeMills')
        if m.get('platforms') is not None:
            self.platforms = m.get('platforms')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class DeliverCardRequestWorkBenchOpenDeliverModel(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        plugin_component_name: str = None,
        preview_url: str = None,
        project_name: str = None,
        user_id: str = None,
    ):
        # 【必填】组件icon对应组件左上角的图标
        self.icon = icon
        # 【必填】卡片名称
        self.name = name
        # 【必填】卡片组件名
        self.plugin_component_name = plugin_component_name
        # 【必填】卡片预览图
        self.preview_url = preview_url
        # 【必填】保持和微应用名称相同
        self.project_name = project_name
        # 【必填】操作者Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.plugin_component_name is not None:
            result['pluginComponentName'] = self.plugin_component_name
        if self.preview_url is not None:
            result['previewUrl'] = self.preview_url
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pluginComponentName') is not None:
            self.plugin_component_name = m.get('pluginComponentName')
        if m.get('previewUrl') is not None:
            self.preview_url = m.get('previewUrl')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeliverCardRequest(TeaModel):
    def __init__(
        self,
        co_feed_open_deliver_model: DeliverCardRequestCoFeedOpenDeliverModel = None,
        im_group_open_deliver_model: DeliverCardRequestImGroupOpenDeliverModel = None,
        im_single_open_deliver_model: DeliverCardRequestImSingleOpenDeliverModel = None,
        open_space_id: str = None,
        out_track_id: str = None,
        top_open_deliver_model: DeliverCardRequestTopOpenDeliverModel = None,
        work_bench_open_deliver_model: DeliverCardRequestWorkBenchOpenDeliverModel = None,
    ):
        # 协作投放参数
        self.co_feed_open_deliver_model = co_feed_open_deliver_model
        # 群聊投放参数
        self.im_group_open_deliver_model = im_group_open_deliver_model
        # 单聊场域投放参数
        self.im_single_open_deliver_model = im_single_open_deliver_model
        # dt.card//spaceType.spaceId;spaceType.spaceId
        self.open_space_id = open_space_id
        # 外部卡片实例Id
        self.out_track_id = out_track_id
        # 吊顶投放参数
        self.top_open_deliver_model = top_open_deliver_model
        # 工作台投放参数
        self.work_bench_open_deliver_model = work_bench_open_deliver_model

    def validate(self):
        if self.co_feed_open_deliver_model:
            self.co_feed_open_deliver_model.validate()
        if self.im_group_open_deliver_model:
            self.im_group_open_deliver_model.validate()
        if self.im_single_open_deliver_model:
            self.im_single_open_deliver_model.validate()
        if self.top_open_deliver_model:
            self.top_open_deliver_model.validate()
        if self.work_bench_open_deliver_model:
            self.work_bench_open_deliver_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.co_feed_open_deliver_model is not None:
            result['coFeedOpenDeliverModel'] = self.co_feed_open_deliver_model.to_map()
        if self.im_group_open_deliver_model is not None:
            result['imGroupOpenDeliverModel'] = self.im_group_open_deliver_model.to_map()
        if self.im_single_open_deliver_model is not None:
            result['imSingleOpenDeliverModel'] = self.im_single_open_deliver_model.to_map()
        if self.open_space_id is not None:
            result['openSpaceId'] = self.open_space_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.top_open_deliver_model is not None:
            result['topOpenDeliverModel'] = self.top_open_deliver_model.to_map()
        if self.work_bench_open_deliver_model is not None:
            result['workBenchOpenDeliverModel'] = self.work_bench_open_deliver_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coFeedOpenDeliverModel') is not None:
            temp_model = DeliverCardRequestCoFeedOpenDeliverModel()
            self.co_feed_open_deliver_model = temp_model.from_map(m['coFeedOpenDeliverModel'])
        if m.get('imGroupOpenDeliverModel') is not None:
            temp_model = DeliverCardRequestImGroupOpenDeliverModel()
            self.im_group_open_deliver_model = temp_model.from_map(m['imGroupOpenDeliverModel'])
        if m.get('imSingleOpenDeliverModel') is not None:
            temp_model = DeliverCardRequestImSingleOpenDeliverModel()
            self.im_single_open_deliver_model = temp_model.from_map(m['imSingleOpenDeliverModel'])
        if m.get('openSpaceId') is not None:
            self.open_space_id = m.get('openSpaceId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('topOpenDeliverModel') is not None:
            temp_model = DeliverCardRequestTopOpenDeliverModel()
            self.top_open_deliver_model = temp_model.from_map(m['topOpenDeliverModel'])
        if m.get('workBenchOpenDeliverModel') is not None:
            temp_model = DeliverCardRequestWorkBenchOpenDeliverModel()
            self.work_bench_open_deliver_model = temp_model.from_map(m['workBenchOpenDeliverModel'])
        return self


class DeliverCardResponseBodyResult(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        space_type: str = None,
        success: bool = None,
    ):
        # 场域Id
        self.space_id = space_id
        # 场域类型 (IM: IM, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
        self.space_type = space_type
        # 投放成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeliverCardResponseBody(TeaModel):
    def __init__(
        self,
        result: List[DeliverCardResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = DeliverCardResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeliverCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeliverCardResponseBody = None,
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
            temp_model = DeliverCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterCallbackHeaders(TeaModel):
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


class RegisterCallbackRequest(TeaModel):
    def __init__(
        self,
        api_secret: str = None,
        callback_route_key: str = None,
        callback_url: str = None,
        force_update: bool = None,
    ):
        # 加密密钥用于校验来源
        self.api_secret = api_secret
        # callbackUrl 的路由 Key，一个 callbackRouteKey 可以映射一个 callbackUrl
        self.callback_route_key = callback_route_key
        # 注册的回调 URL
        self.callback_url = callback_url
        # 是否强制覆盖更新，默认 false
        self.force_update = force_update

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.force_update is not None:
            result['forceUpdate'] = self.force_update
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('forceUpdate') is not None:
            self.force_update = m.get('forceUpdate')
        return self


class RegisterCallbackResponseBodyResult(TeaModel):
    def __init__(
        self,
        api_secret: str = None,
        callback_url: str = None,
    ):
        # api 签名密钥
        self.api_secret = api_secret
        # ISV 接受动态卡片点击的回调地址
        self.callback_url = callback_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        return self


class RegisterCallbackResponseBody(TeaModel):
    def __init__(
        self,
        result: RegisterCallbackResponseBodyResult = None,
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
            temp_model = RegisterCallbackResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RegisterCallbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RegisterCallbackResponseBody = None,
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
            temp_model = RegisterCallbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCardHeaders(TeaModel):
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


class UpdateCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数，普通文本类型
        # ● key：参数名
        # ● value: 参数值
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class UpdateCardRequestCardUpdateOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        # 按 key 更新 cardData 数据，不填默认覆盖更新。
        self.update_card_data_by_key = update_card_data_by_key
        # 【可选】按key更新privateData用户数据，不填默认覆盖更新。
        self.update_private_data_by_key = update_private_data_by_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.update_card_data_by_key is not None:
            result['updateCardDataByKey'] = self.update_card_data_by_key
        if self.update_private_data_by_key is not None:
            result['updatePrivateDataByKey'] = self.update_private_data_by_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updateCardDataByKey') is not None:
            self.update_card_data_by_key = m.get('updateCardDataByKey')
        if m.get('updatePrivateDataByKey') is not None:
            self.update_private_data_by_key = m.get('updatePrivateDataByKey')
        return self


class UpdateCardRequest(TeaModel):
    def __init__(
        self,
        card_data: UpdateCardRequestCardData = None,
        card_update_options: UpdateCardRequestCardUpdateOptions = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
    ):
        # 卡片数据
        self.card_data = card_data
        # 卡片更新选项
        self.card_update_options = card_update_options
        # 【必填】外部卡片实例Id
        self.out_track_id = out_track_id
        # 用户的私有数据。
        # ● key：userId
        # ● value：用户私有数据（cardData）
        self.private_data = private_data

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_update_options:
            self.card_update_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_update_options is not None:
            result['cardUpdateOptions'] = self.card_update_options.to_map()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardData') is not None:
            temp_model = UpdateCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardUpdateOptions') is not None:
            temp_model = UpdateCardRequestCardUpdateOptions()
            self.card_update_options = temp_model.from_map(m['cardUpdateOptions'])
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        return self


class UpdateCardResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateCardResponseBody = None,
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
            temp_model = UpdateCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


