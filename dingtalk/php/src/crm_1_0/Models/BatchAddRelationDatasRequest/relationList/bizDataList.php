<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList;

use AlibabaCloud\Tea\Model;

class bizDataList extends Model
{
    /**
     * @example {}
     *
     * @var string
     */
    public $extendValue;

    /**
     * @description This parameter is required.
     *
     * @example TextField_71U51A
     *
     * @var string
     */
    public $key;

    /**
     * @description This parameter is required.
     *
     * @example XX有限公司
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'extendValue' => 'extendValue',
        'key'         => 'key',
        'value'       => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extendValue) {
            $res['extendValue'] = $this->extendValue;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
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
        if (isset($map['extendValue'])) {
            $model->extendValue = $map['extendValue'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
