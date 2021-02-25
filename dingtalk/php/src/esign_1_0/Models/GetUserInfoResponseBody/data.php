<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUserInfoResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var bool
     */
    public $realName;

    /**
     * @var string
     */
    public $userRealName;
    protected $_name = [
        'realName'     => 'realName',
        'userRealName' => 'userRealName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->realName) {
            $res['realName'] = $this->realName;
        }
        if (null !== $this->userRealName) {
            $res['userRealName'] = $this->userRealName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['realName'])) {
            $model->realName = $map['realName'];
        }
        if (isset($map['userRealName'])) {
            $model->userRealName = $map['userRealName'];
        }

        return $model;
    }
}
