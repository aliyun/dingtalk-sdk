<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmsg_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeletePlguinRuleRequest extends Model
{
    /**
     * @var string[]
     */
    public $bizIdList;

    /**
     * @example 0847493113802787
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizIdList' => 'bizIdList',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizIdList) {
            $res['bizIdList'] = $this->bizIdList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeletePlguinRuleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizIdList'])) {
            if (!empty($map['bizIdList'])) {
                $model->bizIdList = $map['bizIdList'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
