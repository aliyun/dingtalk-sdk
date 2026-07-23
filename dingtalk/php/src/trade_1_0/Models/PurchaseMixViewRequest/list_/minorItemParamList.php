<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_;

use AlibabaCloud\Tea\Model;

class minorItemParamList extends Model
{
    /**
     * @var string
     */
    public $minorItemCode;

    /**
     * @var string
     */
    public $minorItemGroupCode;
    protected $_name = [
        'minorItemCode' => 'minorItemCode',
        'minorItemGroupCode' => 'minorItemGroupCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->minorItemCode) {
            $res['minorItemCode'] = $this->minorItemCode;
        }
        if (null !== $this->minorItemGroupCode) {
            $res['minorItemGroupCode'] = $this->minorItemGroupCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return minorItemParamList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minorItemCode'])) {
            $model->minorItemCode = $map['minorItemCode'];
        }
        if (isset($map['minorItemGroupCode'])) {
            $model->minorItemGroupCode = $map['minorItemGroupCode'];
        }

        return $model;
    }
}
