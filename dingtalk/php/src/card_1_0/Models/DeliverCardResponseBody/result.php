<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example cid1234abcd
     *
     * @var string
     */
    public $spaceId;

    /**
     * @example IM_GROUP
     *
     * @var string
     */
    public $spaceType;

    /**
     * @var bool
     */
    public $success;
    protected $_name = [
        'spaceId'   => 'spaceId',
        'spaceType' => 'spaceType',
        'success'   => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
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
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
