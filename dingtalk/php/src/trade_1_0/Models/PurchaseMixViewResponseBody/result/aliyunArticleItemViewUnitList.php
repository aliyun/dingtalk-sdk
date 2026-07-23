<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result;

use AlibabaCloud\Tea\Model;

class aliyunArticleItemViewUnitList extends Model
{
    /**
     * @var float
     */
    public $actualPayFee;

    /**
     * @var string
     */
    public $articleCode;

    /**
     * @var string
     */
    public $articleItemCode;

    /**
     * @var string[]
     */
    public $bizTagList;

    /**
     * @var int
     */
    public $endDate;

    /**
     * @var string
     */
    public $orderType;

    /**
     * @var float
     */
    public $payFee;

    /**
     * @var int
     */
    public $startDate;
    protected $_name = [
        'actualPayFee' => 'actualPayFee',
        'articleCode' => 'articleCode',
        'articleItemCode' => 'articleItemCode',
        'bizTagList' => 'bizTagList',
        'endDate' => 'endDate',
        'orderType' => 'orderType',
        'payFee' => 'payFee',
        'startDate' => 'startDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actualPayFee) {
            $res['actualPayFee'] = $this->actualPayFee;
        }
        if (null !== $this->articleCode) {
            $res['articleCode'] = $this->articleCode;
        }
        if (null !== $this->articleItemCode) {
            $res['articleItemCode'] = $this->articleItemCode;
        }
        if (null !== $this->bizTagList) {
            $res['bizTagList'] = $this->bizTagList;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->payFee) {
            $res['payFee'] = $this->payFee;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return aliyunArticleItemViewUnitList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actualPayFee'])) {
            $model->actualPayFee = $map['actualPayFee'];
        }
        if (isset($map['articleCode'])) {
            $model->articleCode = $map['articleCode'];
        }
        if (isset($map['articleItemCode'])) {
            $model->articleItemCode = $map['articleItemCode'];
        }
        if (isset($map['bizTagList'])) {
            if (!empty($map['bizTagList'])) {
                $model->bizTagList = $map['bizTagList'];
            }
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['payFee'])) {
            $model->payFee = $map['payFee'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
