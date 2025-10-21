<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchRequest;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchRequest\variants\optionValues;
use AlibabaCloud\Tea\Model;

class variants extends Model
{
    /**
     * @var string[]
     */
    public $images;

    /**
     * @var optionValues[]
     */
    public $optionValues;

    /**
     * @var string
     */
    public $price;

    /**
     * @var string
     */
    public $sku;
    protected $_name = [
        'images' => 'images',
        'optionValues' => 'optionValues',
        'price' => 'price',
        'sku' => 'sku',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->images) {
            $res['images'] = $this->images;
        }
        if (null !== $this->optionValues) {
            $res['optionValues'] = [];
            if (null !== $this->optionValues && \is_array($this->optionValues)) {
                $n = 0;
                foreach ($this->optionValues as $item) {
                    $res['optionValues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->sku) {
            $res['sku'] = $this->sku;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return variants
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['images'])) {
            if (!empty($map['images'])) {
                $model->images = $map['images'];
            }
        }
        if (isset($map['optionValues'])) {
            if (!empty($map['optionValues'])) {
                $model->optionValues = [];
                $n = 0;
                foreach ($map['optionValues'] as $item) {
                    $model->optionValues[$n++] = null !== $item ? optionValues::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['sku'])) {
            $model->sku = $map['sku'];
        }

        return $model;
    }
}
