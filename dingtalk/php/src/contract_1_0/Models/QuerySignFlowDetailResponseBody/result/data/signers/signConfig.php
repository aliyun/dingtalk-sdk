<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers;

use AlibabaCloud\Tea\Model;

class signConfig extends Model
{
    /**
     * @var int
     */
    public $signOrder;
    protected $_name = [
        'signOrder' => 'signOrder',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->signOrder) {
            $res['signOrder'] = $this->signOrder;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signOrder'])) {
            $model->signOrder = $map['signOrder'];
        }

        return $model;
    }
}
