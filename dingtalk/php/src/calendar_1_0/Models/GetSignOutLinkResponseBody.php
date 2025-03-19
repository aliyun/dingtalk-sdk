<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSignOutLinkResponseBody extends Model
{
    /**
     * @var string
     */
    public $signOutLink;
    protected $_name = [
        'signOutLink' => 'signOutLink',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->signOutLink) {
            $res['signOutLink'] = $this->signOutLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignOutLinkResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signOutLink'])) {
            $model->signOutLink = $map['signOutLink'];
        }

        return $model;
    }
}
