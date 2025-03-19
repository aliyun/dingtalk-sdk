<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSignInLinkResponseBody extends Model
{
    /**
     * @var string
     */
    public $signInLink;
    protected $_name = [
        'signInLink' => 'signInLink',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->signInLink) {
            $res['signInLink'] = $this->signInLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSignInLinkResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['signInLink'])) {
            $model->signInLink = $map['signInLink'];
        }

        return $model;
    }
}
