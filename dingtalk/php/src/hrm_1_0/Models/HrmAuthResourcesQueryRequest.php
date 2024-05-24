<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmAuthResourcesQueryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $authResourceIds;

    /**
     * @description This parameter is required.
     *
     * @example 1231
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'authResourceIds' => 'authResourceIds',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authResourceIds) {
            $res['authResourceIds'] = $this->authResourceIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmAuthResourcesQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authResourceIds'])) {
            if (!empty($map['authResourceIds'])) {
                $model->authResourceIds = $map['authResourceIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
