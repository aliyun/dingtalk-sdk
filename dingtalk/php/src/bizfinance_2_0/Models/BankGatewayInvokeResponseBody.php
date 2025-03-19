<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BankGatewayInvokeResponseBody extends Model
{
    /**
     * @var string
     */
    public $outputData;
    protected $_name = [
        'outputData' => 'outputData',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->outputData) {
            $res['outputData'] = $this->outputData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BankGatewayInvokeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outputData'])) {
            $model->outputData = $map['outputData'];
        }

        return $model;
    }
}
