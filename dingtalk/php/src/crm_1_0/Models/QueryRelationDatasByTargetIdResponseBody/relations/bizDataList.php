<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryRelationDatasByTargetIdResponseBody\relations;

use AlibabaCloud\Tea\Model;

class bizDataList extends Model
{
    /**
     * @description 关系模型数据字段名。
     *
     * @var string
     */
    public $key;

    /**
     * @description 关系模型数据字段值。
     *
     * @var string
     */
    public $value;

    /**
     * @description 关系模型数据字段扩展值。
     *
     * @var string
     */
    public $extendValue;
    protected $_name = [
        'key'         => 'key',
        'value'       => 'value',
        'extendValue' => 'extendValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->extendValue) {
            $res['extendValue'] = $this->extendValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return bizDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['extendValue'])) {
            $model->extendValue = $map['extendValue'];
        }

        return $model;
    }
}
