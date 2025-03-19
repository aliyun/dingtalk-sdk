<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryHrmEmployeeDismissionInfoResponseBody\result\deptList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deptList[]
     */
    public $deptList;

    /**
     * @var string
     */
    public $handoverUserId;

    /**
     * @var int
     */
    public $lastWorkDay;

    /**
     * @var int
     */
    public $mainDeptId;

    /**
     * @var string
     */
    public $mainDeptName;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $passiveReason;

    /**
     * @var int
     */
    public $preStatus;

    /**
     * @var string
     */
    public $reasonMemo;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string[]
     */
    public $voluntaryReason;
    protected $_name = [
        'deptList' => 'deptList',
        'handoverUserId' => 'handoverUserId',
        'lastWorkDay' => 'lastWorkDay',
        'mainDeptId' => 'mainDeptId',
        'mainDeptName' => 'mainDeptName',
        'name' => 'name',
        'passiveReason' => 'passiveReason',
        'preStatus' => 'preStatus',
        'reasonMemo' => 'reasonMemo',
        'status' => 'status',
        'userId' => 'userId',
        'voluntaryReason' => 'voluntaryReason',
    ];

    public function validate() {}

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
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
                $n = 0;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
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
