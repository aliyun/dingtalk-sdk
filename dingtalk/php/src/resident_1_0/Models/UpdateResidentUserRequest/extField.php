<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserRequest;

use AlibabaCloud\Tea\Model;

class extField extends Model
{
    /**
     * @example 性别
     *
     * @var string
     */
    public $itemName;

    /**
     * @example 女
     *
     * @var string
     */
    public $itemValue;
    protected $_name = [
        'itemName' => 'itemName',
        'itemValue' => 'itemValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->itemValue) {
            $res['itemValue'] = $this->itemValue;
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
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['itemValue'])) {
            $model->itemValue = $map['itemValue'];
        }

        return $model;
    }
}
