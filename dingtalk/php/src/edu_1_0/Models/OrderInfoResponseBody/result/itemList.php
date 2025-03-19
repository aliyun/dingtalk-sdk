<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\OrderInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class itemList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 商品名称
     *
     * @var string
     */
    public $itemName;

    /**
     * @example 2
     *
     * @var string
     */
    public $itemNum;
    protected $_name = [
        'itemName' => 'itemName',
        'itemNum' => 'itemNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemName) {
            $res['itemName'] = $this->itemName;
        }
        if (null !== $this->itemNum) {
            $res['itemNum'] = $this->itemNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itemList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemName'])) {
            $model->itemName = $map['itemName'];
        }
        if (isset($map['itemNum'])) {
            $model->itemNum = $map['itemNum'];
        }

        return $model;
    }
}
