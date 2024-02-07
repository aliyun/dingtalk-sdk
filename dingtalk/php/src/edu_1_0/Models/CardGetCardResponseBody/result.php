<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $attr;

    /**
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @example 23424234
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @example 1
     *
     * @var int
     */
    public $cardContentCount;

    /**
     * @example 2
     *
     * @var int
     */
    public $cardCycle;

    /**
     * @var int[]
     */
    public $cardFrequency;

    /**
     * @example 234234234324
     *
     * @var int
     */
    public $cardId;

    /**
     * @example 1
     *
     * @var int
     */
    public $cardStatus;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $cardUrl;

    /**
     * @example 音乐
     *
     * @var string
     */
    public $categoryContentTag;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $categoryCoverImageUrl;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $categoryCreateCardSmallImageUrl;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $categoryListSmallImageUrl;

    /**
     * @example 美术
     *
     * @var string
     */
    public $categoryName;

    /**
     * @var string[]
     */
    public $classIds;

    /**
     * @var string[]
     */
    public $classNames;

    /**
     * @example 打卡任务
     *
     * @var string
     */
    public $content;

    /**
     * @example dingdf19b4ee0d73233735c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2023-11-15
     *
     * @var string
     */
    public $effectTime;

    /**
     * @var bool
     */
    public $finished;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $media;

    /**
     * @example 2023-11-15
     *
     * @var string
     */
    public $optEndTime;

    /**
     * @example 234234234
     *
     * @var string
     */
    public $optEndUserId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $optEndUserName;

    /**
     * @example 20
     *
     * @var int
     */
    public $remindNotPunchCardHour;

    /**
     * @example 10
     *
     * @var int
     */
    public $remindNotPunchCardMinute;

    /**
     * @example 2023-11-15
     *
     * @var string
     */
    public $sendTime;

    /**
     * @example YUFANAI
     *
     * @var string
     */
    public $sourceType;

    /**
     * @example 2023-11-15
     *
     * @var string
     */
    public $startTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 424234324324
     *
     * @var int
     */
    public $systemTime;

    /**
     * @example 234234234
     *
     * @var string
     */
    public $teacherId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $teacherName;

    /**
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $templateCoverImageUrl;

    /**
     * @example 每日复习
     *
     * @var string
     */
    public $title;

    /**
     * @example 3
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'attr'                            => 'attr',
        'cardBizCode'                     => 'cardBizCode',
        'cardBizId'                       => 'cardBizId',
        'cardContentCount'                => 'cardContentCount',
        'cardCycle'                       => 'cardCycle',
        'cardFrequency'                   => 'cardFrequency',
        'cardId'                          => 'cardId',
        'cardStatus'                      => 'cardStatus',
        'cardUrl'                         => 'cardUrl',
        'categoryContentTag'              => 'categoryContentTag',
        'categoryCoverImageUrl'           => 'categoryCoverImageUrl',
        'categoryCreateCardSmallImageUrl' => 'categoryCreateCardSmallImageUrl',
        'categoryListSmallImageUrl'       => 'categoryListSmallImageUrl',
        'categoryName'                    => 'categoryName',
        'classIds'                        => 'classIds',
        'classNames'                      => 'classNames',
        'content'                         => 'content',
        'corpId'                          => 'corpId',
        'effectTime'                      => 'effectTime',
        'finished'                        => 'finished',
        'media'                           => 'media',
        'optEndTime'                      => 'optEndTime',
        'optEndUserId'                    => 'optEndUserId',
        'optEndUserName'                  => 'optEndUserName',
        'remindNotPunchCardHour'          => 'remindNotPunchCardHour',
        'remindNotPunchCardMinute'        => 'remindNotPunchCardMinute',
        'sendTime'                        => 'sendTime',
        'sourceType'                      => 'sourceType',
        'startTime'                       => 'startTime',
        'status'                          => 'status',
        'systemTime'                      => 'systemTime',
        'teacherId'                       => 'teacherId',
        'teacherName'                     => 'teacherName',
        'templateCoverImageUrl'           => 'templateCoverImageUrl',
        'title'                           => 'title',
        'type'                            => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attr) {
            $res['attr'] = $this->attr;
        }
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardContentCount) {
            $res['cardContentCount'] = $this->cardContentCount;
        }
        if (null !== $this->cardCycle) {
            $res['cardCycle'] = $this->cardCycle;
        }
        if (null !== $this->cardFrequency) {
            $res['cardFrequency'] = $this->cardFrequency;
        }
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->cardStatus) {
            $res['cardStatus'] = $this->cardStatus;
        }
        if (null !== $this->cardUrl) {
            $res['cardUrl'] = $this->cardUrl;
        }
        if (null !== $this->categoryContentTag) {
            $res['categoryContentTag'] = $this->categoryContentTag;
        }
        if (null !== $this->categoryCoverImageUrl) {
            $res['categoryCoverImageUrl'] = $this->categoryCoverImageUrl;
        }
        if (null !== $this->categoryCreateCardSmallImageUrl) {
            $res['categoryCreateCardSmallImageUrl'] = $this->categoryCreateCardSmallImageUrl;
        }
        if (null !== $this->categoryListSmallImageUrl) {
            $res['categoryListSmallImageUrl'] = $this->categoryListSmallImageUrl;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->classIds) {
            $res['classIds'] = $this->classIds;
        }
        if (null !== $this->classNames) {
            $res['classNames'] = $this->classNames;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->effectTime) {
            $res['effectTime'] = $this->effectTime;
        }
        if (null !== $this->finished) {
            $res['finished'] = $this->finished;
        }
        if (null !== $this->media) {
            $res['media'] = $this->media;
        }
        if (null !== $this->optEndTime) {
            $res['optEndTime'] = $this->optEndTime;
        }
        if (null !== $this->optEndUserId) {
            $res['optEndUserId'] = $this->optEndUserId;
        }
        if (null !== $this->optEndUserName) {
            $res['optEndUserName'] = $this->optEndUserName;
        }
        if (null !== $this->remindNotPunchCardHour) {
            $res['remindNotPunchCardHour'] = $this->remindNotPunchCardHour;
        }
        if (null !== $this->remindNotPunchCardMinute) {
            $res['remindNotPunchCardMinute'] = $this->remindNotPunchCardMinute;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->systemTime) {
            $res['systemTime'] = $this->systemTime;
        }
        if (null !== $this->teacherId) {
            $res['teacherId'] = $this->teacherId;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->templateCoverImageUrl) {
            $res['templateCoverImageUrl'] = $this->templateCoverImageUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['attr'])) {
            $model->attr = $map['attr'];
        }
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardContentCount'])) {
            $model->cardContentCount = $map['cardContentCount'];
        }
        if (isset($map['cardCycle'])) {
            $model->cardCycle = $map['cardCycle'];
        }
        if (isset($map['cardFrequency'])) {
            if (!empty($map['cardFrequency'])) {
                $model->cardFrequency = $map['cardFrequency'];
            }
        }
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['cardStatus'])) {
            $model->cardStatus = $map['cardStatus'];
        }
        if (isset($map['cardUrl'])) {
            $model->cardUrl = $map['cardUrl'];
        }
        if (isset($map['categoryContentTag'])) {
            $model->categoryContentTag = $map['categoryContentTag'];
        }
        if (isset($map['categoryCoverImageUrl'])) {
            $model->categoryCoverImageUrl = $map['categoryCoverImageUrl'];
        }
        if (isset($map['categoryCreateCardSmallImageUrl'])) {
            $model->categoryCreateCardSmallImageUrl = $map['categoryCreateCardSmallImageUrl'];
        }
        if (isset($map['categoryListSmallImageUrl'])) {
            $model->categoryListSmallImageUrl = $map['categoryListSmallImageUrl'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['classIds'])) {
            if (!empty($map['classIds'])) {
                $model->classIds = $map['classIds'];
            }
        }
        if (isset($map['classNames'])) {
            if (!empty($map['classNames'])) {
                $model->classNames = $map['classNames'];
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['effectTime'])) {
            $model->effectTime = $map['effectTime'];
        }
        if (isset($map['finished'])) {
            $model->finished = $map['finished'];
        }
        if (isset($map['media'])) {
            $model->media = $map['media'];
        }
        if (isset($map['optEndTime'])) {
            $model->optEndTime = $map['optEndTime'];
        }
        if (isset($map['optEndUserId'])) {
            $model->optEndUserId = $map['optEndUserId'];
        }
        if (isset($map['optEndUserName'])) {
            $model->optEndUserName = $map['optEndUserName'];
        }
        if (isset($map['remindNotPunchCardHour'])) {
            $model->remindNotPunchCardHour = $map['remindNotPunchCardHour'];
        }
        if (isset($map['remindNotPunchCardMinute'])) {
            $model->remindNotPunchCardMinute = $map['remindNotPunchCardMinute'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['systemTime'])) {
            $model->systemTime = $map['systemTime'];
        }
        if (isset($map['teacherId'])) {
            $model->teacherId = $map['teacherId'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['templateCoverImageUrl'])) {
            $model->templateCoverImageUrl = $map['templateCoverImageUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
