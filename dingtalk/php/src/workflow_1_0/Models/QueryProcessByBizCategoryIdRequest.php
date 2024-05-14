<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryProcessByBizCategoryIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example abc
     *
     * @var string
     */
    public $bizType;

    /**
     * @example manager123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizType' => 'bizType',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryProcessByBizCategoryIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
