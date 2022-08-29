<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\BatchCreateCustomerResponseBody;

use AlibabaCloud\Tea\Model;

class errorResult extends Model
{
    /**
     * @var string
     */
    public $errorKey;

    /**
     * @var string
     */
    public $errorMsg;
    protected $_name = [
        'errorKey' => 'errorKey',
        'errorMsg' => 'errorMsg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorKey) {
            $res['errorKey'] = $this->errorKey;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return errorResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorKey'])) {
            $model->errorKey = $map['errorKey'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }

        return $model;
    }
}
