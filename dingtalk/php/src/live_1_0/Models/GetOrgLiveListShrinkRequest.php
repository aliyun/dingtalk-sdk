<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrgLiveListShrinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $requestBodyShrink;
    protected $_name = [
        'corpId' => 'corpId',
        'requestBodyShrink' => 'requestBody',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->requestBodyShrink) {
            $res['requestBody'] = $this->requestBodyShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrgLiveListShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['requestBody'])) {
            $model->requestBodyShrink = $map['requestBody'];
        }

        return $model;
    }
}
