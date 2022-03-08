<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\GetDingPortalDetailResponseBody;

use AlibabaCloud\Tea\Model;

class pages extends Model
{
    /**
     * @description 是否全公司可见
     *
     * @var bool
     */
    public $allVisible;

    /**
     * @description 可见部门 ID 铺
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @description 页面名称
     *
     * @var string
     */
    public $pageName;

    /**
     * @description 页面ID
     *
     * @var string
     */
    public $pageUuid;

    /**
     * @description 可见角色列表
     *
     * @var int[]
     */
    public $roleIds;

    /**
     * @description 可见员工 ID 列表
     *
     * @var string[]
     */
    public $userids;
    protected $_name = [
        'allVisible' => 'allVisible',
        'deptIds'    => 'deptIds',
        'pageName'   => 'pageName',
        'pageUuid'   => 'pageUuid',
        'roleIds'    => 'roleIds',
        'userids'    => 'userids',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allVisible) {
            $res['allVisible'] = $this->allVisible;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->pageName) {
            $res['pageName'] = $this->pageName;
        }
        if (null !== $this->pageUuid) {
            $res['pageUuid'] = $this->pageUuid;
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->userids) {
            $res['userids'] = $this->userids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pages
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allVisible'])) {
            $model->allVisible = $map['allVisible'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['pageName'])) {
            $model->pageName = $map['pageName'];
        }
        if (isset($map['pageUuid'])) {
            $model->pageUuid = $map['pageUuid'];
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['userids'])) {
            if (!empty($map['userids'])) {
                $model->userids = $map['userids'];
            }
        }

        return $model;
    }
}
