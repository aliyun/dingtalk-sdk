<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList\mainOperationInfo;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList\media;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList\subOperationInfo;
use AlibabaCloud\Tea\Model;

class purchaseGoodsList extends Model
{
    /**
     * @var string[]
     */
    public $applicableVersion;

    /**
     * @var int
     */
    public $applyNum;

    /**
     * @var string[]
     */
    public $belongIndustry;

    /**
     * @example psi
     *
     * @var string
     */
    public $goodsId;

    /**
     * @example app_function
     *
     * @var string
     */
    public $goodsType;

    /**
     * @example https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/icon/进销存.png
     *
     * @var string
     */
    public $icon;

    /**
     * @var mainOperationInfo
     */
    public $mainOperationInfo;

    /**
     * @var media[]
     */
    public $media;

    /**
     * @example 10000
     *
     * @var string
     */
    public $price;

    /**
     * @var subOperationInfo
     */
    public $subOperationInfo;

    /**
     * @example 通过进销存管理，连接企业人、财、物，一站式解决进销存仓库管理难题。让货品成本有据可依，避免盲目采购；合理控制库存，防止滞销/脱销；通过往来对账确保资金安全。
     *
     * @var string
     */
    public $subTitle;

    /**
     * @var string[]
     */
    public $tag;

    /**
     * @example 进销存
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'applicableVersion' => 'applicableVersion',
        'applyNum' => 'applyNum',
        'belongIndustry' => 'belongIndustry',
        'goodsId' => 'goodsId',
        'goodsType' => 'goodsType',
        'icon' => 'icon',
        'mainOperationInfo' => 'mainOperationInfo',
        'media' => 'media',
        'price' => 'price',
        'subOperationInfo' => 'subOperationInfo',
        'subTitle' => 'subTitle',
        'tag' => 'tag',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->applicableVersion) {
            $res['applicableVersion'] = $this->applicableVersion;
        }
        if (null !== $this->applyNum) {
            $res['applyNum'] = $this->applyNum;
        }
        if (null !== $this->belongIndustry) {
            $res['belongIndustry'] = $this->belongIndustry;
        }
        if (null !== $this->goodsId) {
            $res['goodsId'] = $this->goodsId;
        }
        if (null !== $this->goodsType) {
            $res['goodsType'] = $this->goodsType;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->mainOperationInfo) {
            $res['mainOperationInfo'] = null !== $this->mainOperationInfo ? $this->mainOperationInfo->toMap() : null;
        }
        if (null !== $this->media) {
            $res['media'] = [];
            if (null !== $this->media && \is_array($this->media)) {
                $n = 0;
                foreach ($this->media as $item) {
                    $res['media'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->subOperationInfo) {
            $res['subOperationInfo'] = null !== $this->subOperationInfo ? $this->subOperationInfo->toMap() : null;
        }
        if (null !== $this->subTitle) {
            $res['subTitle'] = $this->subTitle;
        }
        if (null !== $this->tag) {
            $res['tag'] = $this->tag;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return purchaseGoodsList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applicableVersion'])) {
            if (!empty($map['applicableVersion'])) {
                $model->applicableVersion = $map['applicableVersion'];
            }
        }
        if (isset($map['applyNum'])) {
            $model->applyNum = $map['applyNum'];
        }
        if (isset($map['belongIndustry'])) {
            if (!empty($map['belongIndustry'])) {
                $model->belongIndustry = $map['belongIndustry'];
            }
        }
        if (isset($map['goodsId'])) {
            $model->goodsId = $map['goodsId'];
        }
        if (isset($map['goodsType'])) {
            $model->goodsType = $map['goodsType'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['mainOperationInfo'])) {
            $model->mainOperationInfo = mainOperationInfo::fromMap($map['mainOperationInfo']);
        }
        if (isset($map['media'])) {
            if (!empty($map['media'])) {
                $model->media = [];
                $n = 0;
                foreach ($map['media'] as $item) {
                    $model->media[$n++] = null !== $item ? media::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['subOperationInfo'])) {
            $model->subOperationInfo = subOperationInfo::fromMap($map['subOperationInfo']);
        }
        if (isset($map['subTitle'])) {
            $model->subTitle = $map['subTitle'];
        }
        if (isset($map['tag'])) {
            if (!empty($map['tag'])) {
                $model->tag = $map['tag'];
            }
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
