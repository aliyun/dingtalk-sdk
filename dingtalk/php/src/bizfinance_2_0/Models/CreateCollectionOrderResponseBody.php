<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateCollectionOrderResponseBody extends Model
{
    /**
     * @var string
     */
    public $collectionUrl;
    protected $_name = [
        'collectionUrl' => 'collectionUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->collectionUrl) {
            $res['collectionUrl'] = $this->collectionUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateCollectionOrderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['collectionUrl'])) {
            $model->collectionUrl = $map['collectionUrl'];
        }

        return $model;
    }
}
