<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetCorpTasksResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description originatorNickName
     *
     * @var string
     */
    public $originatorNickName;

    /**
     * @description processInstanceId
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description originatorName
     *
     * @var string
     */
    public $originatorName;

    /**
     * @description finishTime
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @description activeTime
     *
     * @var string
     */
    public $activeTimeGMT;

    /**
     * @description actualActionerId
     *
     * @var string
     */
    public $actualActionerId;

    /**
     * @description originatorEmail
     *
     * @var string
     */
    public $originatorEmail;

    /**
     * @description title
     *
     * @var string
     */
    public $title;

    /**
     * @description outResultName
     *
     * @var string
     */
    public $outResultName;

    /**
     * @description outResult
     *
     * @var string
     */
    public $outResult;

    /**
     * @description originatorPhoto
     *
     * @var string
     */
    public $originatorPhoto;

    /**
     * @description taskType
     *
     * @var string
     */
    public $taskType;

    /**
     * @description originatorNickNameEn
     *
     * @var string
     */
    public $originatorNickNameEn;

    /**
     * @description createTime
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @description titleEn
     *
     * @var string
     */
    public $titleInEnglish;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description originatorNameEn
     *
     * @var string
     */
    public $originatorNameInEnglish;

    /**
     * @description originatorId
     *
     * @var string
     */
    public $originatorId;

    /**
     * @description taskId
     *
     * @var string
     */
    public $taskId;

    /**
     * @description status
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'originatorNickName'      => 'originatorNickName',
        'processInstanceId'       => 'processInstanceId',
        'originatorName'          => 'originatorName',
        'finishTimeGMT'           => 'finishTimeGMT',
        'activeTimeGMT'           => 'activeTimeGMT',
        'actualActionerId'        => 'actualActionerId',
        'originatorEmail'         => 'originatorEmail',
        'title'                   => 'title',
        'outResultName'           => 'outResultName',
        'outResult'               => 'outResult',
        'originatorPhoto'         => 'originatorPhoto',
        'taskType'                => 'taskType',
        'originatorNickNameEn'    => 'originatorNickNameEn',
        'createTimeGMT'           => 'createTimeGMT',
        'titleInEnglish'          => 'titleInEnglish',
        'appType'                 => 'appType',
        'originatorNameInEnglish' => 'originatorNameInEnglish',
        'originatorId'            => 'originatorId',
        'taskId'                  => 'taskId',
        'status'                  => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->originatorNickName) {
            $res['originatorNickName'] = $this->originatorNickName;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->originatorName) {
            $res['originatorName'] = $this->originatorName;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->activeTimeGMT) {
            $res['activeTimeGMT'] = $this->activeTimeGMT;
        }
        if (null !== $this->actualActionerId) {
            $res['actualActionerId'] = $this->actualActionerId;
        }
        if (null !== $this->originatorEmail) {
            $res['originatorEmail'] = $this->originatorEmail;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->outResultName) {
            $res['outResultName'] = $this->outResultName;
        }
        if (null !== $this->outResult) {
            $res['outResult'] = $this->outResult;
        }
        if (null !== $this->originatorPhoto) {
            $res['originatorPhoto'] = $this->originatorPhoto;
        }
        if (null !== $this->taskType) {
            $res['taskType'] = $this->taskType;
        }
        if (null !== $this->originatorNickNameEn) {
            $res['originatorNickNameEn'] = $this->originatorNickNameEn;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->titleInEnglish) {
            $res['titleInEnglish'] = $this->titleInEnglish;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->originatorNameInEnglish) {
            $res['originatorNameInEnglish'] = $this->originatorNameInEnglish;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['originatorNickName'])) {
            $model->originatorNickName = $map['originatorNickName'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['originatorName'])) {
            $model->originatorName = $map['originatorName'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['activeTimeGMT'])) {
            $model->activeTimeGMT = $map['activeTimeGMT'];
        }
        if (isset($map['actualActionerId'])) {
            $model->actualActionerId = $map['actualActionerId'];
        }
        if (isset($map['originatorEmail'])) {
            $model->originatorEmail = $map['originatorEmail'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['outResultName'])) {
            $model->outResultName = $map['outResultName'];
        }
        if (isset($map['outResult'])) {
            $model->outResult = $map['outResult'];
        }
        if (isset($map['originatorPhoto'])) {
            $model->originatorPhoto = $map['originatorPhoto'];
        }
        if (isset($map['taskType'])) {
            $model->taskType = $map['taskType'];
        }
        if (isset($map['originatorNickNameEn'])) {
            $model->originatorNickNameEn = $map['originatorNickNameEn'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['titleInEnglish'])) {
            $model->titleInEnglish = $map['titleInEnglish'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['originatorNameInEnglish'])) {
            $model->originatorNameInEnglish = $map['originatorNameInEnglish'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
