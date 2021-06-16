<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCooperateOrgInviteInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $inviteUrl;
    protected $_name = [
        'inviteUrl' => 'inviteUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inviteUrl) {
            $res['inviteUrl'] = $this->inviteUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCooperateOrgInviteInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inviteUrl'])) {
            $model->inviteUrl = $map['inviteUrl'];
        }

        return $model;
    }
}
