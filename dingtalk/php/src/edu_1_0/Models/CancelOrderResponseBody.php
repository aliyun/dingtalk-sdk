<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelOrderResponseBody extends Model
{
    /**
     * @description 是否需要重试
     *
     * @var bool
     */
    public $needRetry;

    /**
     * @description 交易动作
     *
     * @var string
     */
    public $tradeAction;
    protected $_name = [
        'needRetry'   => 'needRetry',
        'tradeAction' => 'tradeAction',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->needRetry) {
            $res['needRetry'] = $this->needRetry;
        }
        if (null !== $this->tradeAction) {
            $res['tradeAction'] = $this->tradeAction;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['needRetry'])) {
            $model->needRetry = $map['needRetry'];
        }
        if (isset($map['tradeAction'])) {
            $model->tradeAction = $map['tradeAction'];
        }

        return $model;
    }
}
