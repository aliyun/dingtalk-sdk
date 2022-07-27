<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListBasicRoleInPageResponseBody\list_\openAction\openCondition;

use AlibabaCloud\Tea\Model;

class openContactScope extends Model
{
    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @var bool
     */
    public $includeMemberDepts;

    /**
     * @var bool
     */
    public $includeSelfManageDepts;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'deptIds'                => 'deptIds',
        'includeMemberDepts'     => 'includeMemberDepts',
        'includeSelfManageDepts' => 'includeSelfManageDepts',
        'userIds'                => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->includeMemberDepts) {
            $res['includeMemberDepts'] = $this->includeMemberDepts;
        }
        if (null !== $this->includeSelfManageDepts) {
            $res['includeSelfManageDepts'] = $this->includeSelfManageDepts;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openContactScope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['includeMemberDepts'])) {
            $model->includeMemberDepts = $map['includeMemberDepts'];
        }
        if (isset($map['includeSelfManageDepts'])) {
            $model->includeSelfManageDepts = $map['includeSelfManageDepts'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
