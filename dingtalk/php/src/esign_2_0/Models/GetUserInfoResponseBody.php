<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserInfoResponseBody extends Model
{
    /**
     * @var string
     */
    public $isRealName;

    /**
     * @var string
     */
    public $userRealName;
    protected $_name = [
        'isRealName'   => 'isRealName',
        'userRealName' => 'userRealName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isRealName) {
            $res['isRealName'] = $this->isRealName;
        }
        if (null !== $this->userRealName) {
            $res['userRealName'] = $this->userRealName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isRealName'])) {
            $model->isRealName = $map['isRealName'];
        }
        if (isset($map['userRealName'])) {
            $model->userRealName = $map['userRealName'];
        }

        return $model;
    }
}
