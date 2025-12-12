<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchRequest\variants;
use AlibabaCloud\Tea\Model;

class LaunchRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string[]
     */
    public $imageUrls;

    /**
     * @var string[]
     */
    public $platform;

    /**
     * @var string
     */
    public $productName;

    /**
     * @var string[]
     */
    public $sellingPoints;

    /**
     * @var string
     */
    public $sourceData;

    /**
     * @var variants[]
     */
    public $variants;

    /**
     * @var string[]
     */
    public $videoUrls;
    protected $_name = [
        'description' => 'description',
        'imageUrls' => 'imageUrls',
        'platform' => 'platform',
        'productName' => 'productName',
        'sellingPoints' => 'sellingPoints',
        'sourceData' => 'sourceData',
        'variants' => 'variants',
        'videoUrls' => 'videoUrls',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->imageUrls) {
            $res['imageUrls'] = $this->imageUrls;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->sellingPoints) {
            $res['sellingPoints'] = $this->sellingPoints;
        }
        if (null !== $this->sourceData) {
            $res['sourceData'] = $this->sourceData;
        }
        if (null !== $this->variants) {
            $res['variants'] = [];
            if (null !== $this->variants && \is_array($this->variants)) {
                $n = 0;
                foreach ($this->variants as $item) {
                    $res['variants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->videoUrls) {
            $res['videoUrls'] = $this->videoUrls;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LaunchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['imageUrls'])) {
            if (!empty($map['imageUrls'])) {
                $model->imageUrls = $map['imageUrls'];
            }
        }
        if (isset($map['platform'])) {
            if (!empty($map['platform'])) {
                $model->platform = $map['platform'];
            }
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['sellingPoints'])) {
            if (!empty($map['sellingPoints'])) {
                $model->sellingPoints = $map['sellingPoints'];
            }
        }
        if (isset($map['sourceData'])) {
            $model->sourceData = $map['sourceData'];
        }
        if (isset($map['variants'])) {
            if (!empty($map['variants'])) {
                $model->variants = [];
                $n = 0;
                foreach ($map['variants'] as $item) {
                    $model->variants[$n++] = null !== $item ? variants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['videoUrls'])) {
            if (!empty($map['videoUrls'])) {
                $model->videoUrls = $map['videoUrls'];
            }
        }

        return $model;
    }
}
