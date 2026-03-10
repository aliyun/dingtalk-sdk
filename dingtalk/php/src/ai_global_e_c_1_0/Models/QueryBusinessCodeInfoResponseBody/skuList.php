<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\QueryBusinessCodeInfoResponseBody;

use AlibabaCloud\Tea\Model;

class skuList extends Model
{
    /**
     * @var string
     */
    public $imageUrl;

    /**
     * @var string
     */
    public $skuId;
    protected $_name = [
        'imageUrl' => 'imageUrl',
        'skuId' => 'skuId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->imageUrl) {
            $res['imageUrl'] = $this->imageUrl;
        }
        if (null !== $this->skuId) {
            $res['skuId'] = $this->skuId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return skuList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['imageUrl'])) {
            $model->imageUrl = $map['imageUrl'];
        }
        if (isset($map['skuId'])) {
            $model->skuId = $map['skuId'];
        }

        return $model;
    }
}
