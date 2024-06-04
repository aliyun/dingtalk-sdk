<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList;

use AlibabaCloud\Tea\Model;

class media extends Model
{
    /**
     * @example image
     *
     * @var string
     */
    public $mediaType;

    /**
     * @example https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/banner/进销存封面.png
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'mediaType' => 'mediaType',
        'url'       => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaType) {
            $res['mediaType'] = $this->mediaType;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return media
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaType'])) {
            $model->mediaType = $map['mediaType'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
