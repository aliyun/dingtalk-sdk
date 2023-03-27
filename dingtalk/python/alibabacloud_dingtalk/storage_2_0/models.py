# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CommitFileHeaders(TeaModel):
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


class CommitFileRequestOptionAppProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CommitFileRequestOption(TeaModel):
    def __init__(
        self,
        app_properties: List[CommitFileRequestOptionAppProperties] = None,
        conflict_strategy: str = None,
        convert_to_online_doc: bool = None,
        size: int = None,
    ):
        # 文件在应用上的属性, 一个应用最多只能设置3个属性
        # 最大size:
        # 	3
        self.app_properties = app_properties
        # 文件名称冲突策略
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
        self.conflict_strategy = conflict_strategy
        # 是否转换成在线文档
        # 默认值:
        # 	false
        self.convert_to_online_doc = convert_to_online_doc
        # 默认文件大小, 单位:Byte
        # 如果此字段不为空，企业存储系统会校验文件实际大小是否和此字段是否一致，不一致会报错
        self.size = size

    def validate(self):
        if self.app_properties:
            for k in self.app_properties:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appProperties'] = []
        if self.app_properties is not None:
            for k in self.app_properties:
                result['appProperties'].append(k.to_map() if k else None)
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        if self.convert_to_online_doc is not None:
            result['convertToOnlineDoc'] = self.convert_to_online_doc
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = []
        if m.get('appProperties') is not None:
            for k in m.get('appProperties'):
                temp_model = CommitFileRequestOptionAppProperties()
                self.app_properties.append(temp_model.from_map(k))
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        if m.get('convertToOnlineDoc') is not None:
            self.convert_to_online_doc = m.get('convertToOnlineDoc')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class CommitFileRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: CommitFileRequestOption = None,
        upload_key: str = None,
        union_id: str = None,
    ):
        # 名称(文件名+后缀), 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.name = name
        # 可选参数
        self.option = option
        # 添加文件唯一标识，可通过DentryService.getUploadInfo来生成
        self.upload_key = upload_key
        # 用户id
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('option') is not None:
            temp_model = CommitFileRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CommitFileResponseBodyDentryProperties(TeaModel):
    def __init__(
        self,
        read_only: bool = None,
    ):
        # 文件是否只读
        self.read_only = read_only

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.read_only is not None:
            result['readOnly'] = self.read_only
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('readOnly') is not None:
            self.read_only = m.get('readOnly')
        return self


class CommitFileResponseBodyDentryThumbnail(TeaModel):
    def __init__(
        self,
        height: int = None,
        url: str = None,
        width: int = None,
    ):
        # 缩略图高度
        self.height = height
        # 缩略图url
        self.url = url
        # 缩略图宽度
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.height is not None:
            result['height'] = self.height
        if self.url is not None:
            result['url'] = self.url
        if self.width is not None:
            result['width'] = self.width
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('height') is not None:
            self.height = m.get('height')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('width') is not None:
            self.width = m.get('width')
        return self


