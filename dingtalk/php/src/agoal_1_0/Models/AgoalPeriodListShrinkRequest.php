<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalPeriodListShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $bodyShrink;
    protected $_name = [
        'bodyShrink' => 'body',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bodyShrink) {
            $res['body'] = $this->bodyShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalPeriodListShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->bodyShrink = $map['body'];
        }

        return $model;
    }
}
