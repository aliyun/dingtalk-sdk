<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddShareCidListRequest extends Model
{
    /**
     * @description 传入的群id类型（1 chatId / 2 openConversationId ）
     *
     * @var int
     */
    public $groupIdType;

    /**
     * @description 添加的联播群列表
     *
     * @var string[]
     */
    public $groupIds;

    /**
     * @description 操作的的组织内id(staffId)
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'groupIdType' => 'groupIdType',
        'groupIds'    => 'groupIds',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupIdType) {
            $res['groupIdType'] = $this->groupIdType;
        }
        if (null !== $this->groupIds) {
            $res['groupIds'] = $this->groupIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddShareCidListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupIdType'])) {
            $model->groupIdType = $map['groupIdType'];
        }
        if (isset($map['groupIds'])) {
            if (!empty($map['groupIds'])) {
                $model->groupIds = $map['groupIds'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
