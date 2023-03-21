<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListApproveByUsersRequest extends Model
{
    /**
     * @description 传入需要查询的审批单类型：
     * ● 5：外勤审批
     * @var int[]
     */
    public $bizTypes;

    /**
     * @description 起始日期，Unix时间戳，单位毫秒。（不支持180天前）
     *
     * @var int
     */
    public $fromDateTime;

    /**
     * @description 结束日期，Unix时间戳，单位毫秒。（不支持180天前，开始和结束不能超过30天）
     *
     * @var int
     */
    public $toDateTime;

    /**
     * @description 要查询的人员userId列表，多个userId用逗号分隔，一次最多可传50个
     *
     * @var string
     */
    public $userIds;
    protected $_name = [
        'bizTypes'     => 'bizTypes',
        'fromDateTime' => 'fromDateTime',
        'toDateTime'   => 'toDateTime',
        'userIds'      => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTypes) {
            $res['bizTypes'] = $this->bizTypes;
        }
        if (null !== $this->fromDateTime) {
            $res['fromDateTime'] = $this->fromDateTime;
        }
        if (null !== $this->toDateTime) {
            $res['toDateTime'] = $this->toDateTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListApproveByUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTypes'])) {
            if (!empty($map['bizTypes'])) {
                $model->bizTypes = $map['bizTypes'];
            }
        }
        if (isset($map['fromDateTime'])) {
            $model->fromDateTime = $map['fromDateTime'];
        }
        if (isset($map['toDateTime'])) {
            $model->toDateTime = $map['toDateTime'];
        }
        if (isset($map['userIds'])) {
            $model->userIds = $map['userIds'];
        }

        return $model;
    }
}
