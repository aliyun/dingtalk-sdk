<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentUsersRequest;

use AlibabaCloud\Tea\Model;

class extField extends Model
{
    /**
     * @description 扩展字段值
     *
     * @var string
     */
    public $itemValue;

    /**
     * @description 扩展字段名字
     *
     * @var string
     */
    public $itemName;
    protected $_name = [
        'itemValue' => 'itemValue',
        'itemName'  => 'itemName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemValue) {
            $res['itemValue'] = $this->itemValue;
        }
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extField
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemValue'])) {
            $model->itemValue = $map['itemValue'];
        }
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }

        return $model;
    }
}
