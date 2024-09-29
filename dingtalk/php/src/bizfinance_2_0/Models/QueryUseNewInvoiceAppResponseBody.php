<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUseNewInvoiceAppResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $useNew;
    protected $_name = [
        'useNew' => 'useNew',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->useNew) {
            $res['useNew'] = $this->useNew;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUseNewInvoiceAppResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['useNew'])) {
            $model->useNew = $map['useNew'];
        }

        return $model;
    }
}
