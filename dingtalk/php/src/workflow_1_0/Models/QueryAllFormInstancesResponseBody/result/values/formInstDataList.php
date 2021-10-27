<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QueryAllFormInstancesResponseBody\result\values;

use AlibabaCloud\Tea\Model;

class formInstDataList extends Model
{
    /**
     * @description 控件类型
     *
     * @var string
     */
    public $componentType;

    /**
     * @description 控件别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 表单控件扩展数据
     *
     * @var string
     */
    public $extendValue;

    /**
     * @description 控件名称
     *
     * @var string
     */
    public $label;

    /**
     * @description 控件填写的数据
     *
     * @var string
     */
    public $value;

    /**
     * @description 控件唯一id
     *
     * @var string
     */
    public $key;
    protected $_name = [
        'componentType' => 'componentType',
        'bizAlias'      => 'bizAlias',
        'extendValue'   => 'extendValue',
        'label'         => 'label',
        'value'         => 'value',
        'key'           => 'key',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->extendValue) {
            $res['extendValue'] = $this->extendValue;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formInstDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['extendValue'])) {
            $model->extendValue = $map['extendValue'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }

        return $model;
    }
}
