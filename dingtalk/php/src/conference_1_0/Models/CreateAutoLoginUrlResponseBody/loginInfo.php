<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateAutoLoginUrlResponseBody;

use AlibabaCloud\Tea\Model;

class loginInfo extends Model
{
    /**
     * @var string
     */
    public $loginUrl;
    protected $_name = [
        'loginUrl' => 'loginUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->loginUrl) {
            $res['loginUrl'] = $this->loginUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return loginInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['loginUrl'])) {
            $model->loginUrl = $map['loginUrl'];
        }

        return $model;
    }
}
