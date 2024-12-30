<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryVipMemberInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $expireTime;

    /**
     * @var bool
     */
    public $isVip;
    protected $_name = [
        'expireTime' => 'expireTime',
        'isVip'      => 'isVip',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->isVip) {
            $res['isVip'] = $this->isVip;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryVipMemberInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['isVip'])) {
            $model->isVip = $map['isVip'];
        }

        return $model;
    }
}
