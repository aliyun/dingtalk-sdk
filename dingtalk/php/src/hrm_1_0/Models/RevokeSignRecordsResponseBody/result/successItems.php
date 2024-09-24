<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RevokeSignRecordsResponseBody\result;

use AlibabaCloud\Tea\Model;

class successItems extends Model
{
    /**
     * @example 6fe06f57ab5a45078f3219be8fd829c6
     *
     * @var string
     */
    public $itemId;
    protected $_name = [
        'itemId' => 'itemId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->itemId) {
            $res['itemId'] = $this->itemId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return successItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['itemId'])) {
            $model->itemId = $map['itemId'];
        }

        return $model;
    }
}
