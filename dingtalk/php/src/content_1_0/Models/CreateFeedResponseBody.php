<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFeedResponseBody extends Model
{
    /**
     * @example c497****-8a89-****-bc9b-*****48610d3
     *
     * @var string
     */
    public $feedId;
    protected $_name = [
        'feedId' => 'feedId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFeedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }

        return $model;
    }
}
