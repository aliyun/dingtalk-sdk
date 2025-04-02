<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPaymentOrderDetailShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $outBizNoListShrink;

    /**
     * @example 50455845112
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'outBizNoListShrink' => 'outBizNoList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->outBizNoListShrink) {
            $res['outBizNoList'] = $this->outBizNoListShrink;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPaymentOrderDetailShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outBizNoList'])) {
            $model->outBizNoListShrink = $map['outBizNoList'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
