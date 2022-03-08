<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListEmpLeaveRecordsResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description 离职原因(oapi-开放平台删除，cancel-注销，leave-主动离职，unknown-未知原因，delete-管理员删除）
     *
     * @var string
     */
    public $leaveReason;

    /**
     * @description 离职时间
     *
     * @var string
     */
    public $leaveTime;

    /**
     * @description 手机号码
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 员工名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 国际电话区号
     *
     * @var string
     */
    public $stateCode;

    /**
     * @description 员工userid
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'leaveReason' => 'leaveReason',
        'leaveTime'   => 'leaveTime',
        'mobile'      => 'mobile',
        'name'        => 'name',
        'stateCode'   => 'stateCode',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveReason) {
            $res['leaveReason'] = $this->leaveReason;
        }
        if (null !== $this->leaveTime) {
            $res['leaveTime'] = $this->leaveTime;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveReason'])) {
            $model->leaveReason = $map['leaveReason'];
        }
        if (isset($map['leaveTime'])) {
            $model->leaveTime = $map['leaveTime'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
