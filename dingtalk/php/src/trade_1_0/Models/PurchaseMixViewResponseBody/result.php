<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result\aliyunArticleItemViewUnitList;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result\mixPromotionVO;
use AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result\recommendedMarketingCollocationDTO;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var aliyunArticleItemViewUnitList[]
     */
    public $aliyunArticleItemViewUnitList;

    /**
     * @var mixPromotionVO
     */
    public $mixPromotionVO;

    /**
     * @var recommendedMarketingCollocationDTO
     */
    public $recommendedMarketingCollocationDTO;
    protected $_name = [
        'aliyunArticleItemViewUnitList' => 'aliyunArticleItemViewUnitList',
        'mixPromotionVO' => 'mixPromotionVO',
        'recommendedMarketingCollocationDTO' => 'recommendedMarketingCollocationDTO',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aliyunArticleItemViewUnitList) {
            $res['aliyunArticleItemViewUnitList'] = [];
            if (null !== $this->aliyunArticleItemViewUnitList && \is_array($this->aliyunArticleItemViewUnitList)) {
                $n = 0;
                foreach ($this->aliyunArticleItemViewUnitList as $item) {
                    $res['aliyunArticleItemViewUnitList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mixPromotionVO) {
            $res['mixPromotionVO'] = null !== $this->mixPromotionVO ? $this->mixPromotionVO->toMap() : null;
        }
        if (null !== $this->recommendedMarketingCollocationDTO) {
            $res['recommendedMarketingCollocationDTO'] = null !== $this->recommendedMarketingCollocationDTO ? $this->recommendedMarketingCollocationDTO->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aliyunArticleItemViewUnitList'])) {
            if (!empty($map['aliyunArticleItemViewUnitList'])) {
                $model->aliyunArticleItemViewUnitList = [];
                $n = 0;
                foreach ($map['aliyunArticleItemViewUnitList'] as $item) {
                    $model->aliyunArticleItemViewUnitList[$n++] = null !== $item ? aliyunArticleItemViewUnitList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mixPromotionVO'])) {
            $model->mixPromotionVO = mixPromotionVO::fromMap($map['mixPromotionVO']);
        }
        if (isset($map['recommendedMarketingCollocationDTO'])) {
            $model->recommendedMarketingCollocationDTO = recommendedMarketingCollocationDTO::fromMap($map['recommendedMarketingCollocationDTO']);
        }

        return $model;
    }
}
