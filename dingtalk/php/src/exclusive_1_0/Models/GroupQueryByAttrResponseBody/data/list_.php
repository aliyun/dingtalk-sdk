<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GroupQueryByAttrResponseBody\data;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $groupMemberCount;

    /**
     * @var string
     */
    public $groupName;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $ownerJobNo;

    /**
     * @var string
     */
    public $ownerUserName;
    protected $_name = [
        'groupMemberCount' => 'groupMemberCount',
        'groupName' => 'groupName',
        'openConversationId' => 'openConversationId',
        'ownerJobNo' => 'ownerJobNo',
        'ownerUserName' => 'ownerUserName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMemberCount) {
            $res['groupMemberCount'] = $this->groupMemberCount;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->ownerJobNo) {
            $res['ownerJobNo'] = $this->ownerJobNo;
        }
        if (null !== $this->ownerUserName) {
            $res['ownerUserName'] = $this->ownerUserName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMemberCount'])) {
            $model->groupMemberCount = $map['groupMemberCount'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['ownerJobNo'])) {
            $model->ownerJobNo = $map['ownerJobNo'];
        }
        if (isset($map['ownerUserName'])) {
            $model->ownerUserName = $map['ownerUserName'];
        }

        return $model;
    }
}
