<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\NotifyBadgeCodePayResultRequest\payChannelDetailList;

use AlibabaCloud\Tea\Model;

class fundToolDetailList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 金额
     *
     * @var string
     */
    public $amount;

    /**
     * @example {"key":"value"}
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description This parameter is required.
     *
     * @example 优惠券
     *
     * @var string
     */
    public $fundToolName;

    /**
     * @description This parameter is required.
     *
     * @example 2021-01-01
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 2021-01-01 11:11:11
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $promotionFundTool;
    protected $_name = [
        'amount' => 'amount',
        'extInfo' => 'extInfo',
        'fundToolName' => 'fundToolName',
        'gmtCreate' => 'gmtCreate',
        'gmtFinish' => 'gmtFinish',
        'promotionFundTool' => 'promotionFundTool',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->amount) {
            $res['amount'] = $this->amount;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->fundToolName) {
            $res['fundToolName'] = $this->fundToolName;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtFinish) {
            $res['gmtFinish'] = $this->gmtFinish;
        }
        if (null !== $this->promotionFundTool) {
            $res['promotionFundTool'] = $this->promotionFundTool;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fundToolDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['amount'])) {
            $model->amount = $map['amount'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['fundToolName'])) {
            $model->fundToolName = $map['fundToolName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtFinish'])) {
            $model->gmtFinish = $map['gmtFinish'];
        }
        if (isset($map['promotionFundTool'])) {
            $model->promotionFundTool = $map['promotionFundTool'];
        }

        return $model;
    }
}
