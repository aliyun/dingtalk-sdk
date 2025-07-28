<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class ConfirmPaymentOrderRequest extends Model
{
    /**
     * @var string[]
     */
    public $outBizNoList;

    /**
     * @example 5041123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'outBizNoList' => 'outBizNoList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->outBizNoList) {
            $res['outBizNoList'] = $this->outBizNoList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConfirmPaymentOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outBizNoList'])) {
            if (!empty($map['outBizNoList'])) {
                $model->outBizNoList = $map['outBizNoList'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
