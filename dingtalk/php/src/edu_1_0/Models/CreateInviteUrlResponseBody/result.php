<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateInviteUrlResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
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
     * @return result
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
