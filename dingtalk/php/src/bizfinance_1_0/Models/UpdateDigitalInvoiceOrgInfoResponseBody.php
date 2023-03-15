<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateDigitalInvoiceOrgInfoResponseBody extends Model
{
    /**
     * @description 返回结果
     *
     * @var bool
     */
    public $resulte;
    protected $_name = [
        'resulte' => 'resulte',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resulte) {
            $res['resulte'] = $this->resulte;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateDigitalInvoiceOrgInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resulte'])) {
            $model->resulte = $map['resulte'];
        }

        return $model;
    }
}
