<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsResponseBody\data\finisher;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsResponseBody\data\participant;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsResponseBody\data\receiptor;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 活动编码
     *
     * @var string
     */
    public $activityCode;

    /**
     * @description 当前活动名称
     *
     * @var string
     */
    public $activityName;

    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appCode;

    /**
     * @description 工作项所关联的业务对象id
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description 对该工作项的意见
     *
     * @var string
     */
    public $comment;

    /**
     * @description 显示名称
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 完成时间
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @description 完成者
     *
     * @var finisher
     */
    public $finisher;

    /**
     * @description 对该工作项是否同意
     *
     * @var bool
     */
    public $isApproval;

    /**
     * @description 是否已完成
     *
     * @var bool
     */
    public $isFinish;

    /**
     * @description 参与者
     *
     * @var participant
     */
    public $participant;

    /**
     * @description 流程实例ID
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 工作流版本
     *
     * @var string
     */
    public $processVersion;

    /**
     * @description 转交工作的接收人。如无转接人，则为空
     *
     * @var receiptor
     */
    public $receiptor;

    /**
     * @description 接收时间
     *
     * @var string
     */
    public $receiveTimeGMT;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @description 开始这个任务的时间
     *
     * @var string
     */
    public $startTimeGMT;

    /**
     * @description 状态。Waiting=等待的状态，Working=正在工作中的状态，Finished=处于完成状态，Canceled=已经被取消，Forwarded=已转交状态，Revoked=撤回
     *
     * @var string
     */
    public $state;

    /**
     * @description 工作任务Id
     *
     * @var string
     */
    public $workItemId;

    /**
     * @description 工作项类型。Fill=普通工作项，Approve=审批类型工作项，Circulate=传阅
     *
     * @var string
     */
    public $workItemType;
    protected $_name = [
        'activityCode'      => 'activityCode',
        'activityName'      => 'activityName',
        'appCode'           => 'appCode',
        'bizObjectId'       => 'bizObjectId',
        'comment'           => 'comment',
        'displayName'       => 'displayName',
        'finishTimeGMT'     => 'finishTimeGMT',
        'finisher'          => 'finisher',
        'isApproval'        => 'isApproval',
        'isFinish'          => 'isFinish',
        'participant'       => 'participant',
        'processInstanceId' => 'processInstanceId',
        'processVersion'    => 'processVersion',
        'receiptor'         => 'receiptor',
        'receiveTimeGMT'    => 'receiveTimeGMT',
        'schemaCode'        => 'schemaCode',
        'startTimeGMT'      => 'startTimeGMT',
        'state'             => 'state',
        'workItemId'        => 'workItemId',
        'workItemType'      => 'workItemType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityCode) {
            $res['activityCode'] = $this->activityCode;
        }
        if (null !== $this->activityName) {
            $res['activityName'] = $this->activityName;
        }
        if (null !== $this->appCode) {
            $res['appCode'] = $this->appCode;
        }
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->comment) {
            $res['comment'] = $this->comment;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->finisher) {
            $res['finisher'] = null !== $this->finisher ? $this->finisher->toMap() : null;
        }
        if (null !== $this->isApproval) {
            $res['isApproval'] = $this->isApproval;
        }
        if (null !== $this->isFinish) {
            $res['isFinish'] = $this->isFinish;
        }
        if (null !== $this->participant) {
            $res['participant'] = null !== $this->participant ? $this->participant->toMap() : null;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->processVersion) {
            $res['processVersion'] = $this->processVersion;
        }
        if (null !== $this->receiptor) {
            $res['receiptor'] = null !== $this->receiptor ? $this->receiptor->toMap() : null;
        }
        if (null !== $this->receiveTimeGMT) {
            $res['receiveTimeGMT'] = $this->receiveTimeGMT;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->startTimeGMT) {
            $res['startTimeGMT'] = $this->startTimeGMT;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->workItemId) {
            $res['workItemId'] = $this->workItemId;
        }
        if (null !== $this->workItemType) {
            $res['workItemType'] = $this->workItemType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityCode'])) {
            $model->activityCode = $map['activityCode'];
        }
        if (isset($map['activityName'])) {
            $model->activityName = $map['activityName'];
        }
        if (isset($map['appCode'])) {
            $model->appCode = $map['appCode'];
        }
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['comment'])) {
            $model->comment = $map['comment'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['finisher'])) {
            $model->finisher = finisher::fromMap($map['finisher']);
        }
        if (isset($map['isApproval'])) {
            $model->isApproval = $map['isApproval'];
        }
        if (isset($map['isFinish'])) {
            $model->isFinish = $map['isFinish'];
        }
        if (isset($map['participant'])) {
            $model->participant = participant::fromMap($map['participant']);
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['processVersion'])) {
            $model->processVersion = $map['processVersion'];
        }
        if (isset($map['receiptor'])) {
            $model->receiptor = receiptor::fromMap($map['receiptor']);
        }
        if (isset($map['receiveTimeGMT'])) {
            $model->receiveTimeGMT = $map['receiveTimeGMT'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['startTimeGMT'])) {
            $model->startTimeGMT = $map['startTimeGMT'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['workItemId'])) {
            $model->workItemId = $map['workItemId'];
        }
        if (isset($map['workItemType'])) {
            $model->workItemType = $map['workItemType'];
        }

        return $model;
    }
}
