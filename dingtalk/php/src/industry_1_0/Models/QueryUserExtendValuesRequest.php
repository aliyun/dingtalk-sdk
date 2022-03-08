<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserExtendValuesRequest extends Model
{
    /**
     * @description 用户拓展key
     *
     * @var string
     */
    public $userExtendKey;

    /**
     * @description userId列表
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'userExtendKey' => 'userExtendKey',
        'userIds'       => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userExtendKey) {
            $res['userExtendKey'] = $this->userExtendKey;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserExtendValuesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userExtendKey'])) {
            $model->userExtendKey = $map['userExtendKey'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
