<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataSaveRequest\body;

use AlibabaCloud\Tea\Model;

class fieldList extends Model
{
    /**
     * @description 字段名
     *
     * @var string
     */
    public $name;

    /**
     * @description 字段string值
     *
     * @var string
     */
    public $valueStr;
    protected $_name = [
        'name'     => 'name',
        'valueStr' => 'valueStr',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->valueStr) {
            $res['valueStr'] = $this->valueStr;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fieldList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['valueStr'])) {
            $model->valueStr = $map['valueStr'];
        }

        return $model;
    }
}
