<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGroupLiveListShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $requestBodyShrink;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'requestBodyShrink' => 'requestBody',
        'unionId'           => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestBodyShrink) {
            $res['requestBody'] = $this->requestBodyShrink;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupLiveListShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestBody'])) {
            $model->requestBodyShrink = $map['requestBody'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
