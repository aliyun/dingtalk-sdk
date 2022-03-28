<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponseBody\result\deptList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 离职部门列表
     *
     * @var deptList[]
     */
    public $deptList;

    /**
     * @description 离职交接人
     *
     * @var string
     */
    public $handoverUserId;

    /**
     * @description 最后工作日
     *
     * @var int
     */
    public $lastWorkDay;

    /**
     * @description 离职前主部门id
     *
     * @var int
     */
    public $mainDeptId;

    /**
     * @description 离职前主部门名称
     *
     * @var string
     */
    public $mainDeptName;

    /**
     * @description 离职原因-被动
     *
     * @var string[]
     */
    public $passiveReason;

    /**
     * @description 离职前工作状态：1，待入职；2，试用期；3，正式
     *
     * @var int
     */
    public $preStatus;

    /**
     * @description 离职原因备注
     *
     * @var string
     */
    public $reasonMemo;

    /**
     * @description 离职状态：1，待离职；2，已离职
     *
     * @var int
     */
    public $status;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 离职原因-主动
     *
     * @var string[]
     */
    public $voluntaryReason;
    protected $_name = [
        'deptList'        => 'deptList',
        'handoverUserId'  => 'handoverUserId',
        'lastWorkDay'     => 'lastWorkDay',
        'mainDeptId'      => 'mainDeptId',
        'mainDeptName'    => 'mainDeptName',
        'passiveReason'   => 'passiveReason',
        'preStatus'       => 'preStatus',
        'reasonMemo'      => 'reasonMemo',
        'status'          => 'status',
        'userId'          => 'userId',
        'voluntaryReason' => 'voluntaryReason',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptList) {
            $res['deptList'] = [];
            if (null !== $this->deptList && \is_array($this->deptList)) {
                $n = 0;
                foreach ($this->deptList as $item) {
                    $res['deptList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->handoverUserId) {
            $res['handoverUserId'] = $this->handoverUserId;
        }
        if (null !== $this->lastWorkDay) {
            $res['lastWorkDay'] = $this->lastWorkDay;
        }
        if (null !== $this->mainDeptId) {
            $res['mainDeptId'] = $this->mainDeptId;
        }
        if (null !== $this->mainDeptName) {
            $res['mainDeptName'] = $this->mainDeptName;
        }
        if (null !== $this->passiveReason) {
            $res['passiveReason'] = $this->passiveReason;
        }
        if (null !== $this->preStatus) {
            $res['preStatus'] = $this->preStatus;
        }
        if (null !== $this->reasonMemo) {
            $res['reasonMemo'] = $this->reasonMemo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->voluntaryReason) {
            $res['voluntaryReason'] = $this->voluntaryReason;
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
        if (isset($map['deptList'])) {
            if (!empty($map['deptList'])) {
                $model->deptList = [];
                $n               = 0;
                foreach ($map['deptList'] as $item) {
                    $model->deptList[$n++] = null !== $item ? deptList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['handoverUserId'])) {
            $model->handoverUserId = $map['handoverUserId'];
        }
        if (isset($map['lastWorkDay'])) {
            $model->lastWorkDay = $map['lastWorkDay'];
        }
        if (isset($map['mainDeptId'])) {
            $model->mainDeptId = $map['mainDeptId'];
        }
        if (isset($map['mainDeptName'])) {
            $model->mainDeptName = $map['mainDeptName'];
        }
        if (isset($map['passiveReason'])) {
            if (!empty($map['passiveReason'])) {
                $model->passiveReason = $map['passiveReason'];
            }
        }
        if (isset($map['preStatus'])) {
            $model->preStatus = $map['preStatus'];
        }
        if (isset($map['reasonMemo'])) {
            $model->reasonMemo = $map['reasonMemo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['voluntaryReason'])) {
            if (!empty($map['voluntaryReason'])) {
                $model->voluntaryReason = $map['voluntaryReason'];
            }
        }

        return $model;
    }
}
