<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ListApproveByUsersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 审批单自定义id
     *
     * @var string
     */
    public $approveId;

    /**
     * @description 审批单开始时间原始格式
     *
     * @var string
     */
    public $beginTime;

    /**
     * @description 审批单类型：
     * ● 5：外勤审批
     * @var int
     */
    public $bizType;

    /**
     * @description 计算方法：
     * ● 1：按工作日计算
     * @var int
     */
    public $calculateModel;

    /**
     * @description 时长单位，支持格式如下：
     * ● 2019-08-15 12:43对应hour
     * @var string
     */
    public $durationUnit;

    /**
     * @description 审批单结束时间原始格式
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 子类型名称，最大长度20个字符
     *
     * @var string
     */
    public $subType;

    /**
     * @description 审批单类型名称，最大长度20个字符
     *
     * @var string
     */
    public $tagName;

    /**
     * @description 用户userid
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'approveId'      => 'approveId',
        'beginTime'      => 'beginTime',
        'bizType'        => 'bizType',
        'calculateModel' => 'calculateModel',
        'durationUnit'   => 'durationUnit',
        'endTime'        => 'endTime',
        'subType'        => 'subType',
        'tagName'        => 'tagName',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveId) {
            $res['approveId'] = $this->approveId;
        }
        if (null !== $this->beginTime) {
            $res['beginTime'] = $this->beginTime;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->calculateModel) {
            $res['calculateModel'] = $this->calculateModel;
        }
        if (null !== $this->durationUnit) {
            $res['durationUnit'] = $this->durationUnit;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['approveId'])) {
            $model->approveId = $map['approveId'];
        }
        if (isset($map['beginTime'])) {
            $model->beginTime = $map['beginTime'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['calculateModel'])) {
            $model->calculateModel = $map['calculateModel'];
        }
        if (isset($map['durationUnit'])) {
            $model->durationUnit = $map['durationUnit'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
