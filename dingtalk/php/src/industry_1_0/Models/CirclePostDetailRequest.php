<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CirclePostDetailRequest extends Model
{
    /**
     * @var int
     */
    public $postId;
    protected $_name = [
        'postId' => 'postId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->postId) {
            $res['postId'] = $this->postId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CirclePostDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['postId'])) {
            $model->postId = $map['postId'];
        }

        return $model;
    }
}
