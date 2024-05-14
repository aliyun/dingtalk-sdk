# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class PediaWordsAddHeaders(TeaModel):
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


class PediaWordsAddRequestContactList(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PediaWordsAddRequestPicList(TeaModel):
    def __init__(
        self,
        media_id_url: str = None,
    ):
        self.media_id_url = media_id_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id_url is not None:
            result['mediaIdUrl'] = self.media_id_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaIdUrl') is not None:
            self.media_id_url = m.get('mediaIdUrl')
        return self


class PediaWordsAddRequestRelatedDoc(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
        type: str = None,
    ):
        self.link = link
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PediaWordsAddRequestRelatedLink(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
    ):
        self.link = link
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class PediaWordsAddRequest(TeaModel):
    def __init__(
        self,
        contact_list: List[PediaWordsAddRequestContactList] = None,
        high_light_word_alias: List[str] = None,
        pic_list: List[PediaWordsAddRequestPicList] = None,
        related_doc: List[PediaWordsAddRequestRelatedDoc] = None,
        related_link: List[PediaWordsAddRequestRelatedLink] = None,
        user_id: str = None,
        word_alias: List[str] = None,
        word_name: str = None,
        word_paraphrase: str = None,
    ):
        self.contact_list = contact_list
        self.high_light_word_alias = high_light_word_alias
        self.pic_list = pic_list
        self.related_doc = related_doc
        self.related_link = related_link
        # This parameter is required.
        self.user_id = user_id
        self.word_alias = word_alias
        # This parameter is required.
        self.word_name = word_name
        # This parameter is required.
        self.word_paraphrase = word_paraphrase

    def validate(self):
        if self.contact_list:
            for k in self.contact_list:
                if k:
                    k.validate()
        if self.pic_list:
            for k in self.pic_list:
                if k:
                    k.validate()
        if self.related_doc:
            for k in self.related_doc:
                if k:
                    k.validate()
        if self.related_link:
            for k in self.related_link:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['contactList'] = []
        if self.contact_list is not None:
            for k in self.contact_list:
                result['contactList'].append(k.to_map() if k else None)
        if self.high_light_word_alias is not None:
            result['highLightWordAlias'] = self.high_light_word_alias
        result['picList'] = []
        if self.pic_list is not None:
            for k in self.pic_list:
                result['picList'].append(k.to_map() if k else None)
        result['relatedDoc'] = []
        if self.related_doc is not None:
            for k in self.related_doc:
                result['relatedDoc'].append(k.to_map() if k else None)
        result['relatedLink'] = []
        if self.related_link is not None:
            for k in self.related_link:
                result['relatedLink'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.word_alias is not None:
            result['wordAlias'] = self.word_alias
        if self.word_name is not None:
            result['wordName'] = self.word_name
        if self.word_paraphrase is not None:
            result['wordParaphrase'] = self.word_paraphrase
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.contact_list = []
        if m.get('contactList') is not None:
            for k in m.get('contactList'):
                temp_model = PediaWordsAddRequestContactList()
                self.contact_list.append(temp_model.from_map(k))
        if m.get('highLightWordAlias') is not None:
            self.high_light_word_alias = m.get('highLightWordAlias')
        self.pic_list = []
        if m.get('picList') is not None:
            for k in m.get('picList'):
                temp_model = PediaWordsAddRequestPicList()
                self.pic_list.append(temp_model.from_map(k))
        self.related_doc = []
        if m.get('relatedDoc') is not None:
            for k in m.get('relatedDoc'):
                temp_model = PediaWordsAddRequestRelatedDoc()
                self.related_doc.append(temp_model.from_map(k))
        self.related_link = []
        if m.get('relatedLink') is not None:
            for k in m.get('relatedLink'):
                temp_model = PediaWordsAddRequestRelatedLink()
                self.related_link.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('wordAlias') is not None:
            self.word_alias = m.get('wordAlias')
        if m.get('wordName') is not None:
            self.word_name = m.get('wordName')
        if m.get('wordParaphrase') is not None:
            self.word_paraphrase = m.get('wordParaphrase')
        return self


class PediaWordsAddResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        uuid: int = None,
    ):
        self.success = success
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsAddResponseBody = None,
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
            temp_model = PediaWordsAddResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PediaWordsApproveHeaders(TeaModel):
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


class PediaWordsApproveRequest(TeaModel):
    def __init__(
        self,
        approve_reason: str = None,
        approve_status: str = None,
        im_high_light: bool = None,
        sim_high_light: bool = None,
        user_id: str = None,
        uuid: int = None,
    ):
        self.approve_reason = approve_reason
        # This parameter is required.
        self.approve_status = approve_status
        # This parameter is required.
        self.im_high_light = im_high_light
        # This parameter is required.
        self.sim_high_light = sim_high_light
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_reason is not None:
            result['approveReason'] = self.approve_reason
        if self.approve_status is not None:
            result['approveStatus'] = self.approve_status
        if self.im_high_light is not None:
            result['imHighLight'] = self.im_high_light
        if self.sim_high_light is not None:
            result['simHighLight'] = self.sim_high_light
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveReason') is not None:
            self.approve_reason = m.get('approveReason')
        if m.get('approveStatus') is not None:
            self.approve_status = m.get('approveStatus')
        if m.get('imHighLight') is not None:
            self.im_high_light = m.get('imHighLight')
        if m.get('simHighLight') is not None:
            self.sim_high_light = m.get('simHighLight')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsApproveResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PediaWordsApproveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsApproveResponseBody = None,
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
            temp_model = PediaWordsApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PediaWordsDeleteHeaders(TeaModel):
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


class PediaWordsDeleteRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        uuid: int = None,
    ):
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsDeleteResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        uuid: int = None,
    ):
        self.success = success
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsDeleteResponseBody = None,
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
            temp_model = PediaWordsDeleteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PediaWordsQueryHeaders(TeaModel):
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


class PediaWordsQueryRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        uuid: int = None,
    ):
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsQueryResponseBodyDataAppLink(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        icon_link: str = None,
        pc_link: str = None,
        phone_link: str = None,
    ):
        self.app_name = app_name
        self.icon_link = icon_link
        self.pc_link = pc_link
        self.phone_link = phone_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.icon_link is not None:
            result['iconLink'] = self.icon_link
        if self.pc_link is not None:
            result['pcLink'] = self.pc_link
        if self.phone_link is not None:
            result['phoneLink'] = self.phone_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('iconLink') is not None:
            self.icon_link = m.get('iconLink')
        if m.get('pcLink') is not None:
            self.pc_link = m.get('pcLink')
        if m.get('phoneLink') is not None:
            self.phone_link = m.get('phoneLink')
        return self


class PediaWordsQueryResponseBodyDataContactList(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PediaWordsQueryResponseBodyDataPicList(TeaModel):
    def __init__(
        self,
        media_id_url: str = None,
    ):
        self.media_id_url = media_id_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id_url is not None:
            result['mediaIdUrl'] = self.media_id_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaIdUrl') is not None:
            self.media_id_url = m.get('mediaIdUrl')
        return self


class PediaWordsQueryResponseBodyDataRelatedDoc(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
        type: str = None,
    ):
        self.link = link
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PediaWordsQueryResponseBodyDataRelatedLink(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
    ):
        self.link = link
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class PediaWordsQueryResponseBodyData(TeaModel):
    def __init__(
        self,
        app_link: List[PediaWordsQueryResponseBodyDataAppLink] = None,
        approve_name: str = None,
        contact_list: List[PediaWordsQueryResponseBodyDataContactList] = None,
        contacts: List[str] = None,
        creator_name: str = None,
        gmt_create: int = None,
        gmt_modify: int = None,
        high_light_word_alias: List[str] = None,
        im_high_light: bool = None,
        parent_uuid: int = None,
        pic_list: List[PediaWordsQueryResponseBodyDataPicList] = None,
        related_doc: List[PediaWordsQueryResponseBodyDataRelatedDoc] = None,
        related_link: List[PediaWordsQueryResponseBodyDataRelatedLink] = None,
        sim_high_light: bool = None,
        simple_word_paraphrase: str = None,
        tags_list: List[str] = None,
        updater_name: str = None,
        user_id: str = None,
        uuid: int = None,
        word_alias: List[str] = None,
        word_name: str = None,
        word_paraphrase: str = None,
    ):
        self.app_link = app_link
        self.approve_name = approve_name
        self.contact_list = contact_list
        self.contacts = contacts
        self.creator_name = creator_name
        self.gmt_create = gmt_create
        self.gmt_modify = gmt_modify
        self.high_light_word_alias = high_light_word_alias
        self.im_high_light = im_high_light
        self.parent_uuid = parent_uuid
        self.pic_list = pic_list
        self.related_doc = related_doc
        self.related_link = related_link
        self.sim_high_light = sim_high_light
        self.simple_word_paraphrase = simple_word_paraphrase
        self.tags_list = tags_list
        self.updater_name = updater_name
        self.user_id = user_id
        self.uuid = uuid
        self.word_alias = word_alias
        self.word_name = word_name
        self.word_paraphrase = word_paraphrase

    def validate(self):
        if self.app_link:
            for k in self.app_link:
                if k:
                    k.validate()
        if self.contact_list:
            for k in self.contact_list:
                if k:
                    k.validate()
        if self.pic_list:
            for k in self.pic_list:
                if k:
                    k.validate()
        if self.related_doc:
            for k in self.related_doc:
                if k:
                    k.validate()
        if self.related_link:
            for k in self.related_link:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appLink'] = []
        if self.app_link is not None:
            for k in self.app_link:
                result['appLink'].append(k.to_map() if k else None)
        if self.approve_name is not None:
            result['approveName'] = self.approve_name
        result['contactList'] = []
        if self.contact_list is not None:
            for k in self.contact_list:
                result['contactList'].append(k.to_map() if k else None)
        if self.contacts is not None:
            result['contacts'] = self.contacts
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modify is not None:
            result['gmtModify'] = self.gmt_modify
        if self.high_light_word_alias is not None:
            result['highLightWordAlias'] = self.high_light_word_alias
        if self.im_high_light is not None:
            result['imHighLight'] = self.im_high_light
        if self.parent_uuid is not None:
            result['parentUuid'] = self.parent_uuid
        result['picList'] = []
        if self.pic_list is not None:
            for k in self.pic_list:
                result['picList'].append(k.to_map() if k else None)
        result['relatedDoc'] = []
        if self.related_doc is not None:
            for k in self.related_doc:
                result['relatedDoc'].append(k.to_map() if k else None)
        result['relatedLink'] = []
        if self.related_link is not None:
            for k in self.related_link:
                result['relatedLink'].append(k.to_map() if k else None)
        if self.sim_high_light is not None:
            result['simHighLight'] = self.sim_high_light
        if self.simple_word_paraphrase is not None:
            result['simpleWordParaphrase'] = self.simple_word_paraphrase
        if self.tags_list is not None:
            result['tagsList'] = self.tags_list
        if self.updater_name is not None:
            result['updaterName'] = self.updater_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.word_alias is not None:
            result['wordAlias'] = self.word_alias
        if self.word_name is not None:
            result['wordName'] = self.word_name
        if self.word_paraphrase is not None:
            result['wordParaphrase'] = self.word_paraphrase
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_link = []
        if m.get('appLink') is not None:
            for k in m.get('appLink'):
                temp_model = PediaWordsQueryResponseBodyDataAppLink()
                self.app_link.append(temp_model.from_map(k))
        if m.get('approveName') is not None:
            self.approve_name = m.get('approveName')
        self.contact_list = []
        if m.get('contactList') is not None:
            for k in m.get('contactList'):
                temp_model = PediaWordsQueryResponseBodyDataContactList()
                self.contact_list.append(temp_model.from_map(k))
        if m.get('contacts') is not None:
            self.contacts = m.get('contacts')
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModify') is not None:
            self.gmt_modify = m.get('gmtModify')
        if m.get('highLightWordAlias') is not None:
            self.high_light_word_alias = m.get('highLightWordAlias')
        if m.get('imHighLight') is not None:
            self.im_high_light = m.get('imHighLight')
        if m.get('parentUuid') is not None:
            self.parent_uuid = m.get('parentUuid')
        self.pic_list = []
        if m.get('picList') is not None:
            for k in m.get('picList'):
                temp_model = PediaWordsQueryResponseBodyDataPicList()
                self.pic_list.append(temp_model.from_map(k))
        self.related_doc = []
        if m.get('relatedDoc') is not None:
            for k in m.get('relatedDoc'):
                temp_model = PediaWordsQueryResponseBodyDataRelatedDoc()
                self.related_doc.append(temp_model.from_map(k))
        self.related_link = []
        if m.get('relatedLink') is not None:
            for k in m.get('relatedLink'):
                temp_model = PediaWordsQueryResponseBodyDataRelatedLink()
                self.related_link.append(temp_model.from_map(k))
        if m.get('simHighLight') is not None:
            self.sim_high_light = m.get('simHighLight')
        if m.get('simpleWordParaphrase') is not None:
            self.simple_word_paraphrase = m.get('simpleWordParaphrase')
        if m.get('tagsList') is not None:
            self.tags_list = m.get('tagsList')
        if m.get('updaterName') is not None:
            self.updater_name = m.get('updaterName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('wordAlias') is not None:
            self.word_alias = m.get('wordAlias')
        if m.get('wordName') is not None:
            self.word_name = m.get('wordName')
        if m.get('wordParaphrase') is not None:
            self.word_paraphrase = m.get('wordParaphrase')
        return self


class PediaWordsQueryResponseBody(TeaModel):
    def __init__(
        self,
        data: PediaWordsQueryResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = PediaWordsQueryResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PediaWordsQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsQueryResponseBody = None,
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
            temp_model = PediaWordsQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PediaWordsSearchHeaders(TeaModel):
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


class PediaWordsSearchRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        status: str = None,
        user_id: str = None,
        word_name: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.user_id = user_id
        self.word_name = word_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.word_name is not None:
            result['wordName'] = self.word_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('wordName') is not None:
            self.word_name = m.get('wordName')
        return self


class PediaWordsSearchResponseBodyDataAppLink(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        icon_link: str = None,
        pc_link: str = None,
        phone_link: str = None,
    ):
        self.app_name = app_name
        self.icon_link = icon_link
        self.pc_link = pc_link
        self.phone_link = phone_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.icon_link is not None:
            result['iconLink'] = self.icon_link
        if self.pc_link is not None:
            result['pcLink'] = self.pc_link
        if self.phone_link is not None:
            result['phoneLink'] = self.phone_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('iconLink') is not None:
            self.icon_link = m.get('iconLink')
        if m.get('pcLink') is not None:
            self.pc_link = m.get('pcLink')
        if m.get('phoneLink') is not None:
            self.phone_link = m.get('phoneLink')
        return self


class PediaWordsSearchResponseBodyDataContactList(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PediaWordsSearchResponseBodyDataPicList(TeaModel):
    def __init__(
        self,
        media_id_url: str = None,
    ):
        self.media_id_url = media_id_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id_url is not None:
            result['mediaIdUrl'] = self.media_id_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaIdUrl') is not None:
            self.media_id_url = m.get('mediaIdUrl')
        return self


class PediaWordsSearchResponseBodyDataRelatedDoc(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
        type: str = None,
    ):
        self.link = link
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PediaWordsSearchResponseBodyDataRelatedLink(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
        type: str = None,
    ):
        self.link = link
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PediaWordsSearchResponseBodyData(TeaModel):
    def __init__(
        self,
        app_link: List[PediaWordsSearchResponseBodyDataAppLink] = None,
        approve_name: str = None,
        contact_list: List[PediaWordsSearchResponseBodyDataContactList] = None,
        contacts: List[str] = None,
        creator_name: str = None,
        gmt_create: int = None,
        gmt_modify: int = None,
        high_light_word_alias: List[str] = None,
        im_high_light: bool = None,
        parent_uuid: int = None,
        pic_list: List[PediaWordsSearchResponseBodyDataPicList] = None,
        related_doc: List[PediaWordsSearchResponseBodyDataRelatedDoc] = None,
        related_link: List[PediaWordsSearchResponseBodyDataRelatedLink] = None,
        sim_high_light: bool = None,
        simple_word_paraphrase: str = None,
        tags_list: List[str] = None,
        updater_name: str = None,
        user_id: str = None,
        uuid: int = None,
        word_alias: List[str] = None,
        word_name: str = None,
        word_paraphrase: str = None,
    ):
        self.app_link = app_link
        self.approve_name = approve_name
        self.contact_list = contact_list
        self.contacts = contacts
        self.creator_name = creator_name
        self.gmt_create = gmt_create
        self.gmt_modify = gmt_modify
        self.high_light_word_alias = high_light_word_alias
        self.im_high_light = im_high_light
        self.parent_uuid = parent_uuid
        self.pic_list = pic_list
        self.related_doc = related_doc
        self.related_link = related_link
        self.sim_high_light = sim_high_light
        self.simple_word_paraphrase = simple_word_paraphrase
        self.tags_list = tags_list
        self.updater_name = updater_name
        self.user_id = user_id
        self.uuid = uuid
        self.word_alias = word_alias
        self.word_name = word_name
        self.word_paraphrase = word_paraphrase

    def validate(self):
        if self.app_link:
            for k in self.app_link:
                if k:
                    k.validate()
        if self.contact_list:
            for k in self.contact_list:
                if k:
                    k.validate()
        if self.pic_list:
            for k in self.pic_list:
                if k:
                    k.validate()
        if self.related_doc:
            for k in self.related_doc:
                if k:
                    k.validate()
        if self.related_link:
            for k in self.related_link:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appLink'] = []
        if self.app_link is not None:
            for k in self.app_link:
                result['appLink'].append(k.to_map() if k else None)
        if self.approve_name is not None:
            result['approveName'] = self.approve_name
        result['contactList'] = []
        if self.contact_list is not None:
            for k in self.contact_list:
                result['contactList'].append(k.to_map() if k else None)
        if self.contacts is not None:
            result['contacts'] = self.contacts
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modify is not None:
            result['gmtModify'] = self.gmt_modify
        if self.high_light_word_alias is not None:
            result['highLightWordAlias'] = self.high_light_word_alias
        if self.im_high_light is not None:
            result['imHighLight'] = self.im_high_light
        if self.parent_uuid is not None:
            result['parentUuid'] = self.parent_uuid
        result['picList'] = []
        if self.pic_list is not None:
            for k in self.pic_list:
                result['picList'].append(k.to_map() if k else None)
        result['relatedDoc'] = []
        if self.related_doc is not None:
            for k in self.related_doc:
                result['relatedDoc'].append(k.to_map() if k else None)
        result['relatedLink'] = []
        if self.related_link is not None:
            for k in self.related_link:
                result['relatedLink'].append(k.to_map() if k else None)
        if self.sim_high_light is not None:
            result['simHighLight'] = self.sim_high_light
        if self.simple_word_paraphrase is not None:
            result['simpleWordParaphrase'] = self.simple_word_paraphrase
        if self.tags_list is not None:
            result['tagsList'] = self.tags_list
        if self.updater_name is not None:
            result['updaterName'] = self.updater_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.word_alias is not None:
            result['wordAlias'] = self.word_alias
        if self.word_name is not None:
            result['wordName'] = self.word_name
        if self.word_paraphrase is not None:
            result['wordParaphrase'] = self.word_paraphrase
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_link = []
        if m.get('appLink') is not None:
            for k in m.get('appLink'):
                temp_model = PediaWordsSearchResponseBodyDataAppLink()
                self.app_link.append(temp_model.from_map(k))
        if m.get('approveName') is not None:
            self.approve_name = m.get('approveName')
        self.contact_list = []
        if m.get('contactList') is not None:
            for k in m.get('contactList'):
                temp_model = PediaWordsSearchResponseBodyDataContactList()
                self.contact_list.append(temp_model.from_map(k))
        if m.get('contacts') is not None:
            self.contacts = m.get('contacts')
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModify') is not None:
            self.gmt_modify = m.get('gmtModify')
        if m.get('highLightWordAlias') is not None:
            self.high_light_word_alias = m.get('highLightWordAlias')
        if m.get('imHighLight') is not None:
            self.im_high_light = m.get('imHighLight')
        if m.get('parentUuid') is not None:
            self.parent_uuid = m.get('parentUuid')
        self.pic_list = []
        if m.get('picList') is not None:
            for k in m.get('picList'):
                temp_model = PediaWordsSearchResponseBodyDataPicList()
                self.pic_list.append(temp_model.from_map(k))
        self.related_doc = []
        if m.get('relatedDoc') is not None:
            for k in m.get('relatedDoc'):
                temp_model = PediaWordsSearchResponseBodyDataRelatedDoc()
                self.related_doc.append(temp_model.from_map(k))
        self.related_link = []
        if m.get('relatedLink') is not None:
            for k in m.get('relatedLink'):
                temp_model = PediaWordsSearchResponseBodyDataRelatedLink()
                self.related_link.append(temp_model.from_map(k))
        if m.get('simHighLight') is not None:
            self.sim_high_light = m.get('simHighLight')
        if m.get('simpleWordParaphrase') is not None:
            self.simple_word_paraphrase = m.get('simpleWordParaphrase')
        if m.get('tagsList') is not None:
            self.tags_list = m.get('tagsList')
        if m.get('updaterName') is not None:
            self.updater_name = m.get('updaterName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('wordAlias') is not None:
            self.word_alias = m.get('wordAlias')
        if m.get('wordName') is not None:
            self.word_name = m.get('wordName')
        if m.get('wordParaphrase') is not None:
            self.word_paraphrase = m.get('wordParaphrase')
        return self


class PediaWordsSearchResponseBody(TeaModel):
    def __init__(
        self,
        data: List[PediaWordsSearchResponseBodyData] = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = PediaWordsSearchResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PediaWordsSearchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsSearchResponseBody = None,
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
            temp_model = PediaWordsSearchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PediaWordsUpdateHeaders(TeaModel):
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


class PediaWordsUpdateRequestAppLink(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        icon_link: str = None,
        pc_link: str = None,
        phone_link: str = None,
    ):
        self.app_name = app_name
        self.icon_link = icon_link
        self.pc_link = pc_link
        self.phone_link = phone_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.icon_link is not None:
            result['iconLink'] = self.icon_link
        if self.pc_link is not None:
            result['pcLink'] = self.pc_link
        if self.phone_link is not None:
            result['phoneLink'] = self.phone_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('iconLink') is not None:
            self.icon_link = m.get('iconLink')
        if m.get('pcLink') is not None:
            self.pc_link = m.get('pcLink')
        if m.get('phoneLink') is not None:
            self.phone_link = m.get('phoneLink')
        return self


class PediaWordsUpdateRequestContactList(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PediaWordsUpdateRequestPicList(TeaModel):
    def __init__(
        self,
        media_id_url: str = None,
    ):
        self.media_id_url = media_id_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id_url is not None:
            result['mediaIdUrl'] = self.media_id_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaIdUrl') is not None:
            self.media_id_url = m.get('mediaIdUrl')
        return self


class PediaWordsUpdateRequestRelatedDoc(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
        type: str = None,
    ):
        self.link = link
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PediaWordsUpdateRequestRelatedLink(TeaModel):
    def __init__(
        self,
        link: str = None,
        name: str = None,
    ):
        self.link = link
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.link is not None:
            result['link'] = self.link
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class PediaWordsUpdateRequest(TeaModel):
    def __init__(
        self,
        app_link: List[PediaWordsUpdateRequestAppLink] = None,
        contact_list: List[PediaWordsUpdateRequestContactList] = None,
        high_light_word_alias: List[str] = None,
        pic_list: List[PediaWordsUpdateRequestPicList] = None,
        related_doc: List[PediaWordsUpdateRequestRelatedDoc] = None,
        related_link: List[PediaWordsUpdateRequestRelatedLink] = None,
        user_id: str = None,
        uuid: int = None,
        word_alias: List[str] = None,
        word_name: str = None,
        word_paraphrase: str = None,
    ):
        self.app_link = app_link
        self.contact_list = contact_list
        self.high_light_word_alias = high_light_word_alias
        self.pic_list = pic_list
        self.related_doc = related_doc
        self.related_link = related_link
        self.user_id = user_id
        # This parameter is required.
        self.uuid = uuid
        self.word_alias = word_alias
        # This parameter is required.
        self.word_name = word_name
        # This parameter is required.
        self.word_paraphrase = word_paraphrase

    def validate(self):
        if self.app_link:
            for k in self.app_link:
                if k:
                    k.validate()
        if self.contact_list:
            for k in self.contact_list:
                if k:
                    k.validate()
        if self.pic_list:
            for k in self.pic_list:
                if k:
                    k.validate()
        if self.related_doc:
            for k in self.related_doc:
                if k:
                    k.validate()
        if self.related_link:
            for k in self.related_link:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appLink'] = []
        if self.app_link is not None:
            for k in self.app_link:
                result['appLink'].append(k.to_map() if k else None)
        result['contactList'] = []
        if self.contact_list is not None:
            for k in self.contact_list:
                result['contactList'].append(k.to_map() if k else None)
        if self.high_light_word_alias is not None:
            result['highLightWordAlias'] = self.high_light_word_alias
        result['picList'] = []
        if self.pic_list is not None:
            for k in self.pic_list:
                result['picList'].append(k.to_map() if k else None)
        result['relatedDoc'] = []
        if self.related_doc is not None:
            for k in self.related_doc:
                result['relatedDoc'].append(k.to_map() if k else None)
        result['relatedLink'] = []
        if self.related_link is not None:
            for k in self.related_link:
                result['relatedLink'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.word_alias is not None:
            result['wordAlias'] = self.word_alias
        if self.word_name is not None:
            result['wordName'] = self.word_name
        if self.word_paraphrase is not None:
            result['wordParaphrase'] = self.word_paraphrase
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_link = []
        if m.get('appLink') is not None:
            for k in m.get('appLink'):
                temp_model = PediaWordsUpdateRequestAppLink()
                self.app_link.append(temp_model.from_map(k))
        self.contact_list = []
        if m.get('contactList') is not None:
            for k in m.get('contactList'):
                temp_model = PediaWordsUpdateRequestContactList()
                self.contact_list.append(temp_model.from_map(k))
        if m.get('highLightWordAlias') is not None:
            self.high_light_word_alias = m.get('highLightWordAlias')
        self.pic_list = []
        if m.get('picList') is not None:
            for k in m.get('picList'):
                temp_model = PediaWordsUpdateRequestPicList()
                self.pic_list.append(temp_model.from_map(k))
        self.related_doc = []
        if m.get('relatedDoc') is not None:
            for k in m.get('relatedDoc'):
                temp_model = PediaWordsUpdateRequestRelatedDoc()
                self.related_doc.append(temp_model.from_map(k))
        self.related_link = []
        if m.get('relatedLink') is not None:
            for k in m.get('relatedLink'):
                temp_model = PediaWordsUpdateRequestRelatedLink()
                self.related_link.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('wordAlias') is not None:
            self.word_alias = m.get('wordAlias')
        if m.get('wordName') is not None:
            self.word_name = m.get('wordName')
        if m.get('wordParaphrase') is not None:
            self.word_paraphrase = m.get('wordParaphrase')
        return self


class PediaWordsUpdateResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        uuid: int = None,
    ):
        self.success = success
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class PediaWordsUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PediaWordsUpdateResponseBody = None,
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
            temp_model = PediaWordsUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


