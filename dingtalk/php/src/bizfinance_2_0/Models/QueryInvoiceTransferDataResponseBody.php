<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryInvoiceTransferDataResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $keyToData;
    protected $_name = [
        'keyToData' => 'keyToData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->keyToData) {
            $res['keyToData'] = $this->keyToData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInvoiceTransferDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['keyToData'])) {
            $model->keyToData = $map['keyToData'];
        }

        return $model;
    }
}
