<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInvoiceByPageShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $requestShrink;
    protected $_name = [
        'requestShrink' => 'request',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestShrink) {
            $res['request'] = $this->requestShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInvoiceByPageShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['request'])) {
            $model->requestShrink = $map['request'];
        }

        return $model;
    }
}
