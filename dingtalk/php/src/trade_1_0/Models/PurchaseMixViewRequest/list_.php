<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_\itemComponentList;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewRequest\list_\minorItemParamList;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $activityId;

    /**
     * @var string
     */
    public $articleCode;

    /**
     * @var string
     */
    public $articleItemCode;

    /**
     * @var int
     */
    public $articleItemId;

    /**
     * @var string
     */
    public $articleItemName;

    /**
     * @var int
     */
    public $bizType;

    /**
     * @var int
     */
    public $couponId;

    /**
     * @var int
     */
    public $cycNum;

    /**
     * @var int
     */
    public $cycType;

    /**
     * @var int
     */
    public $cycUnit;

    /**
     * @var int
     */
    public $extend1;

    /**
     * @var int
     */
    public $instanceNum;

    /**
     * @var bool
     */
    public $isCredit;

    /**
     * @var itemComponentList[]
     */
    public $itemComponentList;

    /**
     * @var minorItemParamList[]
     */
    public $minorItemParamList;

    /**
     * @var mixed[]
     */
    public $orderParamMap;

    /**
     * @var string
     */
    public $orderType;

    /**
     * @var string
     */
    public $saleMarketType;

    /**
     * @var int
     */
    public $saleOrgId;

    /**
     * @var int
     */
    public $subQuantity;

    /**
     * @var string
     */
    public $tradeModelType;
    protected $_name = [
        'activityId' => 'activityId',
        'articleCode' => 'articleCode',
        'articleItemCode' => 'articleItemCode',
        'articleItemId' => 'articleItemId',
        'articleItemName' => 'articleItemName',
        'bizType' => 'bizType',
        'couponId' => 'couponId',
        'cycNum' => 'cycNum',
        'cycType' => 'cycType',
        'cycUnit' => 'cycUnit',
        'extend1' => 'extend1',
        'instanceNum' => 'instanceNum',
        'isCredit' => 'isCredit',
        'itemComponentList' => 'itemComponentList',
        'minorItemParamList' => 'minorItemParamList',
        'orderParamMap' => 'orderParamMap',
        'orderType' => 'orderType',
        'saleMarketType' => 'saleMarketType',
        'saleOrgId' => 'saleOrgId',
        'subQuantity' => 'subQuantity',
        'tradeModelType' => 'tradeModelType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->articleCode) {
            $res['articleCode'] = $this->articleCode;
        }
        if (null !== $this->articleItemCode) {
            $res['articleItemCode'] = $this->articleItemCode;
        }
        if (null !== $this->articleItemId) {
            $res['articleItemId'] = $this->articleItemId;
        }
        if (null !== $this->articleItemName) {
            $res['articleItemName'] = $this->articleItemName;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->couponId) {
            $res['couponId'] = $this->couponId;
        }
        if (null !== $this->cycNum) {
            $res['cycNum'] = $this->cycNum;
        }
        if (null !== $this->cycType) {
            $res['cycType'] = $this->cycType;
        }
        if (null !== $this->cycUnit) {
            $res['cycUnit'] = $this->cycUnit;
        }
        if (null !== $this->extend1) {
            $res['extend1'] = $this->extend1;
        }
        if (null !== $this->instanceNum) {
            $res['instanceNum'] = $this->instanceNum;
        }
        if (null !== $this->isCredit) {
            $res['isCredit'] = $this->isCredit;
        }
        if (null !== $this->itemComponentList) {
            $res['itemComponentList'] = [];
            if (null !== $this->itemComponentList && \is_array($this->itemComponentList)) {
                $n = 0;
                foreach ($this->itemComponentList as $item) {
                    $res['itemComponentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->minorItemParamList) {
            $res['minorItemParamList'] = [];
            if (null !== $this->minorItemParamList && \is_array($this->minorItemParamList)) {
                $n = 0;
                foreach ($this->minorItemParamList as $item) {
                    $res['minorItemParamList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->orderParamMap) {
            $res['orderParamMap'] = $this->orderParamMap;
        }
        if (null !== $this->orderType) {
            $res['orderType'] = $this->orderType;
        }
        if (null !== $this->saleMarketType) {
            $res['saleMarketType'] = $this->saleMarketType;
        }
        if (null !== $this->saleOrgId) {
            $res['saleOrgId'] = $this->saleOrgId;
        }
        if (null !== $this->subQuantity) {
            $res['subQuantity'] = $this->subQuantity;
        }
        if (null !== $this->tradeModelType) {
            $res['tradeModelType'] = $this->tradeModelType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['articleCode'])) {
            $model->articleCode = $map['articleCode'];
        }
        if (isset($map['articleItemCode'])) {
            $model->articleItemCode = $map['articleItemCode'];
        }
        if (isset($map['articleItemId'])) {
            $model->articleItemId = $map['articleItemId'];
        }
        if (isset($map['articleItemName'])) {
            $model->articleItemName = $map['articleItemName'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['couponId'])) {
            $model->couponId = $map['couponId'];
        }
        if (isset($map['cycNum'])) {
            $model->cycNum = $map['cycNum'];
        }
        if (isset($map['cycType'])) {
            $model->cycType = $map['cycType'];
        }
        if (isset($map['cycUnit'])) {
            $model->cycUnit = $map['cycUnit'];
        }
        if (isset($map['extend1'])) {
            $model->extend1 = $map['extend1'];
        }
        if (isset($map['instanceNum'])) {
            $model->instanceNum = $map['instanceNum'];
        }
        if (isset($map['isCredit'])) {
            $model->isCredit = $map['isCredit'];
        }
        if (isset($map['itemComponentList'])) {
            if (!empty($map['itemComponentList'])) {
                $model->itemComponentList = [];
                $n = 0;
                foreach ($map['itemComponentList'] as $item) {
                    $model->itemComponentList[$n++] = null !== $item ? itemComponentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['minorItemParamList'])) {
            if (!empty($map['minorItemParamList'])) {
                $model->minorItemParamList = [];
                $n = 0;
                foreach ($map['minorItemParamList'] as $item) {
                    $model->minorItemParamList[$n++] = null !== $item ? minorItemParamList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['orderParamMap'])) {
            $model->orderParamMap = $map['orderParamMap'];
        }
        if (isset($map['orderType'])) {
            $model->orderType = $map['orderType'];
        }
        if (isset($map['saleMarketType'])) {
            $model->saleMarketType = $map['saleMarketType'];
        }
        if (isset($map['saleOrgId'])) {
            $model->saleOrgId = $map['saleOrgId'];
        }
        if (isset($map['subQuantity'])) {
            $model->subQuantity = $map['subQuantity'];
        }
        if (isset($map['tradeModelType'])) {
            $model->tradeModelType = $map['tradeModelType'];
        }

        return $model;
    }
}
