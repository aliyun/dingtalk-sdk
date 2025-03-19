<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryVipMemberInfoRequest extends Model
{
    /**
     * @var string
     */
    public $channelCode;
    protected $_name = [
        'channelCode' => 'channelCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryVipMemberInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }

        return $model;
    }
}
