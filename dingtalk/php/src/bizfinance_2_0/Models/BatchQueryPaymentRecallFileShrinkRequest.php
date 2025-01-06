<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryPaymentRecallFileShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $detailIdListShrink;

    /**
     * @var string
     */
    public $opeator;
    protected $_name = [
        'detailIdListShrink' => 'detailIdList',
        'opeator'            => 'opeator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailIdListShrink) {
            $res['detailIdList'] = $this->detailIdListShrink;
        }
        if (null !== $this->opeator) {
            $res['opeator'] = $this->opeator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryPaymentRecallFileShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailIdList'])) {
            $model->detailIdListShrink = $map['detailIdList'];
        }
        if (isset($map['opeator'])) {
            $model->opeator = $map['opeator'];
        }

        return $model;
    }
}
