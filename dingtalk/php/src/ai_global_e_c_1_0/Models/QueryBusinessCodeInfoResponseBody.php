<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\QueryBusinessCodeInfoResponseBody\skuList;
use AlibabaCloud\Tea\Model;

class QueryBusinessCodeInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $businessCode;

    /**
     * @var string
     */
    public $imageType;

    /**
     * @var string[]
     */
    public $imageUrls;

    /**
     * @var string
     */
    public $productId;

    /**
     * @var skuList[]
     */
    public $skuList;
    protected $_name = [
        'businessCode' => 'businessCode',
        'imageType' => 'imageType',
        'imageUrls' => 'imageUrls',
        'productId' => 'productId',
        'skuList' => 'skuList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessCode) {
            $res['businessCode'] = $this->businessCode;
        }
        if (null !== $this->imageType) {
            $res['imageType'] = $this->imageType;
        }
        if (null !== $this->imageUrls) {
            $res['imageUrls'] = $this->imageUrls;
        }
        if (null !== $this->productId) {
            $res['productId'] = $this->productId;
        }
        if (null !== $this->skuList) {
            $res['skuList'] = [];
            if (null !== $this->skuList && \is_array($this->skuList)) {
                $n = 0;
                foreach ($this->skuList as $item) {
                    $res['skuList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBusinessCodeInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessCode'])) {
            $model->businessCode = $map['businessCode'];
        }
        if (isset($map['imageType'])) {
            $model->imageType = $map['imageType'];
        }
        if (isset($map['imageUrls'])) {
            if (!empty($map['imageUrls'])) {
                $model->imageUrls = $map['imageUrls'];
            }
        }
        if (isset($map['productId'])) {
            $model->productId = $map['productId'];
        }
        if (isset($map['skuList'])) {
            if (!empty($map['skuList'])) {
                $model->skuList = [];
                $n = 0;
                foreach ($map['skuList'] as $item) {
                    $model->skuList[$n++] = null !== $item ? skuList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
