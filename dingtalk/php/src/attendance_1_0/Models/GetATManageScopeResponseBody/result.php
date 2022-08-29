<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetATManageScopeResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否有更多数据。  true：有  false：没有
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 可见范围。boss/主管理员/管理范围包含根部门的管理员：all ，管理员/考勤组负责人：partial，无权限：none
     *
     * @var string
     */
    public $manageScope;

    /**
     * @description 员工userid。只有manageScope为partial返回数据。
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'hasMore'     => 'hasMore',
        'manageScope' => 'manageScope',
        'userIds'     => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->manageScope) {
            $res['manageScope'] = $this->manageScope;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['manageScope'])) {
            $model->manageScope = $map['manageScope'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