class DentryAppPropertiesValue(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CommitFileResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        id: str = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        parent_id: str = None,
        partition_type: str = None,
        path: str = None,
        properties: CommitFileResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: CommitFileResponseBodyDentryThumbnail = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        # 最大size:
        # 	10
        self.app_properties = app_properties
        # 类别, 如图片、视频、音频等
        # 枚举值:
        # 	IMAGE: 图片
        # 	VIDEO: 视频
        # 	AUDIO: 音频
        # 	ARCHIVE: 压缩包
        # 	SHORTCUT: 快捷方式
        # 	DOCUMENT: 文档
        # 	ALI_DOC: 钉钉文档
        # 	OTHER: 其它
        self.category = category
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小, 单位:Byte
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	SHANJI: 闪记存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 缩略图信息
        self.thumbnail = thumbnail
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
        self.version = version

    def validate(self):
        if self.app_properties:
            for v in self.app_properties.values():
                for k1 in v:
                    if k1:
                        k1.validate()
        if self.properties:
            self.properties.validate()
        if self.thumbnail:
            self.thumbnail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appProperties'] = {}
        if self.app_properties is not None:
            for k, v in self.app_properties.items():
                l1 = []
                for k1 in v:
                    l1.append(k1.to_map() if k1 else None)
                result['appProperties'][k] = l1
        if self.category is not None:
            result['category'] = self.category
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.path is not None:
            result['path'] = self.path
        if self.properties is not None:
            result['properties'] = self.properties.to_map()
        if self.size is not None:
            result['size'] = self.size
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.status is not None:
            result['status'] = self.status
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        if self.thumbnail is not None:
            result['thumbnail'] = self.thumbnail.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = {}
        if m.get('appProperties') is not None:
            for k, v in m.get('appProperties').items():
                l1 = []
                for k1 in v:
                    temp_model = DentryAppPropertiesValue()
                    l1.append(temp_model.from_map(k1))
                self.app_properties['k'] = l1
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('properties') is not None:
            temp_model = CommitFileResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('thumbnail') is not None:
            temp_model = CommitFileResponseBodyDentryThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CommitFileResponseBody(TeaModel):
    def __init__(
        self,
        dentry: CommitFileResponseBodyDentry = None,
    ):
        # 文件信息
        self.dentry = dentry

    def validate(self):
        if self.dentry:
            self.dentry.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentry') is not None:
            temp_model = CommitFileResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        return self


class CommitFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CommitFileResponseBody = None,
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
            temp_model = CommitFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileUploadInfoHeaders(TeaModel):
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


class GetFileUploadInfoRequestOptionPreCheckParam(TeaModel):
    def __init__(
        self,
        name: str = None,
        size: int = None,
    ):
        # 文件名称, 文件名称合法性和文件名称冲突校验
        # 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.name = name
        # 文件大小, 做容量相关校验。不传则不做校验。
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class GetFileUploadInfoRequestOption(TeaModel):
    def __init__(
        self,
        pre_check_param: GetFileUploadInfoRequestOptionPreCheckParam = None,
        prefer_intranet: bool = None,
        prefer_region: str = None,
        storage_driver: str = None,
    ):
        # 预检查的字段。可实现对文件名称，文件完整性，容量的校验
        self.pre_check_param = pre_check_param
        # 优先使用内网传输
        # 前提: 配置了专属存储内网传输
        # 默认值:
        # 	true
        self.prefer_intranet = prefer_intranet
        # 优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能
        # 枚举值:
        # 	ZHANGJIAKOU: 张家口
        # 	SHENZHEN: 深圳
        # 	SHANGHAI: 上海
        # 	SINGAPORE: 新加坡
        # 	UNKNOWN: 未知
        self.prefer_region = prefer_region
        # 文件存储驱动类型, 当前只支持DINGTALK
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	SHANJI: 闪记存储驱动
        # 	UNKNOWN: 未知驱动
        # 默认值:
        # 	DINGTALK
        self.storage_driver = storage_driver

    def validate(self):
        if self.pre_check_param:
            self.pre_check_param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pre_check_param is not None:
            result['preCheckParam'] = self.pre_check_param.to_map()
        if self.prefer_intranet is not None:
            result['preferIntranet'] = self.prefer_intranet
        if self.prefer_region is not None:
            result['preferRegion'] = self.prefer_region
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preCheckParam') is not None:
            temp_model = GetFileUploadInfoRequestOptionPreCheckParam()
            self.pre_check_param = temp_model.from_map(m['preCheckParam'])
        if m.get('preferIntranet') is not None:
            self.prefer_intranet = m.get('preferIntranet')
        if m.get('preferRegion') is not None:
            self.prefer_region = m.get('preferRegion')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        return self


class GetFileUploadInfoRequest(TeaModel):
    def __init__(
        self,
        option: GetFileUploadInfoRequestOption = None,
        protocol: str = None,
        union_id: str = None,
    ):
        # 可选参数
        self.option = option
        # 通过指定上传协议返回不同协议上传所需要的信息
        # 对于部分企业开启了专属存储，必须实现HEADER加签，否则无法支持专属存储组织文件上传。
        # 如果指定上传协议不支持，则会返回错误Errors.DENTRY_UPLOAD_PROTOCOL_NOTSUPPORT, 请尝试用其它协议上传。
        # 枚举值:
        # 	HEADER_SIGNATURE: Header加签
        self.protocol = protocol
        # 用户id
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = GetFileUploadInfoRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFileUploadInfoResponseBodyHeaderSignatureInfo(TeaModel):
    def __init__(
        self,
        expiration_seconds: int = None,
        headers: Dict[str, str] = None,
        internal_resource_urls: List[str] = None,
        region: str = None,
        resource_urls: List[str] = None,
    ):
        # 过期时间，单位秒
        self.expiration_seconds = expiration_seconds
        # 请求头
        # 最大size:
        # 	20
        self.headers = headers
        # 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
        # 最大size:
        # 	10
        self.internal_resource_urls = internal_resource_urls
        # 地域
        # 枚举值:
        # 	ZHANGJIAKOU: 张家口
        # 	SHENZHEN: 深圳
        # 	SHANGHAI: 上海
        # 	SINGAPORE: 新加坡
        # 	UNKNOWN: 未知
        self.region = region
        # 多个上传下载URL, 前面url优先
        # 最大size:
        # 	10
        self.resource_urls = resource_urls

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expiration_seconds is not None:
            result['expirationSeconds'] = self.expiration_seconds
        if self.headers is not None:
            result['headers'] = self.headers
        if self.internal_resource_urls is not None:
            result['internalResourceUrls'] = self.internal_resource_urls
        if self.region is not None:
            result['region'] = self.region
        if self.resource_urls is not None:
            result['resourceUrls'] = self.resource_urls
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expirationSeconds') is not None:
            self.expiration_seconds = m.get('expirationSeconds')
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('internalResourceUrls') is not None:
            self.internal_resource_urls = m.get('internalResourceUrls')
        if m.get('region') is not None:
            self.region = m.get('region')
        if m.get('resourceUrls') is not None:
            self.resource_urls = m.get('resourceUrls')
        return self


class GetFileUploadInfoResponseBody(TeaModel):
    def __init__(
        self,
        header_signature_info: GetFileUploadInfoResponseBodyHeaderSignatureInfo = None,
        protocol: str = None,
        storage_driver: str = None,
        upload_key: str = None,
    ):
        # Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        self.header_signature_info = header_signature_info
        # 上传协议，根据不同上传类型返回对应的信息.
        # 枚举值:
        # 	HEADER_SIGNATURE: Header加签
        self.protocol = protocol
        # 文件存储类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	SHANJI: 闪记存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 上传唯一标识
        self.upload_key = upload_key

    def validate(self):
        if self.header_signature_info:
            self.header_signature_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.header_signature_info is not None:
            result['headerSignatureInfo'] = self.header_signature_info.to_map()
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headerSignatureInfo') is not None:
            temp_model = GetFileUploadInfoResponseBodyHeaderSignatureInfo()
            self.header_signature_info = temp_model.from_map(m['headerSignatureInfo'])
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        return self


class GetFileUploadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFileUploadInfoResponseBody = None,
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
            temp_model = GetFileUploadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


