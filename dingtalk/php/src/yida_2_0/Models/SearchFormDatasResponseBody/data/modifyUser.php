<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDatasResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDatasResponseBody\data\modifyUser\userName;
use AlibabaCloud\Tea\Model;

class modifyUser extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var userName
     */
    public $userName;
    protected $_name = [
        'userId'   => 'userId',
        'userName' => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = null !== $this->userName ? $this->userName->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return modifyUser
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = userName::fromMap($map['userName']);
        }

        return $model;
    }
}
