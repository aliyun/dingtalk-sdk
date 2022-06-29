<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryInvoiceRelationCountResponseBody extends Model
{
    /**
     * @var int[]
     */
    public $relationCountMap;
    protected $_name = [
        'relationCountMap' => 'relationCountMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->relationCountMap) {
            $res['relationCountMap'] = $this->relationCountMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryInvoiceRelationCountResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['relationCountMap'])) {
            $model->relationCountMap = $map['relationCountMap'];
        }

        return $model;
    }
}
