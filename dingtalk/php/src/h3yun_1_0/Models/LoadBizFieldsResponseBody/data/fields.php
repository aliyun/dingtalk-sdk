<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data;

use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @description 显示名称
     *
     * @var string
     */
    public $label;

    /**
     * @description 字段名称
     *
     * @var string
     */
    public $fieldName;

    /**
     * @description 字段、自定义组件的数据类型。Bool=逻辑型，DataTime=日期型、日期组件，Double=双精度数值型，Int=整形，Long=长整形，String=长文本，ShortString=短文本，ByteArray=二进制流， Image=图片类型、图片组件，File=附件类型组件，TimeSpan=时间段。Unit=参与者（单人），UnitArray=参与者（多人），Html=html类型，Xml=xml类型 BizObject=业务对象，BizObjectArray=业务对象数组、子表组件，Association=关联到其他对象、关联组件，AssociationArray=关联对象数组，Map=地图类型，Address=地址类型，Formula=公式型空间，Signature=签名控件，Plugin=文字识别Bool
     *
     * @var string
     */
    public $bizDataType;
    protected $_name = [
        'label'       => 'label',
        'fieldName'   => 'fieldName',
        'bizDataType' => 'bizDataType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->bizDataType) {
            $res['bizDataType'] = $this->bizDataType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['bizDataType'])) {
            $model->bizDataType = $map['bizDataType'];
        }

        return $model;
    }
}
