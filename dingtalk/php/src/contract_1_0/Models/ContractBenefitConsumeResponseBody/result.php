<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractBenefitConsumeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $consumeResult;
    protected $_name = [
        'consumeResult' => 'consumeResult',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->consumeResult) {
            $res['consumeResult'] = $this->consumeResult;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['consumeResult'])) {
            $model->consumeResult = $map['consumeResult'];
        }

        return $model;
    }
}
