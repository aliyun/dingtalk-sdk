<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataQueryRequest\queryParams;

use AlibabaCloud\Tea\Model;

class conditionList extends Model
{
    /**
     * @description 字段关系符
     *
     * @var string
     */
    public $operate;

    /**
     * @description 操作值
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'operate' => 'operate',
        'value'   => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operate) {
            $res['operate'] = $this->operate;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conditionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operate'])) {
            $model->operate = $map['operate'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
