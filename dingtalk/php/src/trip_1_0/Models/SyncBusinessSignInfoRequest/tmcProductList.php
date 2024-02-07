<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncBusinessSignInfoRequest\tmcProductList\productDetailList;
use AlibabaCloud\Tea\Model;

class tmcProductList extends Model
{
    /**
     * @var productDetailList[]
     */
    public $productDetailList;

    /**
     * @var string
     */
    public $tmcCorpId;
    protected $_name = [
        'productDetailList' => 'productDetailList',
        'tmcCorpId'         => 'tmcCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->productDetailList) {
            $res['productDetailList'] = [];
            if (null !== $this->productDetailList && \is_array($this->productDetailList)) {
                $n = 0;
                foreach ($this->productDetailList as $item) {
                    $res['productDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->tmcCorpId) {
            $res['tmcCorpId'] = $this->tmcCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tmcProductList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['productDetailList'])) {
            if (!empty($map['productDetailList'])) {
                $model->productDetailList = [];
                $n                        = 0;
                foreach ($map['productDetailList'] as $item) {
                    $model->productDetailList[$n++] = null !== $item ? productDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['tmcCorpId'])) {
            $model->tmcCorpId = $map['tmcCorpId'];
        }

        return $model;
    }
}
