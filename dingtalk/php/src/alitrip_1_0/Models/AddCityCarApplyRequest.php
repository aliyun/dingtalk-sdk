<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCityCarApplyRequest extends Model
{
    /**
     * @description 出差事由
     *
     * @var string
     */
    public $cause;

    /**
     * @description 用车城市
     *
     * @var string
     */
    public $city;

    /**
     * @description 第三方企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 用车时间，按天管控，比如传值2021-03-18 20:26:56表示2021-03-18当天可用车，跨天情况配合finishedDate参数使用
     *
     * @var string
     */
    public $date;

    /**
     * @description 用车截止时间，按天管控，比如date传值2021-03-18 20:26:56、finished_date传值2021-03-30 20:26:56表示2021-03-18(含)到2021-03-30(含)之间可用车，该参数不传值情况使用date作为用车截止时间；
     *
     * @var string
     */
    public $finishedDate;

    /**
     * @description 审批单关联的项目code
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 审批单关联的项目名
     *
     * @var string
     */
    public $projectName;

    /**
     * @description 审批单状态：0-申请，1-同意，2-拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 三方审批单ID
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description 审批单关联的三方成本中心ID
     *
     * @var string
     */
    public $thirdPartCostCenterId;

    /**
     * @description 审批单关联的三方发票抬头ID
     *
     * @var string
     */
    public $thirdPartInvoiceId;

    /**
     * @description 审批单可用总次数
     *
     * @var int
     */
    public $timesTotal;

    /**
     * @description 审批单可用次数类型：1-次数不限制，2-用户可指定次数，3-管理员限制次数；如果企业没有限制审批单使用次数的需求，这个参数传1(次数不限制)，同时times_total和times_used都传0即可
     *
     * @var int
     */
    public $timesType;

    /**
     * @description 审批单已用次数
     *
     * @var int
     */
    public $timesUsed;

    /**
     * @description 审批单标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 发起审批的第三方员工ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cause'                 => 'cause',
        'city'                  => 'city',
        'corpId'                => 'corpId',
        'date'                  => 'date',
        'finishedDate'          => 'finishedDate',
        'projectCode'           => 'projectCode',
        'projectName'           => 'projectName',
        'status'                => 'status',
        'thirdPartApplyId'      => 'thirdPartApplyId',
        'thirdPartCostCenterId' => 'thirdPartCostCenterId',
        'thirdPartInvoiceId'    => 'thirdPartInvoiceId',
        'timesTotal'            => 'timesTotal',
        'timesType'             => 'timesType',
        'timesUsed'             => 'timesUsed',
        'title'                 => 'title',
        'userId'                => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cause) {
            $res['cause'] = $this->cause;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->finishedDate) {
            $res['finishedDate'] = $this->finishedDate;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->thirdPartCostCenterId) {
            $res['thirdPartCostCenterId'] = $this->thirdPartCostCenterId;
        }
        if (null !== $this->thirdPartInvoiceId) {
            $res['thirdPartInvoiceId'] = $this->thirdPartInvoiceId;
        }
        if (null !== $this->timesTotal) {
            $res['timesTotal'] = $this->timesTotal;
        }
        if (null !== $this->timesType) {
            $res['timesType'] = $this->timesType;
        }
        if (null !== $this->timesUsed) {
            $res['timesUsed'] = $this->timesUsed;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCityCarApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cause'])) {
            $model->cause = $map['cause'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['finishedDate'])) {
            $model->finishedDate = $map['finishedDate'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['thirdPartCostCenterId'])) {
            $model->thirdPartCostCenterId = $map['thirdPartCostCenterId'];
        }
        if (isset($map['thirdPartInvoiceId'])) {
            $model->thirdPartInvoiceId = $map['thirdPartInvoiceId'];
        }
        if (isset($map['timesTotal'])) {
            $model->timesTotal = $map['timesTotal'];
        }
        if (isset($map['timesType'])) {
            $model->timesType = $map['timesType'];
        }
        if (isset($map['timesUsed'])) {
            $model->timesUsed = $map['timesUsed'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
