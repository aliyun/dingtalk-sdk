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
     * @example Activity1
     *
     * @var string
     */
    public $activityCode;

    /**
     * @example 发起流程
     *
     * @var string
     */
    public $activityName;

    /**
     * @example D000001
     *
     * @var string
     */
    public $appCode;

    /**
     * @example 106f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @example 同意
     *
     * @var string
     */
    public $comment;

    /**
     * @example 发起流程
     *
     * @var string
     */
    public $displayName;

    /**
     * @example null
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var finisher
     */
    public $finisher;

    /**
     * @example true
     *
     * @var bool
     */
    public $isApproval;

    /**
     * @example false
     *
     * @var bool
     */
    public $isFinish;

    /**
     * @var participant
     */
    public $participant;

    /**
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 3
     *
     * @var string
     */
    public $processVersion;

    /**
     * @var receiptor
     */
    public $receiptor;

    /**
     * @example 2021-11-19 19:36:54
     *
     * @var string
     */
    public $receiveTimeGMT;

    /**
     * @example D0001833abb0fb61524487eb01848207bc89b47
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @example 2021-11-19 19:36:54
     *
     * @var string
     */
    public $startTimeGMT;

    /**
     * @example Waiting
     *
     * @var string
     */
    public $state;

    /**
     * @example 3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713
     *
     * @var string
     */
    public $workItemId;

    /**
     * @example Fill
     *
     * @var string
     */
    public $workItemType;
    protected $_name = [
        'activityCode' => 'activityCode',
        'activityName' => 'activityName',
        'appCode' => 'appCode',
        'bizObjectId' => 'bizObjectId',
        'comment' => 'comment',
        'displayName' => 'displayName',
        'finishTimeGMT' => 'finishTimeGMT',
        'finisher' => 'finisher',
        'isApproval' => 'isApproval',
        'isFinish' => 'isFinish',
        'participant' => 'participant',
        'processInstanceId' => 'processInstanceId',
        'processVersion' => 'processVersion',
        'receiptor' => 'receiptor',
        'receiveTimeGMT' => 'receiveTimeGMT',
        'schemaCode' => 'schemaCode',
        'startTimeGMT' => 'startTimeGMT',
        'state' => 'state',
        'workItemId' => 'workItemId',
        'workItemType' => 'workItemType',
    ];

    public function validate() {}

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
