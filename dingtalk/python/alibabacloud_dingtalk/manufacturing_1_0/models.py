# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class IndustrializeManufactureJobBookRequest(TeaModel):
    def __init__(
        self,
        scrapped_quantity: str = None,
        product_specification: str = None,
        qualified_quantity: str = None,
        reworkable_quantity: str = None,
        user_name: str = None,
        uuid: str = None,
        product_name: str = None,
        product_en_name: str = None,
        extend: str = None,
        product_code: str = None,
        process_name: str = None,
        process_en_name: str = None,
        mes_app_key: str = None,
        inst_no: str = None,
        manufacture_date: str = None,
        ding_corp_id: str = None,
    ):
        # 报废数量
        self.scrapped_quantity = scrapped_quantity
        # 产品规格
        self.product_specification = product_specification
        # 合格数量
        self.qualified_quantity = qualified_quantity
        # 可重工数量
        self.reworkable_quantity = reworkable_quantity
        # 员工姓名
        self.user_name = user_name
        # 随机串，唯一标识(用于幂等及更新)
        self.uuid = uuid
        # 产品名称，例如"双头螺柱001"
        self.product_name = product_name
        # 产品英文名称
        self.product_en_name = product_en_name
        # 扩展字段，用于增加自定义字段
        self.extend = extend
        # 产品唯一标识
        self.product_code = product_code
        # 制程名称
        self.process_name = process_name
        # 制程英文名称
        self.process_en_name = process_en_name
        # mes 系统唯一标识
        self.mes_app_key = mes_app_key
        # 工单编号
        self.inst_no = inst_no
        # 生产日期时间(到时分秒)
        self.manufacture_date = manufacture_date
        # 钉钉组织id
        self.ding_corp_id = ding_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scrapped_quantity is not None:
            result['scrappedQuantity'] = self.scrapped_quantity
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.reworkable_quantity is not None:
            result['reworkableQuantity'] = self.reworkable_quantity
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_en_name is not None:
            result['productEnName'] = self.product_en_name
        if self.extend is not None:
            result['extend'] = self.extend
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.process_en_name is not None:
            result['processEnName'] = self.process_en_name
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.manufacture_date is not None:
            result['manufactureDate'] = self.manufacture_date
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scrappedQuantity') is not None:
            self.scrapped_quantity = m.get('scrappedQuantity')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('reworkableQuantity') is not None:
            self.reworkable_quantity = m.get('reworkableQuantity')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productEnName') is not None:
            self.product_en_name = m.get('productEnName')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('processEnName') is not None:
            self.process_en_name = m.get('processEnName')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('manufactureDate') is not None:
            self.manufacture_date = m.get('manufactureDate')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        return self


class IndustrializeManufactureJobBookResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        count: int = None,
    ):
        # 新增记录的数据id
        self.id = id
        # 更新记录的条数
        self.count = count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.count is not None:
            result['count'] = self.count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('count') is not None:
            self.count = m.get('count')
        return self


class IndustrializeManufactureJobBookResponseBody(TeaModel):
    def __init__(
        self,
        content: IndustrializeManufactureJobBookResponseBodyContent = None,
        uuid: str = None,
    ):
        # content
        self.content = content
        # 此次报工记录的唯一标识
        self.uuid = uuid

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = IndustrializeManufactureJobBookResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustrializeManufactureJobBookResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustrializeManufactureJobBookResponseBody = None,
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
            temp_model = IndustrializeManufactureJobBookResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


