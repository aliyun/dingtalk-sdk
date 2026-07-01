<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupAdminResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomGroupAdminResponseBody\result\groupAdmins;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var groupAdmins[]
     */
    public $groupAdmins;

    /**
     * @example 172
     *
     * @var int
     */
    public $groupId;

    /**
     * @var string
     */
    public $groupName;
    protected $_name = [
        'groupAdmins' => 'groupAdmins',
        'groupId' => 'groupId',
        'groupName' => 'groupName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupAdmins) {
            $res['groupAdmins'] = [];
            if (null !== $this->groupAdmins && \is_array($this->groupAdmins)) {
                $n = 0;
                foreach ($this->groupAdmins as $item) {
                    $res['groupAdmins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupAdmins'])) {
            if (!empty($map['groupAdmins'])) {
                $model->groupAdmins = [];
                $n = 0;
                foreach ($map['groupAdmins'] as $item) {
                    $model->groupAdmins[$n++] = null !== $item ? groupAdmins::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}
