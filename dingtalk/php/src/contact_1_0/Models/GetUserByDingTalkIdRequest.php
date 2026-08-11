<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserByDingTalkIdRequest extends Model
{
    /**
     * @var string
     */
    public $dingtalkId;
    protected $_name = [
        'dingtalkId' => 'dingtalkId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingtalkId) {
            $res['dingtalkId'] = $this->dingtalkId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserByDingTalkIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingtalkId'])) {
            $model->dingtalkId = $map['dingtalkId'];
        }

        return $model;
    }
}
