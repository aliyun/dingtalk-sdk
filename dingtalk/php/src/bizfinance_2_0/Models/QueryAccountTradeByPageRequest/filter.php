<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAccountTradeByPageRequest;

use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @example 10
     *
     * @var string
     */
    public $endAmount;

    /**
     * @example 钉钉
     *
     * @var string
     */
    public $otherAccountName;

    /**
     * @example 1
     *
     * @var string
     */
    public $startAmount;

    /**
     * @example in
     *
     * @var string
     */
    public $tradeType;
    protected $_name = [
        'endAmount'        => 'endAmount',
        'otherAccountName' => 'otherAccountName',
        'startAmount'      => 'startAmount',
        'tradeType'        => 'tradeType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endAmount) {
            $res['endAmount'] = $this->endAmount;
        }
        if (null !== $this->otherAccountName) {
            $res['otherAccountName'] = $this->otherAccountName;
        }
        if (null !== $this->startAmount) {
            $res['startAmount'] = $this->startAmount;
        }
        if (null !== $this->tradeType) {
            $res['tradeType'] = $this->tradeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endAmount'])) {
            $model->endAmount = $map['endAmount'];
        }
        if (isset($map['otherAccountName'])) {
            $model->otherAccountName = $map['otherAccountName'];
        }
        if (isset($map['startAmount'])) {
            $model->startAmount = $map['startAmount'];
        }
        if (isset($map['tradeType'])) {
            $model->tradeType = $map['tradeType'];
        }

        return $model;
    }
}
