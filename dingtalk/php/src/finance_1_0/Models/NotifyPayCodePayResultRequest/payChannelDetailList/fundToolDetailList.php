<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\NotifyPayCodePayResultRequest\payChannelDetailList;

use AlibabaCloud\Tea\Model;

class fundToolDetailList extends Model
{
    /**
     * @description 1.00
     *
     * @var string
     */
    public $amount;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description 资金渠道名称
     *
     * @var string
     */
    public $fundToolName;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $gmtFinish;

    /**
     * @description 是否是优惠工具
     *
     * @var bool
     */
    public $promotionFundTool;
    protected $_name = [
        'amount'            => 'amount',
        'extInfo'           => 'extInfo',
        'fundToolName'      => 'fundToolName',
        'gmtCreate'         => 'gmtCreate',
        'gmtFinish'         => 'gmtFinish',
        'promotionFundTool' => 'promotionFundTool',
    ];

    public function validate()
    {
    }

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
