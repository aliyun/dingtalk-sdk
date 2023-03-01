<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBlackboardSpaceResponseBody extends Model
{
    /**
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'spaceId' => 'spaceId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBlackboardSpaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
