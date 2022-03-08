<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetNotifyMeResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description activityId
     *
     * @var string
     */
    public $activityId;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @description 创建者的userId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 流程实例id
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description instStatus
     *
     * @var string
     */
    public $instStatus;

    /**
     * @description mobileUrl
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @description processCode
     *
     * @var string
     */
    public $processCode;

    /**
     * @description title
     *
     * @var string
     */
    public $title;

    /**
     * @description titleEn
     *
     * @var string
     */
    public $titleInEnglish;

    /**
     * @description url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'activityId'      => 'activityId',
        'appType'         => 'appType',
        'corpId'          => 'corpId',
        'createTimeGMT'   => 'createTimeGMT',
        'creatorUserId'   => 'creatorUserId',
        'formInstanceId'  => 'formInstanceId',
        'instStatus'      => 'instStatus',
        'mobileUrl'       => 'mobileUrl',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'processCode'     => 'processCode',
        'title'           => 'title',
        'titleInEnglish'  => 'titleInEnglish',
        'url'             => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->instStatus) {
            $res['instStatus'] = $this->instStatus;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->titleInEnglish) {
            $res['titleInEnglish'] = $this->titleInEnglish;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
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
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['instStatus'])) {
            $model->instStatus = $map['instStatus'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['titleInEnglish'])) {
            $model->titleInEnglish = $map['titleInEnglish'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
