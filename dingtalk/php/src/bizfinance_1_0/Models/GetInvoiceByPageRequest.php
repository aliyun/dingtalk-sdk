<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\GetInvoiceByPageRequest\request;
use AlibabaCloud\Tea\Model;

class GetInvoiceByPageRequest extends Model
{
    /**
     * @var request
     */
    public $request;
    protected $_name = [
        'request' => 'request',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->request) {
            $res['request'] = null !== $this->request ? $this->request->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInvoiceByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['request'])) {
            $model->request = request::fromMap($map['request']);
        }

        return $model;
    }
}
