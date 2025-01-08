<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryPaymentRecallFileRequest extends Model
{
    /**
     * @var string[]
     */
    public $detailIdList;

    /**
     * @var string
     */
    public $operator;
    protected $_name = [
        'detailIdList' => 'detailIdList',
        'operator'     => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailIdList) {
            $res['detailIdList'] = $this->detailIdList;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryPaymentRecallFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailIdList'])) {
            if (!empty($map['detailIdList'])) {
                $model->detailIdList = $map['detailIdList'];
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
