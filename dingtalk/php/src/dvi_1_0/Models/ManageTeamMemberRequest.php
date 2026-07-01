<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberRequest\addMembers;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\ManageTeamMemberRequest\removeMembers;
use AlibabaCloud\Tea\Model;

class ManageTeamMemberRequest extends Model
{
    /**
     * @var addMembers
     */
    public $addMembers;

    /**
     * @var removeMembers
     */
    public $removeMembers;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $teamCode;
    protected $_name = [
        'addMembers' => 'addMembers',
        'removeMembers' => 'removeMembers',
        'teamCode' => 'teamCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->addMembers) {
            $res['addMembers'] = null !== $this->addMembers ? $this->addMembers->toMap() : null;
        }
        if (null !== $this->removeMembers) {
            $res['removeMembers'] = null !== $this->removeMembers ? $this->removeMembers->toMap() : null;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManageTeamMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['addMembers'])) {
            $model->addMembers = addMembers::fromMap($map['addMembers']);
        }
        if (isset($map['removeMembers'])) {
            $model->removeMembers = removeMembers::fromMap($map['removeMembers']);
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }

        return $model;
    }
}
